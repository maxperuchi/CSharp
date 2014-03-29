using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PostDotNet.Core;

namespace PostDotNet.Core
{
    public class Engine
    {
        static private Engine instance;
        public string[] Alfabeto { get; set; }
        static public Engine Instance()
        {
            if (instance == null)
            {
                instance = new Engine();
            }
            return instance;
        }
        private Engine()
        {
        }

        public string ExecutaTransicao(IControlePost controle, string variavelX)
        {
            string retorno = string.Empty;

            switch(controle.Tipo)
            {
                case TipoControle.Ler:
                {
                    try
                    {
                        controle.Simbolo = variavelX.Substring(0, 1);
                        retorno = variavelX.Substring(1, (variavelX.Length - 1));
                    }
                    catch(Exception e)
                    {
                        throw new LerException(e);
                    }
                    break;
                }

                case TipoControle.Atribui:
                {
                    try
                    {
                        var simbolo = controle.Simbolo;
                        retorno = variavelX + simbolo;
                    }
                    catch (Exception e)
                    {
                        throw new AtribuirException(e);
                    }
                    break;
                }

                case TipoControle.Aceita:
                {
                    retorno = variavelX;
                    throw new AceitaException();
                }

                case TipoControle.Rejeita:
                {
                    retorno = variavelX;
                    throw new RejeitaException();
                }
                
                case TipoControle.Partida:
                {
                    retorno = variavelX;
                    break;
                }
            }

            return retorno;
        }

        public string ProcessarRelacionamentos(List<Relacionamento> relacionamentos, string variavelX)
        {
            string retorno = variavelX;
            IControlePost ultimoControle = null;
            foreach (var relacionamento in relacionamentos)
            {
                if (!string.IsNullOrEmpty(relacionamento.SimboloCondicao))
                {
                    if (relacionamento.SimboloCondicao != ultimoControle.Simbolo)
                    {
                        continue;
                    }
                }

                if (relacionamento.Entrada != ultimoControle)
                {
                    retorno = Engine.Instance().ExecutaTransicao(relacionamento.Entrada, retorno);
                }
                retorno = Engine.Instance().ExecutaTransicao(relacionamento.Saida, retorno);
                ultimoControle = relacionamento.Saida;
            }
            return retorno;
        }
    }
}
