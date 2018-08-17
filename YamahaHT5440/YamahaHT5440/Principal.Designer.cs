namespace YamahaHT5440
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
            this.btnMenuUp = new System.Windows.Forms.Button();
            this.btnMenuDown = new System.Windows.Forms.Button();
            this.btnMenuMinus = new System.Windows.Forms.Button();
            this.btnMenuPlus = new System.Windows.Forms.Button();
            this.btnParamRight = new System.Windows.Forms.Button();
            this.btnParamLeft = new System.Windows.Forms.Button();
            this.btnParameterPlus = new System.Windows.Forms.Button();
            this.btnParamUp = new System.Windows.Forms.Button();
            this.btnTimeLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuUp
            // 
            this.btnMenuUp.Location = new System.Drawing.Point(161, 36);
            this.btnMenuUp.Name = "btnMenuUp";
            this.btnMenuUp.Size = new System.Drawing.Size(75, 23);
            this.btnMenuUp.TabIndex = 0;
            this.btnMenuUp.Text = "Menu Up";
            this.btnMenuUp.UseVisualStyleBackColor = true;
            this.btnMenuUp.Click += new System.EventHandler(this.btnMenuUp_Click);
            // 
            // btnMenuDown
            // 
            this.btnMenuDown.Location = new System.Drawing.Point(161, 96);
            this.btnMenuDown.Name = "btnMenuDown";
            this.btnMenuDown.Size = new System.Drawing.Size(75, 23);
            this.btnMenuDown.TabIndex = 1;
            this.btnMenuDown.Text = "Menu Down";
            this.btnMenuDown.UseVisualStyleBackColor = true;
            this.btnMenuDown.Click += new System.EventHandler(this.btnMenuDown_Click);
            // 
            // btnMenuMinus
            // 
            this.btnMenuMinus.Location = new System.Drawing.Point(80, 65);
            this.btnMenuMinus.Name = "btnMenuMinus";
            this.btnMenuMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMenuMinus.TabIndex = 2;
            this.btnMenuMinus.Text = "Menu -";
            this.btnMenuMinus.UseVisualStyleBackColor = true;
            this.btnMenuMinus.Click += new System.EventHandler(this.btnMenuMinus_Click);
            // 
            // btnMenuPlus
            // 
            this.btnMenuPlus.Location = new System.Drawing.Point(242, 65);
            this.btnMenuPlus.Name = "btnMenuPlus";
            this.btnMenuPlus.Size = new System.Drawing.Size(75, 23);
            this.btnMenuPlus.TabIndex = 3;
            this.btnMenuPlus.Text = "Menu +";
            this.btnMenuPlus.UseVisualStyleBackColor = true;
            this.btnMenuPlus.Click += new System.EventHandler(this.btnMenuPlus_Click);
            // 
            // btnParamRight
            // 
            this.btnParamRight.Location = new System.Drawing.Point(229, 181);
            this.btnParamRight.Name = "btnParamRight";
            this.btnParamRight.Size = new System.Drawing.Size(101, 23);
            this.btnParamRight.TabIndex = 7;
            this.btnParamRight.Text = "Parameter Right";
            this.btnParamRight.UseVisualStyleBackColor = true;
            this.btnParamRight.Click += new System.EventHandler(this.btnParamRight_Click);
            // 
            // btnParamLeft
            // 
            this.btnParamLeft.Location = new System.Drawing.Point(67, 181);
            this.btnParamLeft.Name = "btnParamLeft";
            this.btnParamLeft.Size = new System.Drawing.Size(101, 23);
            this.btnParamLeft.TabIndex = 6;
            this.btnParamLeft.Text = "Parameter Left";
            this.btnParamLeft.UseVisualStyleBackColor = true;
            this.btnParamLeft.Click += new System.EventHandler(this.btnParamLeft_Click);
            // 
            // btnParameterPlus
            // 
            this.btnParameterPlus.Location = new System.Drawing.Point(161, 212);
            this.btnParameterPlus.Name = "btnParameterPlus";
            this.btnParameterPlus.Size = new System.Drawing.Size(75, 23);
            this.btnParameterPlus.TabIndex = 5;
            this.btnParameterPlus.Text = "Parameter +";
            this.btnParameterPlus.UseVisualStyleBackColor = true;
            this.btnParameterPlus.Click += new System.EventHandler(this.btnParameterPlus_Click);
            // 
            // btnParamUp
            // 
            this.btnParamUp.Location = new System.Drawing.Point(151, 152);
            this.btnParamUp.Name = "btnParamUp";
            this.btnParamUp.Size = new System.Drawing.Size(95, 23);
            this.btnParamUp.TabIndex = 4;
            this.btnParamUp.Text = "Parameter Up";
            this.btnParamUp.UseVisualStyleBackColor = true;
            this.btnParamUp.Click += new System.EventHandler(this.btnParamUp_Click);
            // 
            // btnTimeLevel
            // 
            this.btnTimeLevel.Location = new System.Drawing.Point(161, 125);
            this.btnTimeLevel.Name = "btnTimeLevel";
            this.btnTimeLevel.Size = new System.Drawing.Size(75, 23);
            this.btnTimeLevel.TabIndex = 8;
            this.btnTimeLevel.Text = "Time / Level";
            this.btnTimeLevel.UseVisualStyleBackColor = true;
            this.btnTimeLevel.Click += new System.EventHandler(this.btnTimeLevel_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 386);
            this.Controls.Add(this.btnTimeLevel);
            this.Controls.Add(this.btnParamRight);
            this.Controls.Add(this.btnParamLeft);
            this.Controls.Add(this.btnParameterPlus);
            this.Controls.Add(this.btnParamUp);
            this.Controls.Add(this.btnMenuPlus);
            this.Controls.Add(this.btnMenuMinus);
            this.Controls.Add(this.btnMenuDown);
            this.Controls.Add(this.btnMenuUp);
            this.Name = "Principal";
            this.Text = "Yamaha HT-5440";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuUp;
        private System.Windows.Forms.Button btnMenuDown;
        private System.Windows.Forms.Button btnMenuMinus;
        private System.Windows.Forms.Button btnMenuPlus;
        private System.Windows.Forms.Button btnParamRight;
        private System.Windows.Forms.Button btnParamLeft;
        private System.Windows.Forms.Button btnParameterPlus;
        private System.Windows.Forms.Button btnParamUp;
        private System.Windows.Forms.Button btnTimeLevel;
    }
}

