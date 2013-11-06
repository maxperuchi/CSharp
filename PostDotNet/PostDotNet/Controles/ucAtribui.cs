using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PostDotNet.Controles
{
    public partial class ucAtribui : UserControl
    {
        public ucAtribui()
        {
            InitializeComponent();
            lblTitulo.Text = "X <--- X" + CaixaEntrada.Mostrar("Informe o caractere a ser inserido:");
            lblTitulo.MouseDown += lblTitulo_MouseDown;
            lblTitulo.MouseUp += lblTitulo_MouseUp;
            lblTitulo.MouseMove += lblTitulo_MouseMove;
            ContextMenu = new ContextMenu();
            var menuExcluir = new MenuItem();
            menuExcluir.Text = "Excluir";
            menuExcluir.Click += menuExcluir_Click;
            ContextMenu.MenuItems.Add(menuExcluir);
            this.Draggable(true);
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
    }
}
