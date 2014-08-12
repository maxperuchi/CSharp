namespace MaxFrameworkTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.maxGridView1 = new Max.Framework.Controls.GridView.MaxGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.maxGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // maxGridView1
            // 
            this.maxGridView1.BackgroundColor = System.Drawing.Color.White;
            this.maxGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maxGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxGridView1.GridColor = System.Drawing.Color.Black;
            this.maxGridView1.Location = new System.Drawing.Point(0, 0);
            this.maxGridView1.Name = "maxGridView1";
            this.maxGridView1.Size = new System.Drawing.Size(1049, 608);
            this.maxGridView1.TabIndex = 0;
            this.maxGridView1.UseEditForm = true;
            this.maxGridView1.RowUpdated += new System.EventHandler<Max.Framework.Controls.GridView.MaxGridViewRowEventArgs>(this.maxGridView1_RowUpdated);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 608);
            this.Controls.Add(this.maxGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.maxGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Max.Framework.Controls.GridView.MaxGridView maxGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;

    }
}

