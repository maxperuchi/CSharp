using Opiniao.Crawler;
using Opiniao.NLP;
using Opiniao.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Opiniao.WebApi.Controllers
{
    public class OpiniaoController : ApiController
    {
        private static readonly string sentenceModelPath = HttpContext.Current.Server.MapPath("~/bin/pt-sent.bin");
        private static readonly string tokenModelPath = HttpContext.Current.Server.MapPath("~/bin/pt-token.bin");
        private static readonly string posModelPath = HttpContext.Current.Server.MapPath("~/bin/pt-pos-perceptron.bin");

        [HttpGet]
        [Route("opiniao/pesquisar")]
        public IHttpActionResult Pesquisar([FromUri] string pesquisa)
        {
            var result = new List<OpiniaoViewModel>();

            var crawlers = OpiniaoCrawlers.GetCrawlers(pesquisa);
            foreach (var crawler in crawlers)
            {
                var analisador = new Analisador(string.Join(Environment.NewLine, crawler.Comentarios), sentenceModelPath, tokenModelPath, posModelPath);

                var adj = analisador.ObterAdjetivos();
                if (adj.Any())
                {
                    result.Add(new OpiniaoViewModel()
                    {
                        Opinioes = adj,
                        Fonte = crawler.NomeCrawler,
                        NomeProduto = crawler.NomeProduto,
                        UrlImagem = crawler.UrlImagem,
                        UrlProduto = crawler.UrlProduto
                    });
                }
            }

            return Json(result);
        }
    }
}
