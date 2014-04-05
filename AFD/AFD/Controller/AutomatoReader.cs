using AFD.Model;
using System.IO;
using System.Text.RegularExpressions;
namespace AFD.Controller
{
    public static class AutomatoReader
    {
        private static Automato automato;

        private static Regex transicaoRegex = new Regex("[d()q ]");

        public static Automato LerAutomato(string arquivoTexto)
        {
            automato = new Automato();

            LerEstados(arquivoTexto);
            LerTransicoes(arquivoTexto);

            return automato;
        }

        private static void LerTransicoes(string arquivoTexto)
        {
            StreamReader sr = new StreamReader(arquivoTexto);

            while(!sr.EndOfStream)
            {
                var linha = sr.ReadLine();

                if (linha.StartsWith("d("))
                {
                    var transicao = transicaoRegex.Replace(linha, "").Split(',');
                    automato.Transicoes.Add(new Transicao()
                    {
                        Origem = automato.Estados.Find(e => e.Id == int.Parse(transicao[0])),
                        Destino = automato.Estados.Find(e => e.Id == int.Parse(transicao[2])),
                        Simbolo = char.Parse(transicao[1])
                    });
                }
            }
        }

        private static void LerEstados(string arquivoTexto)
        {
            StreamReader sr = new StreamReader(arquivoTexto);
            
            while(!sr.EndOfStream)
            {
                var linha = sr.ReadLine();
                if (linha.StartsWith("Estados={"))
                {
                    var estados = linha.Replace("Estados={", "").Replace("}", "").Split(',');
                    foreach(var estado in estados)
                    {
                        automato.Estados.Add(new Estado() { Id = int.Parse(estado.TrimStart('q')) });
                    }
                }

                if (linha.StartsWith("EstadoInicial={"))
                {
                    int idEstadoInicial = int.Parse(linha.Replace("EstadoInicial={", "").Replace("}", "").TrimStart('q'));
                    automato.EstadoInicial = automato.Estados.Find(e => e.Id == idEstadoInicial);
                }

                if (linha.StartsWith("EstadosFinais={"))
                {
                    var estados = linha.Replace("EstadosFinais={", "").Replace("}", "").Split(',');
                    foreach (var estado in estados)
                    {
                        int idEstadoFinal =  int.Parse(estado.TrimStart('q'));
                        automato.EstadosFinais.Add(automato.Estados.Find(e => e.Id == idEstadoFinal));
                    }
                }
            }
        }
    }
}
