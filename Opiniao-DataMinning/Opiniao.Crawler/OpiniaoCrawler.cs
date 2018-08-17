using System.Text;

namespace Opiniao.Crawler
{
    public abstract class OpiniaoCrawler
    {
        public string UrlProduto
        {
            get
            {
                return this.urlProduto;
            }
        }

        public string UrlImagem
        {
            get
            {
                return this.urlImagem;
            }
        }

        public string[] Comentarios
        {
            get
            {
                return this.comentarios;
            }
        }

        public string NomeProduto
        {
            get
            {
                return this.nomeProduto;
            }
        }

        public string NomeCrawler
        {
            get
            {
                return this.nomeCrawler;
            }
        }

        protected string urlProduto = null;
        protected string urlImagem = null;
        protected string[] comentarios = null;
        protected string nomeProduto = null;
        protected string nomeCrawler = null;

        protected abstract void PopularDadosProduto(string pesquisa);

        public OpiniaoCrawler(string pesquisa, string nomeCrawler)
        {
            this.nomeCrawler = nomeCrawler;
            this.PopularDadosProduto(pesquisa);
        }

        protected string ConvertUTF(string texto)
        {
            byte[] data = Encoding.Default.GetBytes(texto);

            string ret = Encoding.UTF8.GetString(data);

            return ret;
        }
    }
}
