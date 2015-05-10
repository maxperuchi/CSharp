using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SimuladorEscalonamento.Controles
{
    public partial class ucProcessador : UserControl
    {
        public event EventHandler<ProcessadorEventArgs> MudouEstado;

        private int probabilidadeEspera;

        private ucProcesso Processo = null;

        private ucFila Fila = null;

        private ucFIlaEspera FilaEspera = null;

        private System.Windows.Forms.Timer timer;

        private int quantum;
        public void SetarQuantum(int valor)
        {
            quantum = valor;
            lblQuantum.Text = string.Format("Quantum: {0}", valor);
            if (valor > 0)
            {
                timer.Interval = valor * 1000;
            }
        }

        public void SetarFila(ucFila valor)
        {
            Fila = valor;
        }

        public void SetarFilaEspera(ucFIlaEspera valor)
        {
            FilaEspera = valor;
        }

        public void SetarProbabilidadeEspera(int valor)
        {
            probabilidadeEspera = valor;
        }

        public void Carregar(ucProcesso processo)
        {
            if (Processo == null)
            {
                this.Processo = processo;
                pnlProcesso.Controls.Add(processo);
                processo.Location = new Point(2, 2);
            }
            else
            {
                throw new Exception("Já existe um processo em execução!");
            }
        }

        public void Iniciar()
        {
            if (quantum <= 0)
            {
                throw new Exception("Você precisa informar o Quantum!");
            }

            if (Fila == null)
            {
                throw new Exception("Você precisa informar a Fila!");
            }

            timer.Start();
        }

        public ucProcesso RetirarProcesso()
        {
            if (Processo != null)
            {
                var p = Processo;
                pnlProcesso.Controls.Remove(p);
                Processo = null;

                return p;
            }

            throw new Exception("Não existe processo em execução!");
        }

        public ucProcessador()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Processar();
        }

        private void Processar()
        {
            if (Processo == null)
            {
                var p = Fila.RetirarProximoProcesso();
                if (p == null)
                {
                    MudouEstado(this, new ProcessadorEventArgs(EstadoProcessador.Aguardando));

                    return;
                }

                Carregar(p);

                MudouEstado(this, new ProcessadorEventArgs(EstadoProcessador.Processando));

                Refresh();

                return;
            }

            for (int i = 1; i <= quantum; i++)
            {
                Processo.Tempo = Processo.Tempo - 1;

                Thread.Sleep(1000);

                Refresh();
            }
            Thread.Sleep(1000);

            if (Processo.Tempo <= 0)
            {
                RetirarProcesso();
            }
            else
            {
                var r = new Random();
                bool emEspera = (r.Next(1, 100) < probabilidadeEspera);

                if (Processo.IOBOund && emEspera)
                {
                    Processo.EmEspera = true;
                    FilaEspera.AdicionarProcesso(RetirarProcesso());
                }
                else
                {
                    Fila.AdicionarProcesso(RetirarProcesso());
                }
            }

            MudouEstado(this, new ProcessadorEventArgs(EstadoProcessador.Ocioso));
        }

        public void Parar()
        {
            if (Processo != null)
            {
                RetirarProcesso();
            }

            SetarQuantum(0);
            timer.Stop();
            MudouEstado(this, new ProcessadorEventArgs(EstadoProcessador.Aguardando));
        }
    }
}
