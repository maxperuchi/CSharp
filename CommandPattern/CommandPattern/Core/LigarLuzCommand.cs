namespace CommandPattern.Core
{
    public class LigarLuzCommand : ICommand
    {
        private IVentiladorComLuz ventilador;

        public LigarLuzCommand(IVentiladorComLuz ventilador)
        {
            this.ventilador = ventilador;
        }

        public void Execute()
        {
            ventilador.LuzLigada = true;
        }

        public override string ToString()
        {
            return "Ligar Luz";
        }
    }
}
