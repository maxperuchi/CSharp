using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostDotNet.Core
{
    public class MensagemPost : Exception
    {
        public string Mensagem { get; set; }
    }
}
