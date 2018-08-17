namespace CommandPattern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Ventilador = new CommandPattern.ucVentiladorTeto();
            this.btnOn1 = new System.Windows.Forms.Button();
            this.btnOff1 = new System.Windows.Forms.Button();
            this.btnOn2 = new System.Windows.Forms.Button();
            this.btnOff2 = new System.Windows.Forms.Button();
            this.cboSw1On = new System.Windows.Forms.ComboBox();
            this.cboSw1Off = new System.Windows.Forms.ComboBox();
            this.cboSw2On = new System.Windows.Forms.ComboBox();
            this.cboSw2Off = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Ventilador
            // 
            this.Ventilador.BackColor = System.Drawing.Color.White;
            this.Ventilador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ventilador.BackgroundImage")));
            this.Ventilador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ventilador.Location = new System.Drawing.Point(16, 48);
            this.Ventilador.LuzLigada = false;
            this.Ventilador.MaximumSize = new System.Drawing.Size(245, 205);
            this.Ventilador.MinimumSize = new System.Drawing.Size(245, 205);
            this.Ventilador.Name = "Ventilador";
            this.Ventilador.Size = new System.Drawing.Size(245, 205);
            this.Ventilador.TabIndex = 0;
            this.Ventilador.VentiladorLigado = false;
            // 
            // btnOn1
            // 
            this.btnOn1.Location = new System.Drawing.Point(267, 32);
            this.btnOn1.Name = "btnOn1";
            this.btnOn1.Size = new System.Drawing.Size(50, 50);
            this.btnOn1.TabIndex = 1;
            this.btnOn1.Text = "ON";
            this.btnOn1.UseVisualStyleBackColor = true;
            this.btnOn1.Click += new System.EventHandler(this.btnOn1_Click);
            // 
            // btnOff1
            // 
            this.btnOff1.Location = new System.Drawing.Point(267, 88);
            this.btnOff1.Name = "btnOff1";
            this.btnOff1.Size = new System.Drawing.Size(50, 50);
            this.btnOff1.TabIndex = 2;
            this.btnOff1.Text = "OFF";
            this.btnOff1.UseVisualStyleBackColor = true;
            this.btnOff1.Click += new System.EventHandler(this.btnOff1_Click);
            // 
            // btnOn2
            // 
            this.btnOn2.Location = new System.Drawing.Point(267, 191);
            this.btnOn2.Name = "btnOn2";
            this.btnOn2.Size = new System.Drawing.Size(50, 50);
            this.btnOn2.TabIndex = 3;
            this.btnOn2.Text = "ON";
            this.btnOn2.UseVisualStyleBackColor = true;
            this.btnOn2.Click += new System.EventHandler(this.btnOn2_Click);
            // 
            // btnOff2
            // 
            this.btnOff2.Location = new System.Drawing.Point(267, 247);
            this.btnOff2.Name = "btnOff2";
            this.btnOff2.Size = new System.Drawing.Size(50, 50);
            this.btnOff2.TabIndex = 4;
            this.btnOff2.Text = "OFF";
            this.btnOff2.UseVisualStyleBackColor = true;
            this.btnOff2.Click += new System.EventHandler(this.btnOff2_Click);
            // 
            // cboSw1On
            // 
            this.cboSw1On.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSw1On.FormattingEnabled = true;
            this.cboSw1On.Location = new System.Drawing.Point(323, 48);
            this.cboSw1On.Name = "cboSw1On";
            this.cboSw1On.Size = new System.Drawing.Size(225, 21);
            this.cboSw1On.TabIndex = 7;
            // 
            // cboSw1Off
            // 
            this.cboSw1Off.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSw1Off.FormattingEnabled = true;
            this.cboSw1Off.Location = new System.Drawing.Point(323, 104);
            this.cboSw1Off.Name = "cboSw1Off";
            this.cboSw1Off.Size = new System.Drawing.Size(225, 21);
            this.cboSw1Off.TabIndex = 8;
            // 
            // cboSw2On
            // 
            this.cboSw2On.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSw2On.FormattingEnabled = true;
            this.cboSw2On.Location = new System.Drawing.Point(323, 207);
            this.cboSw2On.Name = "cboSw2On";
            this.cboSw2On.Size = new System.Drawing.Size(225, 21);
            this.cboSw2On.TabIndex = 9;
            // 
            // cboSw2Off
            // 
            this.cboSw2Off.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSw2Off.FormattingEnabled = true;
            this.cboSw2Off.Location = new System.Drawing.Point(323, 263);
            this.cboSw2Off.Name = "cboSw2Off";
            this.cboSw2Off.Size = new System.Drawing.Size(225, 21);
            this.cboSw2Off.TabIndex = 10;
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 319);
            this.Controls.Add(this.cboSw2Off);
            this.Controls.Add(this.cboSw2On);
            this.Controls.Add(this.cboSw1Off);
            this.Controls.Add(this.cboSw1On);
            this.Controls.Add(this.btnOff2);
            this.Controls.Add(this.btnOn2);
            this.Controls.Add(this.btnOff1);
            this.Controls.Add(this.btnOn1);
            this.Controls.Add(this.Ventilador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(587, 358);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(587, 358);
            this.Name = "Principal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Command Pattern Test";
            this.ResumeLayout(false);

        }

        #endregion

        private ucVentiladorTeto Ventilador;
        private System.Windows.Forms.Button btnOn1;
        private System.Windows.Forms.Button btnOff1;
        private System.Windows.Forms.Button btnOn2;
        private System.Windows.Forms.Button btnOff2;
        private System.Windows.Forms.ComboBox cboSw1On;
        private System.Windows.Forms.ComboBox cboSw1Off;
        private System.Windows.Forms.ComboBox cboSw2On;
        private System.Windows.Forms.ComboBox cboSw2Off;
    }
}

