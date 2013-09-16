using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculadora
{
    public abstract class FormulaBase
    {
        public abstract string Descricao();

        public abstract string CodigoOperacao();

        public abstract double Exec();
    }
}
