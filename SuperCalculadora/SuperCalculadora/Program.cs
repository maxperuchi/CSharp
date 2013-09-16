using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculadora
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Super Calculadora!\nFunções instaladas:\n\n  -  CÓDIGO - DESCRIÇÃO\n-----------------------");
            
            List<FormulaBase> FormulasInstaladas = new List<FormulaBase>();
            string[] Dlls =  Util.GetFiles(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "SC.*.dll", SearchOption.TopDirectoryOnly);

            foreach (string Dll in Dlls)
            {
                Assembly a = Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Dll));
                Type t = a.GetType("SuperCalculadora.Formula");
                object instance = t.InvokeMember(String.Empty, BindingFlags.CreateInstance, null, null, null);
                FormulaBase formula = (FormulaBase)instance;
                FormulasInstaladas.Add(formula);
                Console.WriteLine("  -  " + formula.CodigoOperacao() + " - " + formula.Descricao());
            }
            
            Console.Write("\nEscolha uma função digitando seu código: ");
            string CodDigitado = Console.ReadLine();

            FormulaBase FormulaSelecionada = FormulasInstaladas.SingleOrDefault(f => f.CodigoOperacao().ToLower() == CodDigitado.ToLower());
            if (FormulaSelecionada != null)
            {
                Console.WriteLine("Resultado: " + FormulaSelecionada.Exec());
            }
            else
            {
                Console.WriteLine("Função não encontrada!");
            }
         
            Console.ReadKey();
        }
    }
}
