using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AFD
{
    public static class Util
    {
        public static void Marcar(this RichTextBox rtb, int inicio, int tamanho)
        {
            rtb.SelectionStart = inicio;
            rtb.SelectionLength = tamanho;
            rtb.SelectionColor = Color.White;
            rtb.SelectionBackColor = Color.Blue;

            rtb.SelectionStart = 0;
            rtb.SelectionLength = 0;
        }

        public static List<Ocorrencia> Ocorrencias;
    }
}
