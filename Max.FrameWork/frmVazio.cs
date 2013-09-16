using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Max.FrameWork
{
    public partial class frmVazio : Form
    {
        public frmVazio()
        {
            InitializeComponent();
        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            frmVazio.ActiveForm.Close();
        }
    }
}
