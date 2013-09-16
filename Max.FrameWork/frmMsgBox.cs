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
    public partial class frmMsgBox : Form
    {
        #region Mover Form sem bordas
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0084) //WM_NCHITTEST
            {
                base.WndProc(ref m);

                if (m.Result == (IntPtr)1) //HTCLIENT. User clicks on the window client area
                {
                    m.Result = (IntPtr)2; //HTCAPTION. Now it's caption 
                }
            }
            else
            {
                base.WndProc(ref m);
            }
        }
        #endregion
        public frmMsgBox(string mensagem)
        {
            InitializeComponent();
            lblMensagem.Text = mensagem;
        }

        private void picOK_Click(object sender, EventArgs e)
        {
            frmMsgBox.ActiveForm.Close();
        }

        private void frmMsgBox_Load(object sender, EventArgs e)
        {

        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            frmMsgBox.ActiveForm.Close();
        }
    }
}
