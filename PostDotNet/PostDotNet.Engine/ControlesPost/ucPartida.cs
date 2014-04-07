using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PostDotNet.Core
{
    public partial class ucPartida : UserControl, IControlePost
    {
        public ucPartida()
        {
            InitializeComponent();
            lblTitulo.MouseDown += lblTitulo_MouseDown;
            lblTitulo.MouseUp += lblTitulo_MouseUp;
            lblTitulo.MouseMove += lblTitulo_MouseMove;
            ContextMenu = new ContextMenu();
            var menuExcluir = new MenuItem();
            menuExcluir.Text = "Excluir";
            menuExcluir.Click += menuExcluir_Click;
            ContextMenu.MenuItems.Add(menuExcluir);
            this.Draggable(true);
            this.Tipo = TipoControle.Partida;
        }

        void menuExcluir_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseMove(e);
        }

        void lblTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            OnMouseUp(e);
        }

        void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }


        public string Simbolo { get; set; }
        public TipoControle Tipo { get; set; }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
