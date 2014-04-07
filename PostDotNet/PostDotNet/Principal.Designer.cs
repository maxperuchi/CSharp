namespace PostDotNet
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
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.pnlFluxograma = new System.Windows.Forms.Panel();
            this.btnCriarAtribuir = new System.Windows.Forms.Button();
            this.flpFerramentas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCriarAceita = new System.Windows.Forms.Button();
            this.btnCriarRejeita = new System.Windows.Forms.Button();
            this.btnCriarLer = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblAlfabeto = new System.Windows.Forms.Label();
            this.btnAlfabeto = new System.Windows.Forms.Button();
            this.btnVariavelX = new System.Windows.Forms.Button();
            this.txtVariavelX = new System.Windows.Forms.TextBox();
            this.btnRelacionamento = new System.Windows.Forms.Button();
            this.flpFerramentas.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.Color.Aqua;
            this.btnCriarPartida.Location = new System.Drawing.Point(6, 6);
            this.btnCriarPartida.Margin = new System.Windows.Forms.Padding(6);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(103, 23);
            this.btnCriarPartida.TabIndex = 1;
            this.btnCriarPartida.Text = "Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // pnlFluxograma
            // 
            this.pnlFluxograma.BackColor = System.Drawing.Color.White;
            this.pnlFluxograma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFluxograma.Location = new System.Drawing.Point(116, 64);
            this.pnlFluxograma.Name = "pnlFluxograma";
            this.pnlFluxograma.Size = new System.Drawing.Size(537, 363);
            this.pnlFluxograma.TabIndex = 2;
            this.pnlFluxograma.Click += new System.EventHandler(this.pnlFluxograma_Click);
            // 
            // btnCriarAtribuir
            // 
            this.btnCriarAtribuir.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCriarAtribuir.Location = new System.Drawing.Point(6, 111);
            this.btnCriarAtribuir.Margin = new System.Windows.Forms.Padding(6);
            this.btnCriarAtribuir.Name = "btnCriarAtribuir";
            this.btnCriarAtribuir.Size = new System.Drawing.Size(103, 23);
            this.btnCriarAtribuir.TabIndex = 3;
            this.btnCriarAtribuir.Text = "Atribuir";
            this.btnCriarAtribuir.UseVisualStyleBackColor = false;
            this.btnCriarAtribuir.Click += new System.EventHandler(this.btnCriarAtribuir_Click);
            // 
            // flpFerramentas
            // 
            this.flpFerramentas.Controls.Add(this.btnCriarPartida);
            this.flpFerramentas.Controls.Add(this.btnCriarAceita);
            this.flpFerramentas.Controls.Add(this.btnCriarRejeita);
            this.flpFerramentas.Controls.Add(this.btnCriarAtribuir);
            this.flpFerramentas.Controls.Add(this.btnCriarLer);
            this.flpFerramentas.Controls.Add(this.btnRelacionamento);
            this.flpFerramentas.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpFerramentas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpFerramentas.Location = new System.Drawing.Point(0, 64);
            this.flpFerramentas.Name = "flpFerramentas";
            this.flpFerramentas.Size = new System.Drawing.Size(116, 363);
            this.flpFerramentas.TabIndex = 3;
            // 
            // btnCriarAceita
            // 
            this.btnCriarAceita.BackColor = System.Drawing.Color.Aqua;
            this.btnCriarAceita.Location = new System.Drawing.Point(6, 41);
            this.btnCriarAceita.Margin = new System.Windows.Forms.Padding(6);
            this.btnCriarAceita.Name = "btnCriarAceita";
            this.btnCriarAceita.Size = new System.Drawing.Size(103, 23);
            this.btnCriarAceita.TabIndex = 4;
            this.btnCriarAceita.Text = "Aceita";
            this.btnCriarAceita.UseVisualStyleBackColor = false;
            this.btnCriarAceita.Click += new System.EventHandler(this.btnCriarAceita_Click);
            // 
            // btnCriarRejeita
            // 
            this.btnCriarRejeita.BackColor = System.Drawing.Color.Aqua;
            this.btnCriarRejeita.Location = new System.Drawing.Point(6, 76);
            this.btnCriarRejeita.Margin = new System.Windows.Forms.Padding(6);
            this.btnCriarRejeita.Name = "btnCriarRejeita";
            this.btnCriarRejeita.Size = new System.Drawing.Size(103, 23);
            this.btnCriarRejeita.TabIndex = 5;
            this.btnCriarRejeita.Text = "Rejeita";
            this.btnCriarRejeita.UseVisualStyleBackColor = false;
            this.btnCriarRejeita.Click += new System.EventHandler(this.btnCriarRejeita_Click);
            // 
            // btnCriarLer
            // 
            this.btnCriarLer.BackColor = System.Drawing.Color.Red;
            this.btnCriarLer.Location = new System.Drawing.Point(6, 146);
            this.btnCriarLer.Margin = new System.Windows.Forms.Padding(6);
            this.btnCriarLer.Name = "btnCriarLer";
            this.btnCriarLer.Size = new System.Drawing.Size(103, 23);
            this.btnCriarLer.TabIndex = 6;
            this.btnCriarLer.Text = "Ler";
            this.btnCriarLer.UseVisualStyleBackColor = false;
            this.btnCriarLer.Click += new System.EventHandler(this.btnCriarLer_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.lblAlfabeto);
            this.pnlMenu.Controls.Add(this.btnAlfabeto);
            this.pnlMenu.Controls.Add(this.btnVariavelX);
            this.pnlMenu.Controls.Add(this.txtVariavelX);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(653, 64);
            this.pnlMenu.TabIndex = 4;
            // 
            // lblAlfabeto
            // 
            this.lblAlfabeto.AutoSize = true;
            this.lblAlfabeto.Location = new System.Drawing.Point(115, 42);
            this.lblAlfabeto.Name = "lblAlfabeto";
            this.lblAlfabeto.Size = new System.Drawing.Size(10, 13);
            this.lblAlfabeto.TabIndex = 4;
            this.lblAlfabeto.Text = "-";
            // 
            // btnAlfabeto
            // 
            this.btnAlfabeto.Location = new System.Drawing.Point(12, 37);
            this.btnAlfabeto.Name = "btnAlfabeto";
            this.btnAlfabeto.Size = new System.Drawing.Size(97, 23);
            this.btnAlfabeto.TabIndex = 3;
            this.btnAlfabeto.Text = "Alfabeto:";
            this.btnAlfabeto.UseVisualStyleBackColor = true;
            this.btnAlfabeto.Click += new System.EventHandler(this.btnAlfabeto_Click);
            // 
            // btnVariavelX
            // 
            this.btnVariavelX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVariavelX.Location = new System.Drawing.Point(12, 8);
            this.btnVariavelX.Name = "btnVariavelX";
            this.btnVariavelX.Size = new System.Drawing.Size(97, 23);
            this.btnVariavelX.TabIndex = 2;
            this.btnVariavelX.Text = "Variável X:";
            this.btnVariavelX.UseVisualStyleBackColor = true;
            this.btnVariavelX.Click += new System.EventHandler(this.btnVariavelX_Click);
            // 
            // txtVariavelX
            // 
            this.txtVariavelX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVariavelX.Location = new System.Drawing.Point(116, 10);
            this.txtVariavelX.Name = "txtVariavelX";
            this.txtVariavelX.ReadOnly = true;
            this.txtVariavelX.Size = new System.Drawing.Size(534, 20);
            this.txtVariavelX.TabIndex = 1;
            // 
            // btnRelacionamento
            // 
            this.btnRelacionamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRelacionamento.Location = new System.Drawing.Point(6, 178);
            this.btnRelacionamento.Name = "btnRelacionamento";
            this.btnRelacionamento.Size = new System.Drawing.Size(102, 39);
            this.btnRelacionamento.TabIndex = 5;
            this.btnRelacionamento.Text = "Relacionamento";
            this.btnRelacionamento.UseVisualStyleBackColor = true;
            this.btnRelacionamento.Click += new System.EventHandler(this.btnRelacionamento_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 427);
            this.Controls.Add(this.pnlFluxograma);
            this.Controls.Add(this.flpFerramentas);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POST.net";
            this.flpFerramentas.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Panel pnlFluxograma;
        private System.Windows.Forms.Button btnCriarAtribuir;
        private System.Windows.Forms.FlowLayoutPanel flpFerramentas;
        private System.Windows.Forms.Button btnCriarAceita;
        private System.Windows.Forms.Button btnCriarRejeita;
        private System.Windows.Forms.Button btnCriarLer;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.TextBox txtVariavelX;
        private System.Windows.Forms.Button btnVariavelX;
        private System.Windows.Forms.Label lblAlfabeto;
        private System.Windows.Forms.Button btnAlfabeto;
        private System.Windows.Forms.Button btnRelacionamento;
    }
}

