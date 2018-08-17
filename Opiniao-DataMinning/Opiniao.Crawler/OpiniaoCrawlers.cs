namespace Opiniao.Crawler
{
    public static class OpiniaoCrawlers
    {
        public static OpiniaoCrawler[] GetCrawlers(string pesquisa)
        {
            return new OpiniaoCrawler[]
            {
                new ExtraOpiniaoCrawler(pesquisa),
                new WalmartOpiniaoCrawler(pesquisa)
            };
        }
    }
}
