using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostDotNet.Core
{
    class LerException : MensagemPost
    {
        public Exception e { get; set; }
        public LerException(Exception e)
        {
            this.e = e;
            this.Mensagem = "Erro ao realizar transição de leitura.";
        }
    }
}
