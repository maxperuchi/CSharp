namespace SimuladorEscalonamento.Controles
{
    partial class ucProcessador
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlProcesso = new System.Windows.Forms.Panel();
            this.lblProc = new System.Windows.Forms.Label();
            this.lblQuantum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlProcesso
            // 
            this.pnlProcesso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProcesso.Location = new System.Drawing.Point(22, 22);
            this.pnlProcesso.Name = "pnlProcesso";
            this.pnlProcesso.Size = new System.Drawing.Size(56, 56);
            this.pnlProcesso.TabIndex = 0;
            // 
            // lblProc
            // 
            this.lblProc.Location = new System.Drawing.Point(0, 0);
            this.lblProc.Name = "lblProc";
            this.lblProc.Size = new System.Drawing.Size(100, 19);
            this.lblProc.TabIndex = 1;
            this.lblProc.Text = "Processador";
            this.lblProc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantum
            // 
            this.lblQuantum.Location = new System.Drawing.Point(0, 81);
            this.lblQuantum.Name = "lblQuantum";
            this.lblQuantum.Size = new System.Drawing.Size(100, 19);
            this.lblQuantum.TabIndex = 2;
            this.lblQuantum.Text = "Quantum: 0";
            this.lblQuantum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucProcessador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.lblQuantum);
            this.Controls.Add(this.lblProc);
            this.Controls.Add(this.pnlProcesso);
            this.MaximumSize = new System.Drawing.Size(100, 100);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "ucProcessador";
            this.Size = new System.Drawing.Size(100, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProcesso;
        private System.Windows.Forms.Label lblProc;
        private System.Windows.Forms.Label lblQuantum;
    }
}
