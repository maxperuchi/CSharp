using System;
using System.Collections.Generic;
using System.Linq;

namespace Opiniao.NLP
{
    public class Analisador
    {
        private readonly string texto;
        private readonly Processador processador;
        private readonly IEnumerable<PalavraClassificada> palavrasClassificadas;

        public Analisador(string texto, string sentenceModelPath, string tokenModelPath, string posModelPath)
        {
            this.texto = texto;

            processador = new Processador(sentenceModelPath, tokenModelPath, posModelPath);
            palavrasClassificadas = processador.ProcessarTexto(this.texto);
        }

        public IEnumerable<PalavraClassificada> ObterPalavrasClassificadas(Func<PalavraClassificada, bool> predicado = null)
        {
            if (predicado == null)
            {
                return this.palavrasClassificadas;
            }

            return this.palavrasClassificadas.Where(predicado);
        }

        public IEnumerable<Adjetivo> ObterAdjetivos(bool incluirSubstantivo = true)
        {
            var result = new List<Adjetivo>();
            var palavras = palavrasClassificadas.ToArray();

            for (int i = 0; i < palavras.Count(); i++)
            {
                if (palavras[i].Palavra != null && palavras[i].Tag == Processador.ADJETIVO)
                {
                    var adj = new Adjetivo() { Ocorrencia = 1 };
                    if (incluirSubstantivo && i > 0 && palavras[i - 1].Tag == Processador.SUBSTANTIVO && !PalavrasExcluidas(palavras[i].Palavra))
                    {
                        adj.Palavra = string.Format("{0} {1}", palavras[i - 1].Palavra, palavras[i].Palavra);
                    }
                    else if (incluirSubstantivo && i < (palavras.Count() - 1) && palavras[i + 1].Tag == Processador.SUBSTANTIVO && !PalavrasExcluidas(palavras[i].Palavra))
                    {
                        adj.Palavra = string.Format("{1} {0}", palavras[i + 1].Palavra, palavras[i].Palavra);
                    }
                    else if (!PalavrasExcluidas(palavras[i].Palavra))
                    {
                        adj.Palavra = palavras[i].Palavra;
                    }
                    else
                    {
                        continue;
                    }

                    var existente = result.FirstOrDefault(x => x.Palavra == adj.Palavra);
                    if (existente != null)
                    {
                        existente.Ocorrencia++;
                        continue;
                    }

                    result.Add(adj);
                }
            }

            return result;
        }

        private static bool PalavrasExcluidas(string palavra)
        {
            var palavrasExcluidas = new[]
            {
                ",E",
                ",O",
                ",A"
            };

            if (palavrasExcluidas.Contains(palavra.ToUpper()))
            {
                return true;
            }

            return false;
        }
    }
}