using ClassAdapterTest.Lampadas;

namespace ClassAdapterTest
{
    public class AdapterFluorescenteToLED : Fluorescente, ILED
    {
        public string Ligar()
        {
            return AquecerReatorELigar();
        }
    }
}
