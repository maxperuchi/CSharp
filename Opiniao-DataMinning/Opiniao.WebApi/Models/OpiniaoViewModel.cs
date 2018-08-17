using System.Collections.Generic;
using Opiniao.NLP;

namespace Opiniao.WebApi.Models
{
    public class OpiniaoViewModel
    {
        public string Fonte { get; set; }

        public string UrlImagem { get; set; }

        public string NomeProduto { get; set; }

        public IEnumerable<Adjetivo> Opinioes { get; set; }

        public string UrlProduto { get; set; }
    }
}