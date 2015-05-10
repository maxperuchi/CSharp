namespace SimuladorEscalonamento.Controles
{
    partial class ucFila
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
            this.flpFila = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFila = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpFila
            // 
            this.flpFila.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpFila.AutoScroll = true;
            this.flpFila.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFila.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpFila.Location = new System.Drawing.Point(3, 18);
            this.flpFila.MaximumSize = new System.Drawing.Size(564, 79);
            this.flpFila.MinimumSize = new System.Drawing.Size(564, 79);
            this.flpFila.Name = "flpFila";
            this.flpFila.Size = new System.Drawing.Size(564, 79);
            this.flpFila.TabIndex = 2;
            // 
            // lblFila
            // 
            this.lblFila.AutoSize = true;
            this.lblFila.Location = new System.Drawing.Point(3, 2);
            this.lblFila.Name = "lblFila";
            this.lblFila.Size = new System.Drawing.Size(155, 13);
            this.lblFila.TabIndex = 3;
            this.lblFila.Text = "Fila de processos Round-Robin";
            // 
            // ucFila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.Controls.Add(this.lblFila);
            this.Controls.Add(this.flpFila);
            this.MaximumSize = new System.Drawing.Size(570, 100);
            this.MinimumSize = new System.Drawing.Size(570, 100);
            this.Name = "ucFila";
            this.Size = new System.Drawing.Size(570, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFila;
        private System.Windows.Forms.Label lblFila;


    }
}
