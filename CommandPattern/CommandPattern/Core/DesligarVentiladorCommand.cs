namespace CommandPattern.Core
{
    public class DesligarVentiladorCommand : ICommand
    {
        private IVentiladorComLuz ventilador;

        public DesligarVentiladorCommand(IVentiladorComLuz ventilador)
        {
            this.ventilador = ventilador;
        }

        public void Execute()
        {
            ventilador.VentiladorLigado = false;
        }

        public override string ToString()
        {
            return "Desligar Ventilador";
        }
    }
}
