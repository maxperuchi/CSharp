using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PostDotNet.Core;

namespace PostDotNet
{
    public partial class Principal : Form
    {
        public Control ControleParaAdicionar { get; set; }
        public Point? PontoA { get; set; }
        public Point? PontoB { get; set; }
        private bool _criandoRelacionamento;
        public bool CriandoRelacionamento
        {
            get
            {
                return this._criandoRelacionamento;
            }

            set
            {
                this._criandoRelacionamento = value;
                if (value)
                {
                    Cursor = Cursors.Hand;
                }
                else
                {
                    Cursor = Cursors.Default;
                }
            }
        }
        public Principal()
        {
            InitializeComponent();
        }
        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            ControleParaAdicionar = new ucPartida();
            Cursor = Cursors.Hand;
        }
        private void pnlFluxograma_Click(object sender, EventArgs e)
        {
            if (ControleParaAdicionar != null)
            {
                var posClick = ((MouseEventArgs)e).Location;
                ControleParaAdicionar.Location = posClick;
                ControleParaAdicionar.Click += ControleParaAdicionar_Click;
                pnlFluxograma.Controls.Add(ControleParaAdicionar);
                Cursor = Cursors.Arrow;
                ControleParaAdicionar = null;
            }
        }

        void ControleParaAdicionar_Click(object sender, EventArgs e)
        {
            var controle = (Control)sender;
            if (CriandoRelacionamento)
            {
                if (PontoA == null)
                {
                    PontoA = controle.Location;
                }
                else if (PontoB == null)
                {
                    PontoB = controle.Location;
                    DesenharLinha(PontoA, PontoB);
                    CriandoRelacionamento = false;
                }
            }

        }

        private void btnCriarAtribuir_Click(object sender, EventArgs e)
        {
            ControleParaAdicionar = new ucAtribui(CaixaEntrada.Mostrar("Atribuir simobolo:"));
            Cursor = Cursors.Hand;
        }

        private void btnCriarRejeita_Click(object sender, EventArgs e)
        {
            ControleParaAdicionar = new ucRejeita();
            Cursor = Cursors.Hand;
        }

        private void btnCriarLer_Click(object sender, EventArgs e)
        {
            ControleParaAdicionar = new ucLer();
            Cursor = Cursors.Hand;
        }

        private void btnCriarAceita_Click(object sender, EventArgs e)
        {
            ControleParaAdicionar = new ucAceita();
            Cursor = Cursors.Hand;
        }

        private void btnVariavelX_Click(object sender, EventArgs e)
        {
            txtVariavelX.Text = CaixaEntrada.Mostrar("Entre com a variável X:");
        }

        private void btnAlfabeto_Click(object sender, EventArgs e)
        {
            lblAlfabeto.Text = CaixaEntrada.Mostrar("Entre com o alfabeto separado por vírgula:");
            Engine.Instance().Alfabeto = lblAlfabeto.Text.Split(',');
        }

        private void DesenharLinha(Point? pontoA, Point? pontoB)
        {
            if (pontoA != null && pontoB != null)
            {
                var pA = (Point)pontoA;
                var pB = (Point)pontoB;
                var painel = Principal.ActiveForm.Controls["pnlFluxograma"];
                painel.CreateGraphics().DrawLine(new Pen(Color.Black, 1), pA, pB);
            }
        }

        private void btnRelacionamento_Click(object sender, EventArgs e)
        {
            CriandoRelacionamento = true;
            PontoA = null;
            PontoB = null;
        }
    }
}
