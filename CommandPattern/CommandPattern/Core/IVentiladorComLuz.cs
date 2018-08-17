namespace CommandPattern.Core
{
    public interface IVentiladorComLuz
    {
        bool VentiladorLigado { get; set; }

        bool LuzLigada { get; set; }
    }
}
