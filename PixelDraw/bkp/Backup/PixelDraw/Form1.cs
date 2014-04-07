using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PixelDraw
{
    public partial class Form1 : Form
    {
        List<pixel> lstPixels = new List<pixel>();
        List<int[]> lstLinhas = new List<int[]>();
        pixel _pixel;
        int contadorPixels = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Definicao de linhas
            lstLinhas.Add(new int[2] { 1, 26 });
            lstLinhas.Add(new int[2] { 27, 52 });
            lstLinhas.Add(new int[2] { 53, 78 });
            lstLinhas.Add(new int[2] { 79, 104 });
            lstLinhas.Add(new int[2] { 105, 130 });
            lstLinhas.Add(new int[2] { 131, 156 });
            lstLinhas.Add(new int[2] { 157, 182 });
            lstLinhas.Add(new int[2] { 183, 208 });
            lstLinhas.Add(new int[2] { 209, 234 });
            lstLinhas.Add(new int[2] { 235, 260 });
            lstLinhas.Add(new int[2] { 261, 286 });
            lstLinhas.Add(new int[2] { 287, 312 });
            lstLinhas.Add(new int[2] { 313, 338 });
            lstLinhas.Add(new int[2] { 339, 364 });
            lstLinhas.Add(new int[2] { 365, 390 });
            lstLinhas.Add(new int[2] { 391, 416 });
            //(x)26x(y)16 = 416 pixels
            #endregion

            foreach (Control chkPixel in this.Controls)
            {
                if (chkPixel is CheckBox)
                {
                    contadorPixels++;
                    chkPixel.Name = "chkPixel" + (417 - contadorPixels);
                    chkPixel.TabIndex = contadorPixels;
                    _pixel = new pixel();
                    _pixel.X = posXY(contadorPixels)[0];
                    _pixel.Y = posXY(contadorPixels)[1];
                    _pixel.Pintado = false;
                    _pixel.EnderecoMemoria = (320 * _pixel.Y) + _pixel.X;
                    _pixel.NomeChkBox = chkPixel.Name;
                    lstPixels.Add(_pixel);
                    chkPixel.Click += new EventHandler(checkBox_CheckedChanged);
                }
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            lstPixels[checkBox.TabIndex - 1].Pintado = !lstPixels[checkBox.TabIndex - 1].Pintado;
        }

        private int[] posXY(int numPixel)
        {
            int contLinhas = 0;
            int[] result = new int[2];
            int contCol = 0;
            foreach (int[] linha in lstLinhas)
            {
                contCol = 1;
                contLinhas++;
                for (int i = linha[0]; i <= linha[1]; i++)
                {
                    contCol++;
                    if (i == numPixel)
                    {
                            result[0] = contCol - 1;
                            result[1] = contLinhas;
                    }
                }
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (pixel p in lstPixels)
            {
                if (p.Pintado == true)
                    MessageBox.Show(p.EnderecoMemoriaFormatadoHex);
            }
        }
    }
}
