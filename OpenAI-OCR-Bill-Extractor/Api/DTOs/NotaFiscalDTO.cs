namespace Api.DTOs;

public class NotaFiscalDTO
{
    public string nomeArquivo { get; set; }
    public decimal? valorTotal { get; set; }
    public NotaFiscalDTOItem[] items { get; set; }
}

public class NotaFiscalDTOItem
{
    public string nome { get; set; }
    public decimal? valor { get; set; }
    public string categoria { get; set; }
}