using System;
using System.Windows.Forms;
using VUMeter.Controller;
using VUMeter.Controllers;

namespace VUMeter
{
    static class Program
    {
        public static CoreController CoreController { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CoreController = new CoreController();
            Application.Run(new Main());
        }
    }
}
