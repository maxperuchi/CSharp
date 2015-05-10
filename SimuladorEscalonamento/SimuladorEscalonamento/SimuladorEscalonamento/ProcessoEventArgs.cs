using System;

namespace SimuladorEscalonamento.Controles
{
    public class ProcessoEventArgs : EventArgs
    {
        public ucProcesso Processo { get; private set; }
    
        public ProcessoEventArgs(ucProcesso processo)
        {
            Processo = processo;
        }
    }
}
