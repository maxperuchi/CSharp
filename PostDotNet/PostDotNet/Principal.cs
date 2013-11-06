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
    public partial class Principal : Form
    {
        public Control ControleParaAdicionar { get; set; }
        public Principal()
        {
            InitializeComponent();
        }
        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            ControleParaAdicionar = new Controles.ucPartida();
            Cursor = Cursors.Hand;
        }
        private void pnlFluxograma_Click(object sender, EventArgs e)
        {
            if (this.ControleParaAdicionar != null)
            {
                ControleParaAdicionar.Location = ((MouseEventArgs)e).Location;
                pnlFluxograma.Controls.Add(ControleParaAdicionar);
                Cursor = Cursors.Arrow;
                ControleParaAdicionar = null;
            }
        }

        private void btnCriarAtribuir_Click(object sender, EventArgs e)
        {
            ControleParaAdicionar = new Controles.ucAtribui();
            Cursor = Cursors.Hand;
        }

        private void btnCriarRejeita_Click(object sender, EventArgs e)
        {
            ControleParaAdicionar = new Controles.ucRejeita();
            Cursor = Cursors.Hand;
        }

        private void btnCriarLer_Click(object sender, EventArgs e)
        {
            ControleParaAdicionar = new Controles.ucLer();
            Cursor = Cursors.Hand;
        }

        private void btnCriarAceita_Click(object sender, EventArgs e)
        {
            ControleParaAdicionar = new Controles.ucAceita();
            Cursor = Cursors.Hand;
        }
    }
}
