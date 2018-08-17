namespace ClassAdapterTest
{
    partial class Main
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLED = new System.Windows.Forms.Button();
            this.btnFluorescente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(36, 135);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(322, 37);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status: Luz apagada.";
            // 
            // btnLED
            // 
            this.btnLED.Location = new System.Drawing.Point(43, 25);
            this.btnLED.Name = "btnLED";
            this.btnLED.Size = new System.Drawing.Size(103, 90);
            this.btnLED.TabIndex = 1;
            this.btnLED.Text = "Iluminar com LED";
            this.btnLED.UseVisualStyleBackColor = true;
            this.btnLED.Click += new System.EventHandler(this.btnLED_Click);
            // 
            // btnFluorescente
            // 
            this.btnFluorescente.Location = new System.Drawing.Point(152, 25);
            this.btnFluorescente.Name = "btnFluorescente";
            this.btnFluorescente.Size = new System.Drawing.Size(103, 90);
            this.btnFluorescente.TabIndex = 2;
            this.btnFluorescente.Text = "Iluminar com Fluorescente";
            this.btnFluorescente.UseVisualStyleBackColor = true;
            this.btnFluorescente.Click += new System.EventHandler(this.btnFluorescente_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 211);
            this.Controls.Add(this.btnFluorescente);
            this.Controls.Add(this.btnLED);
            this.Controls.Add(this.lblStatus);
            this.Name = "Main";
            this.Text = "Class Adapter Lampadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnLED;
        private System.Windows.Forms.Button btnFluorescente;
    }
}

