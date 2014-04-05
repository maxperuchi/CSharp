namespace AFD
{
    partial class Principal
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
            this.Texto = new System.Windows.Forms.RichTextBox();
            this.btnCarregarTexto = new System.Windows.Forms.Button();
            this.btnCarregarAutomato = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Texto
            // 
            this.Texto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Texto.Location = new System.Drawing.Point(12, 12);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(260, 238);
            this.Texto.TabIndex = 0;
            this.Texto.Text = "";
            // 
            // btnCarregarTexto
            // 
            this.btnCarregarTexto.Location = new System.Drawing.Point(12, 256);
            this.btnCarregarTexto.Name = "btnCarregarTexto";
            this.btnCarregarTexto.Size = new System.Drawing.Size(75, 44);
            this.btnCarregarTexto.TabIndex = 1;
            this.btnCarregarTexto.Text = "Carregar Texto...";
            this.btnCarregarTexto.UseVisualStyleBackColor = true;
            this.btnCarregarTexto.Click += new System.EventHandler(this.btnCarregarTexto_Click);
            // 
            // btnCarregarAutomato
            // 
            this.btnCarregarAutomato.Enabled = false;
            this.btnCarregarAutomato.Location = new System.Drawing.Point(197, 256);
            this.btnCarregarAutomato.Name = "btnCarregarAutomato";
            this.btnCarregarAutomato.Size = new System.Drawing.Size(75, 44);
            this.btnCarregarAutomato.TabIndex = 2;
            this.btnCarregarAutomato.Text = "Carregar Automato...";
            this.btnCarregarAutomato.UseVisualStyleBackColor = true;
            this.btnCarregarAutomato.Click += new System.EventHandler(this.btnCarregarAutomato_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Enabled = false;
            this.btnExecutar.Location = new System.Drawing.Point(105, 256);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 44);
            this.btnExecutar.TabIndex = 3;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 306);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.btnCarregarAutomato);
            this.Controls.Add(this.btnCarregarTexto);
            this.Controls.Add(this.Texto);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Texto;
        private System.Windows.Forms.Button btnCarregarTexto;
        private System.Windows.Forms.Button btnCarregarAutomato;
        private System.Windows.Forms.Button btnExecutar;
    }
}