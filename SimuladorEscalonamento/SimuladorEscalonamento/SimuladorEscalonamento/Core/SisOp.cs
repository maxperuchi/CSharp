using SimuladorEscalonamento.Controles;
using System;
using System.Windows.Forms;

namespace SimuladorEscalonamento
{
    public class SisOp
    {
        private int contadorProcessos;

        public bool Executando { get; private set; }

        private Timer timer;

        private int quantum, tempoVida, qtdMaxProcessos, probIO, probIOEspera;
        private IFila Fila, FilaEspera;

        private ucProcessador Processador;

        public SisOp(IFila fila, IFila filaEspera, ucProcessador processador, int quantum, int tempoVida, int qtdMaxProcessos, int probIO, int probIOEspera)
        {
            timer = new Timer();
            timer.Interval = 60000;
            timer.Tick += timer_Tick;

            Fila = fila;
            FilaEspera = filaEspera;
            Processador = processador;

            this.quantum = quantum;
            this.tempoVida = tempoVida;
            this.qtdMaxProcessos = qtdMaxProcessos;
            this.probIO = probIO;
            this.probIOEspera = probIOEspera;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            CriarProcessos();
        }
        
        private void CriarProcessos()
        {
            for (int i = 0; i < qtdMaxProcessos; i++)
            {
                var r = new Random();
                bool ioBound = (r.Next(1, qtdMaxProcessos) < (probIO * qtdMaxProcessos) / 100);

                var proc = new Controles.ucProcesso() { IOBOund = ioBound, Tempo = tempoVida, Id = contadorProcessos };
                proc.ProcessarEvento += proc_ProcessarEvento;
                Fila.AdicionarProcesso(proc);
                contadorProcessos++;
            }
        }

        void proc_ProcessarEvento(object sender, ProcessoEventArgs e)
        {
            e.Processo.EmEspera = false;
            FilaEspera.RemoverProcesso(e.Processo);
            Fila.AdicionarProcesso(e.Processo);
        }

        public void Iniciar()
        {
            contadorProcessos = 1;
            Processador.SetarQuantum(quantum);
            Processador.SetarFila(Fila);
            Processador.SetarFilaEspera(FilaEspera);
            Processador.SetarProbabilidadeEspera(probIOEspera);

            CriarProcessos();

            Processador.Iniciar();

            timer.Start();

            Executando = true;
        }

        public void Parar()
        {
            timer.Stop();
            Processador.Parar();

            Fila.Limpar();
            FilaEspera.Limpar();

            Executando = false;
        }
    }
}
