using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostDotNet.Core
{
    class RejeitaException : MensagemPost
    {
        public RejeitaException()
        {
            this.Mensagem = "Variável X rejeitada!";
        }
    }
}
