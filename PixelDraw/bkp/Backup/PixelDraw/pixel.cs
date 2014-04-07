using System;
using System.Collections.Generic;
using System.Text;

namespace PixelDraw
{
    public class pixel
    {
        #region Atributos da classe
        private int _EnderecoMemoria;
        private bool _Pintado;
        private string _NomeChkBox;
        private int _X;
        private int _Y;

        public string NomeChkBox
        {
            get { return _NomeChkBox; }
            set { _NomeChkBox = value; }
        }
        public decimal EnderecoMemoriaFormatadoDecimal
        {
            get { return 655360 + this.EnderecoMemoria; }
        }
        public string EnderecoMemoriaFormatadoHex
        {
            get { return String.Format("{0:x}", this.EnderecoMemoriaFormatadoDecimal); }
        }
        public int EnderecoMemoria
        {
            get { return _EnderecoMemoria; }
            set { _EnderecoMemoria = value; }
        }
        public int X
        {
            get { return _X; }
            set { _X = value; }
        }
        public int Y
        {
            get { return _Y; }
            set { _Y = value; }
        }
        public bool Pintado
        {
            get { return _Pintado; }
            set { _Pintado = value; }
        }
        #endregion
    }
}
