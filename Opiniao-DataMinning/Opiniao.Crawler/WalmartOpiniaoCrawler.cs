using HtmlAgilityPack;
using System.IO;
using System.Linq;
using System.Net;

namespace Opiniao.Crawler
{
    public class WalmartOpiniaoCrawler : OpiniaoCrawler
    {
        public WalmartOpiniaoCrawler(string pesquisa) : base(pesquisa, "Walmart.com.br") { }

        private string ObterUrlProduto(string pesquisa)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(string.Format(@"https://www.walmart.com.br/busca/?ft={0}&PS=20", pesquisa));
            request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64; rv:53.0) Gecko/20100101 Firefox/53.0";
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string htmlText = reader.ReadToEnd();

            var resultadoBusca = new HtmlDocument();
            resultadoBusca.LoadHtml(htmlText);

            var productList = resultadoBusca.DocumentNode.Descendants().
                FirstOrDefault(d => d.Attributes["id"] != null && d.Attributes["id"].Value == "product-list");

            var produto = productList.Descendants().FirstOrDefault(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Contains("shelf-product-item"));

            var link = "https:" + produto.Descendants().FirstOrDefault(x => x.Name == "a").Attributes["href"].Value;

            return link;
        }

        protected override void PopularDadosProduto(string pesquisa)
        {
            this.urlProduto = ObterUrlProduto(pesquisa);

            if (!string.IsNullOrWhiteSpace(this.urlProduto))
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(this.urlProduto);
                request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64; rv:53.0) Gecko/20100101 Firefox/53.0";
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string htmlText = reader.ReadToEnd();

                var resultadoBusca = new HtmlDocument();
                resultadoBusca.LoadHtml(htmlText);

                var comments = resultadoBusca.DocumentNode.Descendants()
                    .Where(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Contains("description-customer-review"));

                var com = comments.Select(x => HtmlAgilityPack.HtmlEntity.DeEntitize(x.InnerText));

                this.comentarios = com.ToArray();

                this.urlImagem = @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRCIFEn7T5qlbLkwM1S9kdlzPGVHdmkwTZy1z5z7GZlCWStHRuN";
                
                var produtoNome = resultadoBusca.DocumentNode.Descendants()
                    .Where(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Contains("product-name"));

                var nome = produtoNome.FirstOrDefault().InnerText;

                this.nomeProduto = nome;
            }
        }
    }
}
