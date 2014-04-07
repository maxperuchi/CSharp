using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculadora
{
    public class Formula : FormulaBase
    {
        
        public override string  Descricao()
        {
            return "Somar dois valores.";
        }

        public override string CodigoOperacao()
        {
            return "SOMAR";
        }

        public override double Exec()
        {
            Console.Write("Entre com o valor A: ");
            double a = Convert.ToDouble(Console.ReadLine().Replace('.',','));
            Console.Write("Entre com o vaor B: ");
            double b = Convert.ToDouble(Console.ReadLine().Replace('.',','));

            return a + b;
        }
    }
}
