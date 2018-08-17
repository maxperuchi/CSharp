using System.Windows.Forms;

namespace ClassAdapterTest.Lampadas
{
    public class Fluorescente
    {
        private bool isReatorAquecido = false;

        private void AquecerReator()
        {
            isReatorAquecido = true;

            MessageBox.Show("Reator aquecido!");
        }

        public string AquecerReatorELigar()
        {
            AquecerReator();

            if (isReatorAquecido)
            {
                return "Fluorescente";
            }

            return null;
        }
    }
}
