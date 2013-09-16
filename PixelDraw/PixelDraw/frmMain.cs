using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PixelDraw
{
    public partial class frmMain : Form
    {
        public static int frm_x;
        public static int frm_y;
        List<pixel> lstPixels = new List<pixel>();
        List<int[]> lstLinhas = new List<int[]>();
        pixel _pixel;
        int contadorPixels = 0;
        private Cores _corSelecionada;
        enum Cores
        {
            Preto = 0,
            Azul = 1,
            Verde = 2,
            Ciano = 3,
            Vermelho = 4,
            Magenta = 5,
            Marrom = 6,
            CinzaClaro = 7,
            CinzaEscuro = 8,
            AzulClaro = 9,
            VerdeClaro = 10,
            CianoClaro = 11,
            VermelhoClaro = 12,
            MagentaClaro = 13,
            Amarelo = 14,
            Branco = 15
        }
        public static Boolean IsNumeric(string stringToTest)
        {
            int result;
            return int.TryParse(stringToTest, out result);
        }

        private void cboCor_SelectedIndexChanged(object obj, EventArgs e) //comboBox1_SelectedIndexChanged method
        {
            switch (cboCor.SelectedItem.ToString()) // if your selected color matchs a color of the three the form will show the corresponding color.
            {
                case "Preto":
                    {
                        _corSelecionada = Cores.Preto;
                        cboCor.BackColor = Color.Black;
                        cboCor.ForeColor = Color.White;
                        break;
                    }
                case "Azul":
                    {
                        cboCor.ForeColor = Color.White;
                        cboCor.BackColor = Color.DarkBlue;
                        _corSelecionada = Cores.Azul;
                        break;
                    }
                case "Verde":
                    {
                        cboCor.ForeColor = Color.White;
                        _corSelecionada = Cores.Verde;
                        cboCor.BackColor = Color.Green;
                        break;
                    }
                case "Ciano":
                    {
                        cboCor.ForeColor = Color.White;
                        _corSelecionada = Cores.Ciano;
                        cboCor.BackColor = Color.DarkCyan;
                        break;
                    }
                case "Vermelho":
                    {
                        cboCor.ForeColor = Color.White;
                        _corSelecionada = Cores.Vermelho;
                        cboCor.BackColor = Color.DarkRed;
                        break;
                    }
                case "Magenta":
                    {
                        cboCor.ForeColor = Color.White;
                        _corSelecionada = Cores.Magenta;
                        cboCor.BackColor = Color.DarkMagenta;
                        break;
                    }
                case "Marrom":
                    {
                        cboCor.ForeColor = Color.White;
                        _corSelecionada = Cores.Marrom;
                        cboCor.BackColor = Color.Olive;
                        break;
                    }
                case "CinzaClaro":
                    {
                        cboCor.ForeColor = Color.Black;
                        _corSelecionada = Cores.CinzaClaro;
                        cboCor.BackColor = Color.LightGray;
                        break;
                    }
                case "CinzaEscuro":
                    {
                        cboCor.ForeColor = Color.Black;
                        _corSelecionada = Cores.CinzaEscuro;
                        cboCor.BackColor = Color.DarkGray;
                        break;
                    }
                case "AzulClaro":
                    {
                        cboCor.ForeColor = Color.White;
                        _corSelecionada = Cores.AzulClaro;
                        cboCor.BackColor = Color.Blue;
                        break;
                    }
                case "VerdeClaro":
                    {
                        cboCor.ForeColor = Color.Black;
                        _corSelecionada = Cores.VerdeClaro;
                        cboCor.BackColor = Color.Lime;
                        break;
                    }
                case "CianoClaro":
                    {
                        cboCor.ForeColor = Color.Black;
                        _corSelecionada = Cores.CianoClaro;
                        cboCor.BackColor = Color.Cyan;
                        break;
                    }
                case "VermelhoClaro":
                    {
                        cboCor.ForeColor = Color.Black;
                        _corSelecionada = Cores.VermelhoClaro;
                        cboCor.BackColor = Color.Red;
                        break;
                    }
                case "MagentaClaro":
                    {
                        cboCor.ForeColor = Color.Black;
                        _corSelecionada = Cores.MagentaClaro;
                        cboCor.BackColor = Color.Magenta;
                        break;
                    }
                case "Amarelo":
                    {
                        cboCor.ForeColor = Color.Black;
                        _corSelecionada = Cores.Amarelo;
                        cboCor.BackColor = Color.Yellow;
                        break;
                    }
                case "Branco":
                    {
                        cboCor.ForeColor = Color.Black;
                        _corSelecionada = Cores.Branco;
                        cboCor.BackColor = Color.White;
                        break;
                    }
            }
        }

        public frmMain()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCor.Items.AddRange(Enum.GetNames(typeof(Cores)));
            cboCor.SelectedIndexChanged += new EventHandler(cboCor_SelectedIndexChanged);
            cboCor.SelectedIndex = 0;
            frmMain.frm_x = 650;
            frmMain.frm_y = 250;
            this.Location = new Point(frmMain.frm_x, frmMain.frm_y);
            frmTela tela = new frmTela();
            tela.Show();

            #region Definicao de linhas
            lstLinhas.Add(new int[2] { 1, 16 }); //1
            lstLinhas.Add(new int[2] { 17, 32 }); //2
            lstLinhas.Add(new int[2] { 33, 48 }); //3
            lstLinhas.Add(new int[2] { 49, 64 }); //4
            lstLinhas.Add(new int[2] { 65, 80 }); //5
            lstLinhas.Add(new int[2] { 81, 96 }); //6
            lstLinhas.Add(new int[2] { 97, 112 }); //7
            lstLinhas.Add(new int[2] { 113, 128 }); //8
            lstLinhas.Add(new int[2] { 129, 144 }); //9
            lstLinhas.Add(new int[2] { 145, 160 }); //10
            lstLinhas.Add(new int[2] { 161, 176 }); //11
            lstLinhas.Add(new int[2] { 177, 192 }); //12
            lstLinhas.Add(new int[2] { 193, 208 }); //13
            lstLinhas.Add(new int[2] { 209, 224 }); //14
            lstLinhas.Add(new int[2] { 225, 240 }); //15
            lstLinhas.Add(new int[2] { 241, 256 }); //16
            //(x)16x(y)16 = 256 pixels
            #endregion

            foreach (Control chkPixel in tela.Controls)
            {
                if (chkPixel is CheckBox)
                {
                    contadorPixels++;
                    chkPixel.Name = "chkPixel" + contadorPixels;
                    chkPixel.TabIndex = contadorPixels;
                    _pixel = new pixel();
                    _pixel.X = posXY(contadorPixels)[0];
                    _pixel.Y = posXY(contadorPixels)[1];
                    _pixel.Pintado = false;
                    lstPixels.Add(_pixel);
                    chkPixel.Click += new EventHandler(checkBox_CheckedChanged);
                }
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            lstPixels[checkBox.TabIndex - 1].Pintado = !lstPixels[checkBox.TabIndex - 1].Pintado;
            lstPixels[checkBox.TabIndex - 1].Cor = (int)_corSelecionada;
            if (checkBox.Checked)
            {
                checkBox.BackColor = cboCor.BackColor;
            }
            else
            {
                checkBox.BackColor = Color.White;
            }
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

        private bool ValidarCampos()
        {
            bool result=true;
            Regex RgxUrl = new Regex("[^a-z0-9A-Z]");
            if (!IsNumeric(txtPosX.Text) || int.Parse(txtPosX.Text) > 304 || int.Parse(txtPosX.Text) < 0)
            {
                MessageBox.Show("Posição X inválida!");
                result = false;
            }
            if (!IsNumeric(txtPosY.Text) || int.Parse(txtPosY.Text) > 184 || int.Parse(txtPosY.Text) < 0)
            {
                MessageBox.Show("Posição Y inválida!");
                result = false;
            }
            if (RgxUrl.IsMatch(txtFuncao.Text) || txtFuncao.Text.Equals(String.Empty))
            {
                MessageBox.Show("Nome da função inválido!");
                result = false;
            }
            return result;
        }

        private void GerarArquivo()
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "Arquivo Assembly (*.asm)|*.asm";
            ofd.DefaultExt = "*.asm";
            ofd.FileName = txtFuncao.Text;
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (!System.IO.File.Exists(ofd.FileName))
                {
                    System.IO.File.Create(ofd.FileName).Close();
                }
                else
                {
                    System.IO.File.Delete(ofd.FileName);
                    System.IO.File.Create(ofd.FileName).Close();
                }
                System.IO.TextWriter arquivo = System.IO.File.AppendText(ofd.FileName);
                arquivo.WriteLine(txtFuncao.Text + ":");
                foreach (pixel p in lstPixels)
                {
                    if (p.Pintado)
                    {
                        p.X += int.Parse(txtPosX.Text);
                        p.Y += int.Parse(txtPosY.Text);
                        arquivo.WriteLine("mov AX,0xA000");
                        arquivo.WriteLine("mov ES,AX");
                        arquivo.WriteLine("mov byte [ES:(" + p.Y + " * 320) + " + p.X + "]," + p.Cor);
                        arquivo.WriteLine();
                    }
                }
                arquivo.WriteLine(@"ret");
                arquivo.Close();
            }
        }

        private void cmdGerar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                GerarArquivo();
            }
        }
    }
}
