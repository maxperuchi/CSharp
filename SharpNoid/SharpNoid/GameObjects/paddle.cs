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
    public partial class paddle : UserControl
    {
        #region Atributos
        public enum TipoPaddle
        {
            Normal,
            Atirador,
            Expandido
        }

        private TipoPaddle _tipo;

        public TipoPaddle Tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
        }
        #endregion
        #region Metodos
        public void Atira()
        {
            MessageBox.Show("Atirou!");
        }
        #endregion
        #region Construtores
        public paddle()
        {
            InitializeComponent();
        }
        #endregion
    }
}
