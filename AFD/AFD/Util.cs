using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AFD
{
    public static class Util
    {
        private static Color selectionColor = Color.Blue;

        public static void Marcar(this RichTextBox rtb, int inicio, int tamanho)
        {
            rtb.SelectionStart = inicio;
            rtb.SelectionLength = tamanho;
            rtb.SelectionColor = Color.White;
            rtb.SelectionBackColor = selectionColor;

            rtb.SelectionStart = 0;
            rtb.SelectionLength = 0;

            TrocarCor();
        }

        private static void TrocarCor()
        {
            if (selectionColor == Color.Blue)
                selectionColor = Color.Red;
            else
                selectionColor = Color.Blue;
        }

        public static List<Ocorrencia> Ocorrencias;
    }
}
