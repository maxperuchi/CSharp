using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculadora
{
    public class Formula : FormulaBase
    {
        public override string CodigoOperacao()
        {
            return "MULTIPLICAR";
        }

        public override string Descricao()
        {
            return "Multiplicar dois valores.";
        }

        public override double Exec()
        {
            Console.Write("Entre com o valor A: ");
            double a = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            Console.Write("Enter com o valor B: ");
            double b = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

            return a * b;
        }

    }
}
