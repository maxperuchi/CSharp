using System.Drawing;
namespace PixelDraw
{
    partial class frmMain
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
            this.cmdGerar = new System.Windows.Forms.Button();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.lblNomeFuncao = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.lblLimY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdGerar
            // 
            this.cmdGerar.Location = new System.Drawing.Point(1, 172);
            this.cmdGerar.Name = "cmdGerar";
            this.cmdGerar.Size = new System.Drawing.Size(185, 32);
            this.cmdGerar.TabIndex = 3;
            this.cmdGerar.Text = "Gerar Desenho ASM";
            this.cmdGerar.UseVisualStyleBackColor = true;
            this.cmdGerar.Click += new System.EventHandler(this.cmdGerar_Click);
            // 
            // txtFuncao
            // 
            this.txtFuncao.Location = new System.Drawing.Point(2, 18);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(185, 20);
            this.txtFuncao.TabIndex = 1;
            // 
            // lblNomeFuncao
            // 
            this.lblNomeFuncao.AutoSize = true;
            this.lblNomeFuncao.Location = new System.Drawing.Point(-1, 2);
            this.lblNomeFuncao.Name = "lblNomeFuncao";
            this.lblNomeFuncao.Size = new System.Drawing.Size(89, 13);
            this.lblNomeFuncao.TabIndex = 496;
            this.lblNomeFuncao.Text = "Nome da função:";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(-1, 49);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(26, 13);
            this.lblCor.TabIndex = 498;
            this.lblCor.Text = "Cor:";
            // 
            // lblPosicao
            // 
            this.lblPosicao.AutoSize = true;
            this.lblPosicao.Location = new System.Drawing.Point(0, 99);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(48, 13);
            this.lblPosicao.TabIndex = 499;
            this.lblPosicao.Text = "Posição:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(1, 148);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(23, 13);
            this.lblX.TabIndex = 500;
            this.lblX.Text = "X : ";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(1, 122);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(23, 13);
            this.lblY.TabIndex = 501;
            this.lblY.Text = "Y : ";
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(23, 119);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(50, 20);
            this.txtPosY.TabIndex = 502;
            this.txtPosY.Text = "0";
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(23, 145);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(50, 20);
            this.txtPosX.TabIndex = 503;
            this.txtPosX.Text = "0";
            // 
            // lblLimY
            // 
            this.lblLimY.AutoSize = true;
            this.lblLimY.Location = new System.Drawing.Point(79, 122);
            this.lblLimY.Name = "lblLimY";
            this.lblLimY.Size = new System.Drawing.Size(40, 13);
            this.lblLimY.TabIndex = 504;
            this.lblLimY.Text = "(0-184)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 505;
            this.label1.Text = "(0-304)";
            // 
            // cboCor
            // 
            this.cboCor.BackColor = System.Drawing.SystemColors.Window;
            this.cboCor.FormattingEnabled = true;
            this.cboCor.Location = new System.Drawing.Point(2, 65);
            this.cboCor.Name = "cboCor";
            this.cboCor.Size = new System.Drawing.Size(185, 21);
            this.cboCor.TabIndex = 506;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 211);
            this.Controls.Add(this.cboCor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLimY);
            this.Controls.Add(this.txtPosX);
            this.Controls.Add(this.txtPosY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblPosicao);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblNomeFuncao);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(this.cmdGerar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PixelDraw";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdGerar;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.Label lblNomeFuncao;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.Label lblLimY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCor;

    }
}

