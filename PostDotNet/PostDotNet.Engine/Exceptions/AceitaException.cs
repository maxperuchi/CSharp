using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostDotNet.Core
{
    class AceitaException : MensagemPost
    {
        public AceitaException()
        {
            this.Mensagem = "Variável X aceita!";
        }
    }
}
