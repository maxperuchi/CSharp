using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SharpNoid.GameObjects
{
    public partial class ball : UserControl
    {
        enum TipoBola
        {
            Normal,
            Fogo,
            Multi
        }
        private TipoBola _tipo;
        private TipoBola Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private int _velocidade;
        public int Velocidade
        {
            get { return _velocidade; }
            set { _velocidade = value; }
        }
        public ball()
        {
            InitializeComponent();
        }
    }
}
