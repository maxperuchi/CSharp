using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostDotNet.Core
{
    public class Relacionamento
    {
        public IControlePost Entrada { get; set; }
        public IControlePost Saida { get; set; }
        public string SimboloCondicao { get; set; }
    }
}
