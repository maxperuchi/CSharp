using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimuladorEscalonamento.Controles
{
    public partial class ucProcesso : UserControl
    {
        public bool IOBOund { get; set; }

        public event EventHandler<ProcessoEventArgs> ProcessarEvento;

        private bool emEspera;
        public bool EmEspera
        {
            get
            {
                return emEspera;
            }
            set
            {
                emEspera = value;
                if (emEspera)
                {
                    lblTempo.Cursor = lblId.Cursor = Cursors.Hand;
                    lblTempo.Click += processo_Click;
                    lblId.Click += processo_Click;
                }
                else
                {
                    lblTempo.Cursor = lblId.Cursor = Cursors.Default;
                    lblTempo.Click -= processo_Click;
                    lblId.Click -= processo_Click;
                }
            }
        }

        void processo_Click(object sender, EventArgs e)
        {
            if (ProcessarEvento != null)
            {
                ProcessarEvento(sender, new ProcessoEventArgs(this));
            }
        }

        private int tempo;
        public int Tempo
        {
            get
            {
                return tempo;
            }
            set
            {
                tempo = value;
                lblTempo.Text = value.ToString();
            }
        }

        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                lblId.Text = string.Format("Id {0}", value);
            }
        }

        public ucProcesso()
        {
            InitializeComponent();
        }

        private void ucProcesso_Paint(object sender, PaintEventArgs e)
        {
            if (IOBOund)
            {
                this.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }

        private void lblId_Paint(object sender, PaintEventArgs e)
        {
            if (EmEspera)
            {
                e.Graphics.DrawImage(Properties.Resources.pause, new Point(0, 5));
            }
            else
            {
                e.Graphics.DrawImage(Properties.Resources.play, new Point(0, 5));
            }
        }
    }
}
