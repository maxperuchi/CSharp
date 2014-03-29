using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PostDotNet
{
    public partial class CaixaEntrada : Form
    {
        private static CaixaEntrada instance;
        private static string Retorno;
        private CaixaEntrada()
        {
            InitializeComponent();
            Retorno = null;
            Size = flpCentro.Size;
        }

        static public string Mostrar(string Mensagem)
        {
            instance = new CaixaEntrada();
            instance.lblMensagem.Text = Mensagem;
            instance.ShowDialog();
            instance = null;
            return Retorno;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Retorno = txtEntrada.Text;
            instance.Close();
        }

        private void txtEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnOK_Click(sender,e);
            }
        }
    }
}
