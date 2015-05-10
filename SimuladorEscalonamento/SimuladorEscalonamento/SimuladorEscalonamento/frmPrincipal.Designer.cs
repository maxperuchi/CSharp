namespace SimuladorEscalonamento
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblSobre = new System.Windows.Forms.Label();
            this.lblQuantum = new System.Windows.Forms.Label();
            this.lblTempoVida = new System.Windows.Forms.Label();
            this.lblProbabilidadeIO = new System.Windows.Forms.Label();
            this.txtProbabilidadeIO = new System.Windows.Forms.TextBox();
            this.txtTempoVida = new System.Windows.Forms.TextBox();
            this.txtQuantum = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtQtdMaxProc = new System.Windows.Forms.TextBox();
            this.lblQtdMaxProc = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtProbabilidadeEspera = new System.Windows.Forms.TextBox();
            this.lblProbabilidadeEspera = new System.Windows.Forms.Label();
            this.btnParar = new System.Windows.Forms.Button();
            this.pnlLegenda = new System.Windows.Forms.Panel();
            this.lblProcessoIO = new System.Windows.Forms.Label();
            this.lblProcesso = new System.Windows.Forms.Label();
            this.lblLegenda = new System.Windows.Forms.Label();
            this.ucProcessoIO = new SimuladorEscalonamento.Controles.ucProcesso();
            this.ucProcesso = new SimuladorEscalonamento.Controles.ucProcesso();
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblSegundos2 = new System.Windows.Forms.Label();
            this.lblProcessos = new System.Windows.Forms.Label();
            this.lblPorcento = new System.Windows.Forms.Label();
            this.lblPorcento2 = new System.Windows.Forms.Label();
            this.ucFIlaEspera = new SimuladorEscalonamento.Controles.ucFIlaEspera();
            this.ucFila = new SimuladorEscalonamento.Controles.ucFila();
            this.ucProcessador = new SimuladorEscalonamento.Controles.ucProcessador();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlLegenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSobre
            // 
            this.lblSobre.Location = new System.Drawing.Point(450, 396);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(297, 20);
            this.lblSobre.TabIndex = 0;
            this.lblSobre.Text = "Feito por: Maxwel Peruchi de Mello && Riciel Peruchi de Mello";
            // 
            // lblQuantum
            // 
            this.lblQuantum.AutoSize = true;
            this.lblQuantum.Location = new System.Drawing.Point(23, 25);
            this.lblQuantum.Name = "lblQuantum";
            this.lblQuantum.Size = new System.Drawing.Size(53, 13);
            this.lblQuantum.TabIndex = 1;
            this.lblQuantum.Text = "Quantum:";
            // 
            // lblTempoVida
            // 
            this.lblTempoVida.AutoSize = true;
            this.lblTempoVida.Location = new System.Drawing.Point(23, 51);
            this.lblTempoVida.Name = "lblTempoVida";
            this.lblTempoVida.Size = new System.Drawing.Size(180, 13);
            this.lblTempoVida.TabIndex = 2;
            this.lblTempoVida.Text = "Tempo de vida máximo do processo:";
            // 
            // lblProbabilidadeIO
            // 
            this.lblProbabilidadeIO.AutoSize = true;
            this.lblProbabilidadeIO.Location = new System.Drawing.Point(23, 103);
            this.lblProbabilidadeIO.Name = "lblProbabilidadeIO";
            this.lblProbabilidadeIO.Size = new System.Drawing.Size(217, 13);
            this.lblProbabilidadeIO.TabIndex = 3;
            this.lblProbabilidadeIO.Text = "Probabilidade de um processo ser IO-Bound:";
            // 
            // txtProbabilidadeIO
            // 
            this.txtProbabilidadeIO.Location = new System.Drawing.Point(361, 103);
            this.txtProbabilidadeIO.Name = "txtProbabilidadeIO";
            this.txtProbabilidadeIO.Size = new System.Drawing.Size(48, 20);
            this.txtProbabilidadeIO.TabIndex = 4;
            this.txtProbabilidadeIO.Text = "40";
            this.txtProbabilidadeIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // txtTempoVida
            // 
            this.txtTempoVida.Location = new System.Drawing.Point(361, 51);
            this.txtTempoVida.Name = "txtTempoVida";
            this.txtTempoVida.Size = new System.Drawing.Size(48, 20);
            this.txtTempoVida.TabIndex = 5;
            this.txtTempoVida.Text = "10";
            this.txtTempoVida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // txtQuantum
            // 
            this.txtQuantum.Location = new System.Drawing.Point(361, 25);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(48, 20);
            this.txtQuantum.TabIndex = 6;
            this.txtQuantum.Text = "2";
            this.txtQuantum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(163, 152);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(122, 23);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtQtdMaxProc
            // 
            this.txtQtdMaxProc.Location = new System.Drawing.Point(361, 77);
            this.txtQtdMaxProc.Name = "txtQtdMaxProc";
            this.txtQtdMaxProc.Size = new System.Drawing.Size(48, 20);
            this.txtQtdMaxProc.TabIndex = 12;
            this.txtQtdMaxProc.Text = "10";
            // 
            // lblQtdMaxProc
            // 
            this.lblQtdMaxProc.AutoSize = true;
            this.lblQtdMaxProc.Location = new System.Drawing.Point(23, 77);
            this.lblQtdMaxProc.Name = "lblQtdMaxProc";
            this.lblQtdMaxProc.Size = new System.Drawing.Size(221, 13);
            this.lblQtdMaxProc.TabIndex = 13;
            this.lblQtdMaxProc.Text = "Quantidade máxima de processos por minuto:";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(605, 199);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(142, 27);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Estado do processador: Aguardando";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtProbabilidadeEspera
            // 
            this.txtProbabilidadeEspera.Location = new System.Drawing.Point(361, 126);
            this.txtProbabilidadeEspera.Name = "txtProbabilidadeEspera";
            this.txtProbabilidadeEspera.Size = new System.Drawing.Size(48, 20);
            this.txtProbabilidadeEspera.TabIndex = 17;
            this.txtProbabilidadeEspera.Text = "50";
            this.txtProbabilidadeEspera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // lblProbabilidadeEspera
            // 
            this.lblProbabilidadeEspera.AutoSize = true;
            this.lblProbabilidadeEspera.Location = new System.Drawing.Point(23, 129);
            this.lblProbabilidadeEspera.Name = "lblProbabilidadeEspera";
            this.lblProbabilidadeEspera.Size = new System.Drawing.Size(332, 13);
            this.lblProbabilidadeEspera.TabIndex = 16;
            this.lblProbabilidadeEspera.Text = "Probabilidade de um processo IO-Bound entrar em estado de espera:";
            // 
            // btnParar
            // 
            this.btnParar.Enabled = false;
            this.btnParar.Location = new System.Drawing.Point(291, 152);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(122, 23);
            this.btnParar.TabIndex = 18;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // pnlLegenda
            // 
            this.pnlLegenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLegenda.Controls.Add(this.lblProcessoIO);
            this.pnlLegenda.Controls.Add(this.lblProcesso);
            this.pnlLegenda.Controls.Add(this.lblLegenda);
            this.pnlLegenda.Controls.Add(this.ucProcessoIO);
            this.pnlLegenda.Controls.Add(this.ucProcesso);
            this.pnlLegenda.Location = new System.Drawing.Point(478, 22);
            this.pnlLegenda.Name = "pnlLegenda";
            this.pnlLegenda.Size = new System.Drawing.Size(273, 124);
            this.pnlLegenda.TabIndex = 21;
            // 
            // lblProcessoIO
            // 
            this.lblProcessoIO.AutoSize = true;
            this.lblProcessoIO.Location = new System.Drawing.Point(136, 31);
            this.lblProcessoIO.Name = "lblProcessoIO";
            this.lblProcessoIO.Size = new System.Drawing.Size(99, 13);
            this.lblProcessoIO.TabIndex = 23;
            this.lblProcessoIO.Text = "Processo IO-Bound";
            // 
            // lblProcesso
            // 
            this.lblProcesso.AutoSize = true;
            this.lblProcesso.Location = new System.Drawing.Point(66, 31);
            this.lblProcesso.Name = "lblProcesso";
            this.lblProcesso.Size = new System.Drawing.Size(51, 13);
            this.lblProcesso.TabIndex = 22;
            this.lblProcesso.Text = "Processo";
            // 
            // lblLegenda
            // 
            this.lblLegenda.AutoSize = true;
            this.lblLegenda.Location = new System.Drawing.Point(3, 2);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(52, 13);
            this.lblLegenda.TabIndex = 21;
            this.lblLegenda.Text = "Legenda:";
            // 
            // ucProcessoIO
            // 
            this.ucProcessoIO.BackColor = System.Drawing.Color.Black;
            this.ucProcessoIO.EmEspera = false;
            this.ucProcessoIO.Id = 0;
            this.ucProcessoIO.IOBOund = true;
            this.ucProcessoIO.Location = new System.Drawing.Point(158, 47);
            this.ucProcessoIO.MaximumSize = new System.Drawing.Size(50, 50);
            this.ucProcessoIO.MinimumSize = new System.Drawing.Size(50, 50);
            this.ucProcessoIO.Name = "ucProcessoIO";
            this.ucProcessoIO.Size = new System.Drawing.Size(50, 50);
            this.ucProcessoIO.TabIndex = 20;
            this.ucProcessoIO.Tempo = 0;
            // 
            // ucProcesso
            // 
            this.ucProcesso.BackColor = System.Drawing.Color.Red;
            this.ucProcesso.EmEspera = false;
            this.ucProcesso.Id = 0;
            this.ucProcesso.IOBOund = false;
            this.ucProcesso.Location = new System.Drawing.Point(68, 47);
            this.ucProcesso.MaximumSize = new System.Drawing.Size(50, 50);
            this.ucProcesso.MinimumSize = new System.Drawing.Size(50, 50);
            this.ucProcesso.Name = "ucProcesso";
            this.ucProcesso.Size = new System.Drawing.Size(50, 50);
            this.ucProcesso.TabIndex = 19;
            this.ucProcesso.Tempo = 0;
            // 
            // lblInstrucao
            // 
            this.lblInstrucao.AutoSize = true;
            this.lblInstrucao.Location = new System.Drawing.Point(23, 396);
            this.lblInstrucao.Name = "lblInstrucao";
            this.lblInstrucao.Size = new System.Drawing.Size(338, 13);
            this.lblInstrucao.TabIndex = 22;
            this.lblInstrucao.Text = "Clique em um processo em estado de espera para disparar um evento.";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(415, 28);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(53, 13);
            this.lblSegundos.TabIndex = 23;
            this.lblSegundos.Text = "segundos";
            // 
            // lblSegundos2
            // 
            this.lblSegundos2.AutoSize = true;
            this.lblSegundos2.Location = new System.Drawing.Point(415, 54);
            this.lblSegundos2.Name = "lblSegundos2";
            this.lblSegundos2.Size = new System.Drawing.Size(53, 13);
            this.lblSegundos2.TabIndex = 24;
            this.lblSegundos2.Text = "segundos";
            // 
            // lblProcessos
            // 
            this.lblProcessos.AutoSize = true;
            this.lblProcessos.Location = new System.Drawing.Point(415, 80);
            this.lblProcessos.Name = "lblProcessos";
            this.lblProcessos.Size = new System.Drawing.Size(55, 13);
            this.lblProcessos.TabIndex = 25;
            this.lblProcessos.Text = "processos";
            // 
            // lblPorcento
            // 
            this.lblPorcento.AutoSize = true;
            this.lblPorcento.Location = new System.Drawing.Point(415, 106);
            this.lblPorcento.Name = "lblPorcento";
            this.lblPorcento.Size = new System.Drawing.Size(15, 13);
            this.lblPorcento.TabIndex = 26;
            this.lblPorcento.Text = "%";
            // 
            // lblPorcento2
            // 
            this.lblPorcento2.AutoSize = true;
            this.lblPorcento2.Location = new System.Drawing.Point(415, 129);
            this.lblPorcento2.Name = "lblPorcento2";
            this.lblPorcento2.Size = new System.Drawing.Size(15, 13);
            this.lblPorcento2.TabIndex = 27;
            this.lblPorcento2.Text = "%";
            // 
            // ucFIlaEspera
            // 
            this.ucFIlaEspera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ucFIlaEspera.Location = new System.Drawing.Point(26, 287);
            this.ucFIlaEspera.MaximumSize = new System.Drawing.Size(570, 100);
            this.ucFIlaEspera.MinimumSize = new System.Drawing.Size(570, 100);
            this.ucFIlaEspera.Name = "ucFIlaEspera";
            this.ucFIlaEspera.Size = new System.Drawing.Size(570, 100);
            this.ucFIlaEspera.TabIndex = 15;
            // 
            // ucFila
            // 
            this.ucFila.BackColor = System.Drawing.Color.Aqua;
            this.ucFila.Location = new System.Drawing.Point(26, 181);
            this.ucFila.MaximumSize = new System.Drawing.Size(570, 100);
            this.ucFila.MinimumSize = new System.Drawing.Size(570, 100);
            this.ucFila.Name = "ucFila";
            this.ucFila.Size = new System.Drawing.Size(570, 100);
            this.ucFila.TabIndex = 11;
            // 
            // ucProcessador
            // 
            this.ucProcessador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucProcessador.Location = new System.Drawing.Point(627, 229);
            this.ucProcessador.MaximumSize = new System.Drawing.Size(100, 100);
            this.ucProcessador.MinimumSize = new System.Drawing.Size(100, 100);
            this.ucProcessador.Name = "ucProcessador";
            this.ucProcessador.Size = new System.Drawing.Size(100, 100);
            this.ucProcessador.TabIndex = 9;
            this.ucProcessador.MudouEstado += new System.EventHandler<SimuladorEscalonamento.Controles.ProcessadorEventArgs>(this.processador_MudouEstado);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(608, 358);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(143, 29);
            this.btnSair.TabIndex = 28;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(764, 426);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblPorcento2);
            this.Controls.Add(this.lblPorcento);
            this.Controls.Add(this.lblProcessos);
            this.Controls.Add(this.lblSegundos2);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblInstrucao);
            this.Controls.Add(this.pnlLegenda);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.txtProbabilidadeEspera);
            this.Controls.Add(this.lblProbabilidadeEspera);
            this.Controls.Add(this.ucFIlaEspera);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblQtdMaxProc);
            this.Controls.Add(this.txtQtdMaxProc);
            this.Controls.Add(this.ucFila);
            this.Controls.Add(this.ucProcessador);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtQuantum);
            this.Controls.Add(this.txtTempoVida);
            this.Controls.Add(this.txtProbabilidadeIO);
            this.Controls.Add(this.lblProbabilidadeIO);
            this.Controls.Add(this.lblTempoVida);
            this.Controls.Add(this.lblQuantum);
            this.Controls.Add(this.lblSobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 465);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(780, 465);
            this.Name = "frmPrincipal";
            this.Text = "Simulador de Escalonamento de Processos";
            this.pnlLegenda.ResumeLayout(false);
            this.pnlLegenda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.Label lblQuantum;
        private System.Windows.Forms.Label lblTempoVida;
        private System.Windows.Forms.Label lblProbabilidadeIO;
        private System.Windows.Forms.TextBox txtProbabilidadeIO;
        private System.Windows.Forms.TextBox txtTempoVida;
        private System.Windows.Forms.TextBox txtQuantum;
        private System.Windows.Forms.Button btnIniciar;
        private Controles.ucProcessador ucProcessador;
        private Controles.ucFila ucFila;
        private System.Windows.Forms.TextBox txtQtdMaxProc;
        private System.Windows.Forms.Label lblQtdMaxProc;
        private System.Windows.Forms.Label lblStatus;
        private Controles.ucFIlaEspera ucFIlaEspera;
        private System.Windows.Forms.TextBox txtProbabilidadeEspera;
        private System.Windows.Forms.Label lblProbabilidadeEspera;
        private System.Windows.Forms.Button btnParar;
        private Controles.ucProcesso ucProcesso;
        private Controles.ucProcesso ucProcessoIO;
        private System.Windows.Forms.Panel pnlLegenda;
        private System.Windows.Forms.Label lblProcesso;
        private System.Windows.Forms.Label lblLegenda;
        private System.Windows.Forms.Label lblProcessoIO;
        private System.Windows.Forms.Label lblInstrucao;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblSegundos2;
        private System.Windows.Forms.Label lblProcessos;
        private System.Windows.Forms.Label lblPorcento;
        private System.Windows.Forms.Label lblPorcento2;
        private System.Windows.Forms.Button btnSair;
    }
}

