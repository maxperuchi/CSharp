namespace Max.FrameWork
{
    partial class frmMsgBox
    {
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.picOK = new System.Windows.Forms.PictureBox();
            this.picFechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(12, 9);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(462, 146);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "lblMensagem";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picOK
            // 
            this.picOK.BackColor = System.Drawing.Color.Transparent;
            this.picOK.Image = global::Max.FrameWork.Properties.Resources.checkmark;
            this.picOK.Location = new System.Drawing.Point(438, 158);
            this.picOK.Name = "picOK";
            this.picOK.Size = new System.Drawing.Size(36, 35);
            this.picOK.TabIndex = 1;
            this.picOK.TabStop = false;
            this.picOK.Click += new System.EventHandler(this.picOK_Click);
            // 
            // picFechar
            // 
            this.picFechar.BackColor = System.Drawing.Color.Transparent;
            this.picFechar.BackgroundImage = global::Max.FrameWork.Properties.Resources.close;
            this.picFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picFechar.Location = new System.Drawing.Point(447, 9);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(37, 35);
            this.picFechar.TabIndex = 2;
            this.picFechar.TabStop = false;
            this.picFechar.Click += new System.EventHandler(this.picFechar_Click);
            // 
            // frmMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Max.FrameWork.Properties.Resources.frmBkg;
            this.ClientSize = new System.Drawing.Size(486, 205);
            this.ControlBox = false;
            this.Controls.Add(this.picFechar);
            this.Controls.Add(this.picOK);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMsgBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMsgBox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMsgBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.PictureBox picOK;
        private System.Windows.Forms.PictureBox picFechar;
    }
}