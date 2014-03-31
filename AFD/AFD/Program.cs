using AFD.Controller;
using AFD.Model;
using System;
using System.Windows.Forms;

namespace AFD
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Console.Write("Entre com a palavra a ser processada: ");
                var palavra = Console.ReadLine();
                Automato automato = AutomatoReader.LerAutomato(ofd.FileName);
                automato.Palavra = palavra;
                automato.Execute();
            }
        }
    }
}
