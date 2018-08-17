using ClassAdapterTest.Lampadas;
using System;
using System.Windows.Forms;

namespace ClassAdapterTest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnLED_Click(object sender, EventArgs e)
        {
            var led = new LED();

            IluminarLED(led);
        }

        private void btnFluorescente_Click(object sender, EventArgs e)
        {
            var fluorescente = new AdapterFluorescenteToLED();

            IluminarLED(fluorescente);
        }

        private void IluminarLED(ILED led)
        {
            lblStatus.Text = string.Format("Status: Iluminado por {0}.", led.Ligar());
        }
    }
}
