using System;

namespace SimuladorEscalonamento.Controles
{
    public enum EstadoProcessador
    {
        Aguardando = 0,
        Ocioso = 1,
        Processando = 2
    }
    public class ProcessadorEventArgs : EventArgs
    {
        public EstadoProcessador Estado { get; private set; }
        public ProcessadorEventArgs(EstadoProcessador estado)
        {
            Estado = estado;
        }
    }
}
