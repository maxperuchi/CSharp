using System;
using System.Collections.Generic;
using System.Text;

namespace PixelDraw
{
    public class pixel
    {
        #region Atributos da classe
        private bool _Pintado;
        private int _X;
        private int _Y;
        private int _Cor;

        public int Cor
        {
            get { return _Cor; }
            set { _Cor = value; }
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
