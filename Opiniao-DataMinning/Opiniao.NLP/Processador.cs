using System;
using System.Collections.Generic;

namespace Opiniao.NLP
{
    public class Processador
    {
        public static string ADJETIVO = "adj";
        public static string SUBSTANTIVO = "n";

        private string sentenceModelPath = @"pt-sent.bin";
        private string tokenModelPath = @"pt-token.bin";
        private string posModelPath = @"pt-pos-perceptron.bin";

        public Processador(string sentenceModelPath, string tokenModelPath, string posModelPath)
        {
            this.sentenceModelPath = sentenceModelPath;
            this.tokenModelPath = tokenModelPath;
            this.posModelPath = posModelPath;
        }

        public IEnumerable<PalavraClassificada> ProcessarTexto(string texto)
        {
            opennlp.tools.sentdetect.SentenceDetectorME sentenceParser = prepareSentenceDetector();

            opennlp.tools.tokenize.TokenizerME tokenizer = prepareTokenizer();

            opennlp.tools.postag.POSTaggerME posTagger = preparePos();

            String[] sentences = sentenceParser.sentDetect(texto);

            var results = new List<PalavraClassificada>();

            foreach (string sentence in sentences)
            {
                string[] tokens = tokenizer.tokenize(sentence);
                string[] tags = posTagger.tag(tokens);
                opennlp.tools.postag.POSSample sample = new opennlp.tools.postag.POSSample(tokens, tags);
                string[] samples = sample.toString().Split(' ');

                foreach (var s in samples)
                {
                    var palavra = s.Split('_')[0].ToUpper();
                    var tag = s.Split('_')[1];

                    results.Add(new PalavraClassificada()
                    {
                        Palavra = palavra,
                        Tag = tag
                    });
                }
            }

            return results;
        }

        private opennlp.tools.tokenize.TokenizerME prepareTokenizer()
        {
            java.io.FileInputStream tokenInputStream = new java.io.FileInputStream(tokenModelPath);
            opennlp.tools.tokenize.TokenizerModel tokenModel = new opennlp.tools.tokenize.TokenizerModel(tokenInputStream);
            return new opennlp.tools.tokenize.TokenizerME(tokenModel);
        }
        private opennlp.tools.sentdetect.SentenceDetectorME prepareSentenceDetector()
        {
            java.io.FileInputStream sentModelStream = new java.io.FileInputStream(sentenceModelPath);
            opennlp.tools.sentdetect.SentenceModel sentModel = new opennlp.tools.sentdetect.SentenceModel(sentModelStream);
            return new opennlp.tools.sentdetect.SentenceDetectorME(sentModel);
        }
        private opennlp.tools.postag.POSTaggerME preparePos()
        {
            java.io.FileInputStream modelInputStream = new java.io.FileInputStream(posModelPath);
            opennlp.tools.postag.POSModel model = new opennlp.tools.postag.POSModel(modelInputStream);
            return new opennlp.tools.postag.POSTaggerME(model);
        }
    }
}