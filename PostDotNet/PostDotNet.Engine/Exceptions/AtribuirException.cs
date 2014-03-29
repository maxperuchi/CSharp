using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostDotNet.Core
{
    class AtribuirException : MensagemPost
    {
        public Exception e { get; set; }
        public AtribuirException(Exception e)
        {
            this.e = e;
            this.Mensagem = "Erro ao executar transição de atribuição";
        }
    }
}
