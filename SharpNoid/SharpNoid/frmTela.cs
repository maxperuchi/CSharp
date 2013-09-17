using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using SharpNoid.GameObjects;
using System.Timers;


namespace SharpNoid
{
    public partial class frmTela : Form
    {
        private int _limiteEsquerdo = 20;
        private int _limiteDireito = 0;
        private int _xBola = 5;
        private int _yBola = 5;

        public frmTela()
        {
            InitializeComponent();
            this._limiteDireito = this.Size.Width - 330;
            this.SetStyle(
              ControlStyles.AllPaintingInWmPaint |
              ControlStyles.UserPaint |
              ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void frmTela_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemPeriod && paddle.Location.X < _limiteDireito)
            {
                paddle.Location = new Point(paddle.Location.X + 10, paddle.Location.Y);

            }
            else if (e.KeyCode == Keys.Oemcomma && paddle.Location.X > _limiteEsquerdo)
            {
                paddle.Location = new Point(paddle.Location.X - 10, paddle.Location.Y);
            }
            else if (e.KeyCode == Keys.Space && paddle.Tipo == GameObjects.paddle.TipoPaddle.Atirador)
            {
                paddle.Atira();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private bool _batido;
        private bool _tetou;
        Random r = new Random();
        private void tmrBola_Tick(object sender, EventArgs e)
        {
            if (Bateu(bola, paredeDireita) || Bateu(bola, teto) ||Bateu(bola, paredeEsquerda) || Bateu(bola,paddle))
                _batido = !_batido;

            if (_batido)
            {
                bola.Location = new Point(bola.Location.X - _xBola, bola.Location.Y - _yBola);
            }
            else
            {
                bola.Location = new Point(bola.Location.X + _xBola, bola.Location.Y + _yBola);
            }
         }

        private bool Bateu(ball parBola, Control parObjeto)
        {
            Rectangle rBola = new Rectangle(parBola.Location, parBola.Size);
            Rectangle rObjeto = new Rectangle(parObjeto.Location, parObjeto.Size);
            if(rBola.IntersectsWith(rObjeto))
            {
                if (parObjeto.Name == "teto" || _tetou)
                {
                    _xBola = r.Next(5, 10) * -1;
                    _tetou = true;
                }
                else if (parObjeto.Name == "paredeEsquerda")
                {
                    _xBola = r.Next(5, 10) * -1;
                    _tetou = true;
                }
                else
                {
                    _xBola = r.Next(5, 10) * 1;
                }
                _yBola = r.Next(5,10);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
