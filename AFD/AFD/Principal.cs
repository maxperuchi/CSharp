using AFD.Controller;
using System.IO;
using System.Windows.Forms;

namespace AFD
{
    public partial class Principal : Form
    {
        Automato automato;
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCarregarTexto_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofdTxt = new OpenFileDialog();
            if (ofdTxt.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var txt = new StreamReader(ofdTxt.FileName);

                Texto.Text = txt.ReadToEnd();

                //btnCarregarAutomato.Enabled = true;
            }
        }

        private void btnCarregarAutomato_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofdAutomato = new OpenFileDialog();
            if (ofdAutomato.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                automato = AutomatoReader.LerAutomato(ofdAutomato.FileName);
                btnExecutar.Enabled = true;
            }
        }

        private void btnExecutar_Click(object sender, System.EventArgs e)
        {
            Util.Ocorrencias = new System.Collections.Generic.List<Ocorrencia>();

            automato.Palavra = Texto.Text;

            automato.Execute();

            Util.Ocorrencias.ForEach(o => Texto.Marcar(o.Inicio, o.Tamanho));
            label2.Text = Util.Ocorrencias.Count.ToString();
        }
    }
}
