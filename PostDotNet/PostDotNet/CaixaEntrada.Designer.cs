namespace PostDotNet
{
    partial class CaixaEntrada
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
            this.flpCentro = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.flpCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpCentro
            // 
            this.flpCentro.Controls.Add(this.lblMensagem);
            this.flpCentro.Controls.Add(this.txtEntrada);
            this.flpCentro.Controls.Add(this.btnOK);
            this.flpCentro.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCentro.Location = new System.Drawing.Point(0, 2);
            this.flpCentro.Margin = new System.Windows.Forms.Padding(0);
            this.flpCentro.Name = "flpCentro";
            this.flpCentro.Size = new System.Drawing.Size(391, 125);
            this.flpCentro.TabIndex = 0;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMensagem.Location = new System.Drawing.Point(3, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(388, 13);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Lorem Ipsum";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(3, 23);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(388, 20);
            this.txtEntrada.TabIndex = 1;
            this.txtEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntrada_KeyPress);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.Location = new System.Drawing.Point(159, 56);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CaixaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 127);
            this.ControlBox = false;
            this.Controls.Add(this.flpCentro);
            this.Name = "CaixaEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaixaEntrada";
            this.flpCentro.ResumeLayout(false);
            this.flpCentro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCentro;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Button btnOK;
    }
}