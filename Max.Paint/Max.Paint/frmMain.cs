using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Max.Paint
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            cboCor.SelectedIndex = 3;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private bool IsCheckBox(Control controle)
        {
            if (controle.Name != "cboCor" && controle.Name != "btnSalvar" && controle.Name != "btnCarregar" && controle.Name != "btnFechar" && controle.Name != "lblTitulo" && controle.Name != "btnNovo")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Pintado(bitmap.pixel p)
        {
            if ((p.B == 255 || p.G == 255 || p.R == 255) && !(p.B == 255 && p.G == 255 && p.R == 255) || (p.B == 0 && p.G == 0 && p.R == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void checkboxis_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            switch (cboCor.Text)
            {
                case "Vermelho":
                    chk.BackColor = Color.Red;
                    break;
                case "Verde":
                    chk.BackColor = Color.Green;
                    break;
                case "Azul":
                    chk.BackColor = Color.Blue;
                    break;
                case "Branco":
                    chk.BackColor = Color.White;
                    break;
                case "Preto":
                    chk.BackColor = Color.Black;
                    break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                if (IsCheckBox(controle))
                {
                    CheckBox chk = (CheckBox)controle;
                    chk.CheckStateChanged += new System.EventHandler(this.checkboxis_CheckedChanged);
                    chk.BackColor = Color.White;
                }
            }
        }

        private Color PegaCor(Color c)
        {
            switch (c.Name)
            {
                case "ff000000":
                    return Color.Black;
                case "ffff0000":
                    return Color.Red;
                case "ff0000ff":
                    return Color.Blue;
                case "ff008000":
                    return Color.Green;
                default:
                    return Color.White;
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.bmp";
            ofd.Filter = "Arquivos Bitmap | *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bitmap bmp = new bitmap(ofd.FileName);
                int cont=0;
                foreach (Control controle in this.Controls)
                {
                    if (IsCheckBox(controle))
                    {
                        CheckBox chkbox = (CheckBox)controle;
                        chkbox.Checked = Pintado(bmp.Tela[cont]);
                        chkbox.BackColor = PegaCor(Color.FromArgb(bmp.Tela[cont].R, bmp.Tela[cont].G, bmp.Tela[cont].B));
                        cont++;
                    }
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            List<bitmap.pixel> tela = new List<bitmap.pixel>();

            bitmap.pixel p;

            foreach (Control controle in this.Controls)
            {
                if (IsCheckBox(controle))
                {
                    CheckBox chk = (CheckBox)controle;
                    switch (chk.BackColor.Name)
                    {
                        case "Red":
                            p = new bitmap.pixel("00", "00", "FF");
                            break;
                        case "Green":
                            p = new bitmap.pixel("00", "FF", "00");
                            break;
                        case "Blue":
                            p = new bitmap.pixel("FF", "00", "00");
                            break;
                        case "Black":
                            p = new bitmap.pixel("00", "00", "00");
                            break;
                        default:
                            p = new bitmap.pixel("FF", "FF", "FF");
                            break;
                    }
                    tela.Add(p);
                }
            }
            bitmap bmp = new bitmap(tela, 4, 4);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "*.bmp";
            sfd.Filter = "Arquivos Bitmap | *.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp.Salvar(sfd.FileName);
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                if (IsCheckBox(controle))
                {
                    CheckBox chkbox = (CheckBox)controle;
                    chkbox.Checked = false;
                    chkbox.BackColor = Color.White;
                }
            }
        }

        private void cboCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboCor.Text)
            {
                case "Branco":
                    cboCor.BackColor = Color.White;
                    cboCor.ForeColor = Color.Black;
                    break;
                case "Vermelho":
                    cboCor.BackColor = Color.Red;
                    cboCor.ForeColor = Color.White;
                    break;
                case "Verde":
                    cboCor.BackColor = Color.Green;
                    cboCor.ForeColor = Color.White;
                    break;
                case "Azul":
                    cboCor.BackColor = Color.Blue;
                    cboCor.ForeColor = Color.White;
                    break;
                case "Preto":
                    cboCor.BackColor = Color.Black;
                    cboCor.ForeColor = Color.White;
                    break;
            }
            btnSalvar.Focus();
        }

    }
}
