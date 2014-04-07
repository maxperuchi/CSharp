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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Texto
            // 
            this.Texto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Texto.Location = new System.Drawing.Point(12, 12);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(260, 187);
            this.Texto.TabIndex = 0;
            this.Texto.Text = "";
            // 
            // btnCarregarTexto
            // 
            this.btnCarregarTexto.Location = new System.Drawing.Point(10, 282);
            this.btnCarregarTexto.Name = "btnCarregarTexto";
            this.btnCarregarTexto.Size = new System.Drawing.Size(75, 44);
            this.btnCarregarTexto.TabIndex = 1;
            this.btnCarregarTexto.Text = "Carregar Texto...";
            this.btnCarregarTexto.UseVisualStyleBackColor = true;
            this.btnCarregarTexto.Click += new System.EventHandler(this.btnCarregarTexto_Click);
            // 
            // btnCarregarAutomato
            // 
            this.btnCarregarAutomato.Location = new System.Drawing.Point(195, 282);
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
            this.btnExecutar.Location = new System.Drawing.Point(103, 282);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 44);
            this.btnExecutar.TabIndex = 3;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ocorrências:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Felipe N. Nascimento – matrícula 0094078";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maxwel Peruchi de Mello - matrícula 0049548";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 336);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.btnCarregarAutomato);
            this.Controls.Add(this.btnCarregarTexto);
            this.Controls.Add(this.Texto);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Texto;
        private System.Windows.Forms.Button btnCarregarTexto;
        private System.Windows.Forms.Button btnCarregarAutomato;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}