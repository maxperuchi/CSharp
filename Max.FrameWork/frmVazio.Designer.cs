using System;
using System.Windows.Forms;
namespace Max.FrameWork
{
    partial class frmVazio
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

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmVazio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Max.FrameWork.Properties.Resources.frmBkg;
            this.ClientSize = new System.Drawing.Size(840, 377);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVazio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVazio";
            this.ResumeLayout(false);

        }

        #endregion

    }
}