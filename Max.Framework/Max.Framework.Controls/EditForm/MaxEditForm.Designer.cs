namespace Max.Framework.Controls.EditForm
{
    partial class MaxEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaxEditForm));
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.flpEditors = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpGrid = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new Max.Framework.Controls.Buttons.MaxButtonCancel();
            this.btnOK = new Max.Framework.Controls.Buttons.MaxButtonOK();
            this.pnlButtons.SuspendLayout();
            this.tlpGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.AutoSize = true;
            this.pnlButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(3, 130);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(282, 44);
            this.pnlButtons.TabIndex = 1;
            // 
            // flpEditors
            // 
            this.flpEditors.AutoSize = true;
            this.flpEditors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpEditors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEditors.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEditors.Location = new System.Drawing.Point(3, 3);
            this.flpEditors.Name = "flpEditors";
            this.flpEditors.Size = new System.Drawing.Size(282, 121);
            this.flpEditors.TabIndex = 0;
            // 
            // tlpGrid
            // 
            this.tlpGrid.AutoSize = true;
            this.tlpGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpGrid.ColumnCount = 1;
            this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.41133F));
            this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.58867F));
            this.tlpGrid.Controls.Add(this.flpEditors, 0, 0);
            this.tlpGrid.Controls.Add(this.pnlButtons, 1, 1);
            this.tlpGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGrid.Location = new System.Drawing.Point(0, 0);
            this.tlpGrid.Name = "tlpGrid";
            this.tlpGrid.RowCount = 2;
            this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.06704F));
            this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.93296F));
            this.tlpGrid.Size = new System.Drawing.Size(288, 177);
            this.tlpGrid.TabIndex = 2;
            this.tlpGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpGrid_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(184, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.Location = new System.Drawing.Point(118, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(60, 30);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // MaxEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(288, 177);
            this.ControlBox = false;
            this.Controls.Add(this.tlpGrid);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaxEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MaxEditForm";
            this.TopMost = true;
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.tlpGrid.ResumeLayout(false);
            this.tlpGrid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.FlowLayoutPanel flpEditors;
        private System.Windows.Forms.TableLayoutPanel tlpGrid;
        private Buttons.MaxButtonCancel btnCancel;
        private Buttons.MaxButtonOK btnOK;




    }
}