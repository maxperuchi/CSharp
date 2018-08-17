namespace CommandPattern.Core
{
    public class LigarVentiladorCommand : ICommand
    {
        private IVentiladorComLuz ventilador;

        public LigarVentiladorCommand(IVentiladorComLuz ventilador)
        {
            this.ventilador = ventilador;
        }

        public void Execute()
        {
            ventilador.VentiladorLigado = true;
        }

        public override string ToString()
        {
            return "Ligar Ventilador";
        }
    }
}
