using System;
using System.Windows.Forms;

namespace SimuladorEscalonamento
{
    public partial class frmPrincipal : Form
    {
        private SisOp sisOp;

        public frmPrincipal()
        {
            InitializeComponent();
        }     

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            TravaCampos(true);

            sisOp = new SisOp(ucFila, ucFIlaEspera, ucProcessador, 
                int.Parse(txtQuantum.Text), int.Parse(txtTempoVida.Text), int.Parse(txtQtdMaxProc.Text),
                int.Parse(txtProbabilidadeIO.Text), int.Parse(txtProbabilidadeEspera.Text));

            sisOp.Iniciar();
        }

        private void TravaCampos(bool travar)
        {
            txtProbabilidadeIO.Enabled = txtQtdMaxProc.Enabled = txtQuantum.Enabled = txtTempoVida.Enabled = btnIniciar.Enabled = txtProbabilidadeEspera.Enabled = txtProbabilidadeIO.Enabled = !travar;
            btnParar.Enabled = travar;
        }

        private void processador_MudouEstado(object sender, Controles.ProcessadorEventArgs e)
        {
            lblStatus.Text = string.Format("Estado do processador: {0}", e.Estado.ToString());
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            TravaCampos(false);

            sisOp.Parar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (sisOp != null && sisOp.Executando)
            {
                sisOp.Parar();
            }

            this.Close();
        }
    }
}
