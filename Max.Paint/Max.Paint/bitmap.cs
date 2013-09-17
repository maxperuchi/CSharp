using System;
using System.Collections.Generic;
using System.Text;

namespace Max.Paint
{
    public class bitmap
    {
        public class pixel
        {
            private string _r;
            public byte R
            {
                get { return Convert.ToByte(_r, 16); }
            }

            private string _g;
            public byte G
            {
                get { return Convert.ToByte(_g, 16); }
            }

            private string _b;
            public byte B
            {
                get { return Convert.ToByte(_b, 16); }
            }
            
            public pixel(string val_R, string val_G, string val_B)
            {
                this._r = val_R;
                this._g = val_G;
                this._b = val_B;

                this._pix[0] = this.R;
                this._pix[1] = this.G;
                this._pix[2] = this.B;
            }

            private byte[] _pix = new byte[3];

            public byte[] GetPixel
            {
                get { return this._pix; }
            }
        }

        private List<pixel> _tela = new List<pixel>();

        public List<pixel> Tela
        {
            get { return _tela; }
            set { _tela = value; }
        }

        private string _altura;
        private string _largura;

        private void EscreveCabecalho(System.IO.BinaryWriter arquivo)
        {
            arquivo.Write(Convert.ToByte("42", 16));
            arquivo.Write(Convert.ToByte("4D", 16));
            arquivo.Write(Convert.ToByte("46", 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("36", 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("28", 16));
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte(this._largura, 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte(this._altura, 16));
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("01", 16)); 
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("18", 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("13", 16)); 
            arquivo.Write(Convert.ToByte("0B", 16)); 
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("13", 16)); 
            arquivo.Write(Convert.ToByte("0B", 16)); 
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("00", 16)); 
            arquivo.Write(Convert.ToByte("00", 16));
            arquivo.Write(Convert.ToByte("00", 16));
        }

        public void Salvar(string caminhoArquivo)
        {
            int contadorX = 0;
            System.IO.BinaryWriter arquivo = new System.IO.BinaryWriter(System.IO.File.Open(caminhoArquivo, System.IO.FileMode.Create));
            EscreveCabecalho(arquivo);
            for (int i = 0; i < _tela.Count; i++)
            {
                contadorX = contadorX + 1;
                arquivo.Write(this._tela[i].GetPixel);
                if (contadorX == int.Parse(this._largura))
                {
                    //arquivo.Write(Convert.ToByte("00", 16));
                    //arquivo.Write(Convert.ToByte("00", 16));
                    contadorX = 0;
                }
            }
            arquivo.Close();
        }

        public bitmap(List<pixel> tela, int tamanhoX, int tamanhoY)
        {
            this._tela = tela;
            this._largura = tamanhoX.ToString();
            this._altura = tamanhoY.ToString();
        }
        public bitmap(string caminhoArquivo)
        {
            System.IO.BinaryReader arquivo = new System.IO.BinaryReader(System.IO.File.Open(caminhoArquivo, System.IO.FileMode.Open));
            arquivo.ReadBytes(54);
            this._altura = "4";
            this._largura = "4";
            byte[] databytes = arquivo.ReadBytes(48);
            List<pixel> listPixels = new List<pixel>();
            for (int i = 0; i <= databytes.Length-3; i = i+3)
            {
                listPixels.Add(new pixel(databytes[i].ToString() == "255" ? "FF" : "00", databytes[i + 1].ToString() == "255" ? "FF" : "00", databytes[i + 2].ToString() == "255" ? "FF" : "00"));
            }
            this.Tela = listPixels;
            arquivo.Close();
        }

    }
}
