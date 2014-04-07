using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PixelDraw
{
    public partial class frmTela : Form
    {
        public frmTela()
        {
            InitializeComponent();
        }

        private void frmTela_Load(object sender, EventArgs e)
        {
            this.Location = new Point(frmMain.frm_x - 230, frmMain.frm_y);
        }
    }
}
