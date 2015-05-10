namespace SimuladorEscalonamento.Controles
{
    partial class ucFIlaEspera
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
            this.lblFilaEspera = new System.Windows.Forms.Label();
            this.flpFila = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblFilaEspera
            // 
            this.lblFilaEspera.AutoSize = true;
            this.lblFilaEspera.Location = new System.Drawing.Point(3, 3);
            this.lblFilaEspera.Name = "lblFilaEspera";
            this.lblFilaEspera.Size = new System.Drawing.Size(141, 13);
            this.lblFilaEspera.TabIndex = 5;
            this.lblFilaEspera.Text = "Fila de processos em espera";
            // 
            // flpFila
            // 
            this.flpFila.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpFila.AutoScroll = true;
            this.flpFila.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFila.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpFila.Location = new System.Drawing.Point(3, 19);
            this.flpFila.MaximumSize = new System.Drawing.Size(564, 79);
            this.flpFila.MinimumSize = new System.Drawing.Size(564, 79);
            this.flpFila.Name = "flpFila";
            this.flpFila.Size = new System.Drawing.Size(564, 79);
            this.flpFila.TabIndex = 4;
            // 
            // ucFIlaEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.lblFilaEspera);
            this.Controls.Add(this.flpFila);
            this.MaximumSize = new System.Drawing.Size(570, 100);
            this.MinimumSize = new System.Drawing.Size(570, 100);
            this.Name = "ucFIlaEspera";
            this.Size = new System.Drawing.Size(570, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilaEspera;
        private System.Windows.Forms.FlowLayoutPanel flpFila;
    }
}
