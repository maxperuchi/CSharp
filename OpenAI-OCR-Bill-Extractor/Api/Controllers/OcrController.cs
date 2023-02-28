using Google.Cloud.Vision.V1;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Api.DTOs;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class OcrController : ControllerBase
{
    private readonly ILogger<OcrController> _logger;
    private readonly HttpClient _httpClient;
    private readonly string _openAiApiKey = "your-key-here";

    public OcrController(ILogger<OcrController> logger)
    {
        _logger = logger;
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + _openAiApiKey);
        _httpClient.DefaultRequestHeaders.Add("OpenAI-Organization", "org-cVaoEPyotAxOfBCOcU4vRsjD");
    }

    [HttpGet]
    [Route("OCR")]
    public async Task<NotaFiscalDTO[]> OCR(CancellationToken cancellationToken = default)
    {
        try
        {
            var notas = new List<NotaFiscalDTO>();

            var diretorio = @"../NotasTeste";
            
            var extensoesImagens = new string[] { ".jpeg", ".jpg", ".png", ".bmp" };

            var arquivos = Directory.EnumerateFiles(diretorio);
            
            foreach(var arquivo in arquivos)
            {
                NotaFiscalDTO nota = null;

                var info = new FileInfo(arquivo);

                if (extensoesImagens.Contains(info.Extension))
                {
                    nota = await ObterDadosDeImagem(arquivo, cancellationToken);
                }

                if (nota is not null)
                {
                    nota.nomeArquivo = info.Name;
                    notas.Add(nota);
                }
            }

            return notas.ToArray();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    
    private async Task<NotaFiscalDTO> ExtrairDadosUsandoOpenAI(string texto, CancellationToken cancellationToken)
    {
        try 
        {
            var requestContent = JsonSerializer.Serialize(
            new
            {
                model = "text-davinci-003",
                prompt = "retornar somente um json neste formato: "+
                    "\"{\"valorTotal\":decimal,\"items\":[{\"nome\":\"string\",\"valor\":decimal,\"categoria\":\"string\"}]}\"" +
                    ". nos campos valor e valorTotal usar ponto ao invés de vírgula." +
                    "o campo categoria baseado no nome do item." +
                    " o conteúdo do json será extraido do cupom fiscal a seguir:" 
                    + texto,

                //Controla a "criatividade" da geração de texto, ajustando a probabilidade de escolha de palavras. 
                //Quando a temperatura é baixa (próxima a zero), o modelo tende a gerar texto mais conservador, com escolhas mais prováveis de palavras.
                //Quando a temperatura é alta (acima de um), o modelo tende a gerar texto mais diversificado, escolhendo palavras menos prováveis.
                //Valores mais baixos, representam respostas menos criativas e mais precisas
                temperature =  0,

                //Limita o número máximo de tokens (palavras ou símbolos) que o modelo pode gerar em uma única chamada à API. 
                //Isso é útil para controlar a extensão do texto gerado.
                max_tokens = 3000,

                //Controla a porcentagem máxima de escolhas de palavras permitidas pelo modelo. 
                //O modelo ordena as probabilidades de cada palavra e escolhe as palavras com as probabilidades mais altas até que a soma dessas probabilidades alcance o valor top_p
                //Valores mais altos, representam respostas menos criativas e mais precisas
                top_p = 1,

                //Valor que penaliza o modelo por repetir as mesmas palavras ou frases. 
                //Isso ajuda a garantir que o texto gerado seja mais variado.
                frequency_penalty = 0,

                //Valor que penaliza o modelo por gerar palavras ou frases que já apareceram no prompt (texto de entrada). 
                //Isso ajuda a garantir que o texto gerado seja mais original e relevante.
                presence_penalty = 0
            });

            var request = new StringContent(requestContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://api.openai.com/v1/completions", request, cancellationToken);

            var responseData = await response.Content.ReadFromJsonAsync<OpenAIResponseDTO>((JsonSerializerOptions?)null, cancellationToken);
            var textContent = responseData?.choices?.FirstOrDefault()?.text;
            Console.WriteLine(textContent);
            var json = textContent?.Replace("\n", " ").Replace("\t", " ").Replace("\r", " ");

            var dto = JsonSerializer.Deserialize<NotaFiscalDTO>(json, new JsonSerializerOptions() 
            { 
                PropertyNameCaseInsensitive = true,
                AllowTrailingCommas = true
            });

            return dto;
        }
        catch
        {
            return null;
        }
    }

    private async Task<NotaFiscalDTO> ObterDadosDeImagem(string imagePath, CancellationToken cancellationToken)
    {
        try
        {
            var result = new StringBuilder();
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            var image = Image.FromFile(imagePath);
            IReadOnlyList<EntityAnnotation> textAnnotations = client.DetectText(image);
            foreach (EntityAnnotation text in textAnnotations)
            {
                result.Append(text.Description);
            }

            var texto = result.ToString().Replace("\n", " ");
            var notaDto = await ExtrairDadosUsandoOpenAI(texto, cancellationToken);

            return notaDto;
        }
        catch
        {
            return null;
        }
    }
}
