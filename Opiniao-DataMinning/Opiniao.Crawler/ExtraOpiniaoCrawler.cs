using HtmlAgilityPack;
using System.IO;
using System.Linq;
using System.Net;

namespace Opiniao.Crawler
{
    public class ExtraOpiniaoCrawler : OpiniaoCrawler
    {
        public ExtraOpiniaoCrawler(string pesquisa) : base(pesquisa, "Extra.com.br") { }

        private string ObterUrlProduto(string pesquisa)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(string.Format(@"http://buscando.extra.com.br/?strBusca={0}", pesquisa));
            request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64; rv:53.0) Gecko/20100101 Firefox/53.0";
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string htmlText = reader.ReadToEnd();

            var resultadoBusca = new HtmlDocument();
            resultadoBusca.LoadHtml(htmlText);

            var vitrine = resultadoBusca.DocumentNode.Descendants().
                FirstOrDefault(d => d.Attributes["class"] != null && d.Attributes["class"].Value == "vitrineProdutos");

            var produto = vitrine.Descendants().FirstOrDefault(x => x.Attributes["class"] != null && x.Attributes["class"].Value == "hproduct");

            var link = produto.Descendants().FirstOrDefault(x => x.Attributes["class"] != null && x.Attributes["class"].Value == "link url").Attributes["href"].Value;

            return link;
        }

        protected override void PopularDadosProduto(string pesquisa)
        {
            this.urlProduto = ObterUrlProduto(pesquisa);

            if (!string.IsNullOrWhiteSpace(this.urlProduto))
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(this.urlProduto);
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string htmlText = reader.ReadToEnd();

                var resultadoBusca = new HtmlDocument();
                resultadoBusca.LoadHtml(htmlText);

                var comments = resultadoBusca.DocumentNode.Descendants()
                    .Where(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Contains("pr-comments"));

                var com = comments.Select(x => HtmlAgilityPack.HtmlEntity.DeEntitize(ConvertUTF(x.InnerText))).Where(x => !x.StartsWith("Comentários sobre"));

                this.comentarios = com.ToArray();

                var divFullImage = resultadoBusca.DocumentNode.Descendants()
                       .Where(x => x.Id == "divFullImage").FirstOrDefault().Descendants();

                var imgUrl = divFullImage.FirstOrDefault(x => x.Attributes["itemprop"] != null && x.Attributes["itemprop"].Value.Contains("image")).Attributes["src"].Value;

                this.urlImagem = imgUrl;

                var produtoNome = resultadoBusca.DocumentNode.Descendants()
                    .Where(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Contains("produtoNome"));

                var nome = produtoNome.FirstOrDefault().Descendants().FirstOrDefault(x => x.Attributes["itemprop"] != null && x.Attributes["itemprop"].Value.Contains("name")).InnerText;

                this.nomeProduto = nome;
            }
        }
    }
}
