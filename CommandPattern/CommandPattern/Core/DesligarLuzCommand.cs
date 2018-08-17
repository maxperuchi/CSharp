namespace CommandPattern.Core
{
    public class DesligarLuzCommand : ICommand
    {
        private IVentiladorComLuz ventilador;

        public DesligarLuzCommand(IVentiladorComLuz ventilador)
        {
            this.ventilador = ventilador;
        }

        public void Execute()
        {
            ventilador.LuzLigada = false;
        }

        public override string ToString()
        {
            return "Desligar Luz";
        }
    }
}
