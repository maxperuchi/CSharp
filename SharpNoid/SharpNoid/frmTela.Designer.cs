namespace SharpNoid
{
    partial class frmTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTela));
            this.tmrBola = new System.Windows.Forms.Timer(this.components);
            this.bola = new SharpNoid.GameObjects.ball();
            this.teto = new SharpNoid.GameObjects.wall();
            this.paredeEsquerda = new SharpNoid.GameObjects.wall();
            this.paredeDireita = new SharpNoid.GameObjects.wall();
            this.paddle = new SharpNoid.GameObjects.paddle();
            this.SuspendLayout();
            // 
            // tmrBola
            // 
            this.tmrBola.Enabled = true;
            this.tmrBola.Interval = 50;
            this.tmrBola.Tick += new System.EventHandler(this.tmrBola_Tick);
            // 
            // bola
            // 
            this.bola.BackColor = System.Drawing.Color.Transparent;
            this.bola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bola.BackgroundImage")));
            this.bola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bola.Location = new System.Drawing.Point(234, 20);
            this.bola.Name = "bola";
            this.bola.Size = new System.Drawing.Size(13, 13);
            this.bola.TabIndex = 4;
            this.bola.Velocidade = 0;
            // 
            // teto
            // 
            this.teto.BackColor = System.Drawing.Color.Transparent;
            this.teto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teto.BackgroundImage")));
            this.teto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.teto.Location = new System.Drawing.Point(2, 0);
            this.teto.Name = "teto";
            this.teto.Size = new System.Drawing.Size(510, 13);
            this.teto.TabIndex = 3;
            // 
            // paredeEsquerda
            // 
            this.paredeEsquerda.BackColor = System.Drawing.Color.Transparent;
            this.paredeEsquerda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paredeEsquerda.BackgroundImage")));
            this.paredeEsquerda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paredeEsquerda.Location = new System.Drawing.Point(2, 1);
            this.paredeEsquerda.Name = "paredeEsquerda";
            this.paredeEsquerda.Size = new System.Drawing.Size(15, 450);
            this.paredeEsquerda.TabIndex = 2;
            // 
            // paredeDireita
            // 
            this.paredeDireita.BackColor = System.Drawing.Color.Transparent;
            this.paredeDireita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paredeDireita.BackgroundImage")));
            this.paredeDireita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paredeDireita.Location = new System.Drawing.Point(497, 0);
            this.paredeDireita.Name = "paredeDireita";
            this.paredeDireita.Size = new System.Drawing.Size(15, 450);
            this.paredeDireita.TabIndex = 1;
            // 
            // paddle
            // 
            this.paddle.BackColor = System.Drawing.Color.Transparent;
            this.paddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paddle.BackgroundImage")));
            this.paddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paddle.Location = new System.Drawing.Point(207, 418);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(120, 20);
            this.paddle.TabIndex = 0;
            this.paddle.Tipo = SharpNoid.GameObjects.paddle.TipoPaddle.Normal;
            // 
            // frmTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::SharpNoid.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.bola);
            this.Controls.Add(this.teto);
            this.Controls.Add(this.paredeEsquerda);
            this.Controls.Add(this.paredeDireita);
            this.Controls.Add(this.paddle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmTela";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharpNoid";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTela_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private GameObjects.paddle paddle;
        private GameObjects.wall paredeDireita;
        private GameObjects.wall paredeEsquerda;
        private GameObjects.wall teto;
        private GameObjects.ball bola;
        private System.Windows.Forms.Timer tmrBola;



    }
}

