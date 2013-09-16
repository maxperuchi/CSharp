namespace Max.FrameWork
{
    partial class frmGerenciadorConexao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciadorConexao));
            this.lblTitulo1 = new Max.FrameWork.Controles.lblTitulo();
            this.lblEndereco = new Max.FrameWork.Controles.lblPadrao();
            this.lblUsuario = new Max.FrameWork.Controles.lblPadrao();
            this.lblSenha = new Max.FrameWork.Controles.lblPadrao();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.botaoFechar1 = new Max.FrameWork.res.botaoFechar();
            this.botaoOK1 = new Max.FrameWork.Controles.botaoOK();
            this.botaoNovo1 = new Max.FrameWork.Controles.botaoNovo();
            this.lblBanco = new Max.FrameWork.Controles.lblPadrao();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(241, 30);
            this.lblTitulo1.TabIndex = 1;
            this.lblTitulo1.Text = "Gerenciador de Conexão";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(18, 74);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(77, 21);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(18, 114);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 21);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(18, 150);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 21);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(102, 74);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(256, 20);
            this.txtEndereco.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(102, 114);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(256, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(102, 150);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(256, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // botaoFechar1
            // 
            this.botaoFechar1.BackColor = System.Drawing.Color.Transparent;
            this.botaoFechar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoFechar1.BackgroundImage")));
            this.botaoFechar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoFechar1.Location = new System.Drawing.Point(346, 13);
            this.botaoFechar1.Name = "botaoFechar1";
            this.botaoFechar1.Size = new System.Drawing.Size(33, 32);
            this.botaoFechar1.TabIndex = 5;
            // 
            // botaoOK1
            // 
            this.botaoOK1.AutoSize = true;
            this.botaoOK1.BackColor = System.Drawing.Color.Transparent;
            this.botaoOK1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoOK1.BackgroundImage")));
            this.botaoOK1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoOK1.Location = new System.Drawing.Point(345, 223);
            this.botaoOK1.Name = "botaoOK1";
            this.botaoOK1.Size = new System.Drawing.Size(34, 31);
            this.botaoOK1.TabIndex = 6;
            this.botaoOK1.Click += new System.EventHandler(this.botaoOK1_Click);
            // 
            // botaoNovo1
            // 
            this.botaoNovo1.BackColor = System.Drawing.Color.Transparent;
            this.botaoNovo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoNovo1.BackgroundImage")));
            this.botaoNovo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoNovo1.Location = new System.Drawing.Point(12, 222);
            this.botaoNovo1.Name = "botaoNovo1";
            this.botaoNovo1.Size = new System.Drawing.Size(26, 32);
            this.botaoNovo1.TabIndex = 7;
            this.botaoNovo1.Click += new System.EventHandler(this.botaoNovo1_Click);
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.BackColor = System.Drawing.Color.Transparent;
            this.lblBanco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.Location = new System.Drawing.Point(18, 184);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(55, 21);
            this.lblBanco.TabIndex = 1;
            this.lblBanco.Text = "Banco:";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(102, 184);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(256, 20);
            this.txtBanco.TabIndex = 8;
            // 
            // frmGerenciadorConexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(391, 266);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.botaoNovo1);
            this.Controls.Add(this.botaoOK1);
            this.Controls.Add(this.botaoFechar1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblTitulo1);
            this.Name = "frmGerenciadorConexao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.lblTitulo lblTitulo1;
        private Controles.lblPadrao lblEndereco;
        private Controles.lblPadrao lblUsuario;
        private Controles.lblPadrao lblSenha;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private res.botaoFechar botaoFechar1;
        private Controles.botaoOK botaoOK1;
        private Controles.botaoNovo botaoNovo1;
        private Controles.lblPadrao lblBanco;
        private System.Windows.Forms.TextBox txtBanco;
    }
}
