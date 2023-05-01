namespace Teste
{
    partial class PartidaForm
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartidaForm));
            this.lblVez = new System.Windows.Forms.Label();
            this.lblPosicaoPirata = new System.Windows.Forms.Label();
            this.txtPosicaoPirata = new System.Windows.Forms.TextBox();
            this.btn_JogarPirata = new System.Windows.Forms.Button();
            this.btn_Historico = new System.Windows.Forms.Button();
            this.ltb_HistoricoPartida = new System.Windows.Forms.ListBox();
            this.lbl_Jogo = new System.Windows.Forms.Label();
            this.cbo_Jogar = new System.Windows.Forms.ComboBox();
            this.tmrVerificarVez = new System.Windows.Forms.Timer(this.components);
            this.lblQtdTricornio = new System.Windows.Forms.Label();
            this.lblQtdChave = new System.Windows.Forms.Label();
            this.lblQtdFaca = new System.Windows.Forms.Label();
            this.lblQtdEsqueleto = new System.Windows.Forms.Label();
            this.lblQtdGarrafa = new System.Windows.Forms.Label();
            this.lblQtdPistola = new System.Windows.Forms.Label();
            this.pnlChave = new System.Windows.Forms.Panel();
            this.pnlFaca = new System.Windows.Forms.Panel();
            this.pnlEsqueleto = new System.Windows.Forms.Panel();
            this.pnlGarrafa = new System.Windows.Forms.Panel();
            this.pnlPistola = new System.Windows.Forms.Panel();
            this.pnlTricornio = new System.Windows.Forms.Panel();
            this.tabuleiro = new Teste.Tabuleiro();
            this.pnlEstanteCartas = new System.Windows.Forms.Panel();
            this.pnlChave.SuspendLayout();
            this.pnlFaca.SuspendLayout();
            this.pnlEsqueleto.SuspendLayout();
            this.pnlGarrafa.SuspendLayout();
            this.pnlPistola.SuspendLayout();
            this.pnlTricornio.SuspendLayout();
            this.pnlEstanteCartas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVez
            // 
            this.lblVez.AutoEllipsis = true;
            this.lblVez.AutoSize = true;
            this.lblVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVez.Location = new System.Drawing.Point(209, 45);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(0, 25);
            this.lblVez.TabIndex = 29;
            // 
            // lblPosicaoPirata
            // 
            this.lblPosicaoPirata.AutoSize = true;
            this.lblPosicaoPirata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicaoPirata.Location = new System.Drawing.Point(279, 170);
            this.lblPosicaoPirata.Name = "lblPosicaoPirata";
            this.lblPosicaoPirata.Size = new System.Drawing.Size(105, 15);
            this.lblPosicaoPirata.TabIndex = 24;
            this.lblPosicaoPirata.Text = "Posição do pirata:";
            // 
            // txtPosicaoPirata
            // 
            this.txtPosicaoPirata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosicaoPirata.Location = new System.Drawing.Point(281, 197);
            this.txtPosicaoPirata.Name = "txtPosicaoPirata";
            this.txtPosicaoPirata.Size = new System.Drawing.Size(201, 22);
            this.txtPosicaoPirata.TabIndex = 23;
            // 
            // btn_JogarPirata
            // 
            this.btn_JogarPirata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JogarPirata.Location = new System.Drawing.Point(314, 238);
            this.btn_JogarPirata.Name = "btn_JogarPirata";
            this.btn_JogarPirata.Size = new System.Drawing.Size(131, 37);
            this.btn_JogarPirata.TabIndex = 22;
            this.btn_JogarPirata.Text = "Jogar";
            this.btn_JogarPirata.UseVisualStyleBackColor = true;
            this.btn_JogarPirata.Click += new System.EventHandler(this.btn_JogarPirata_Click);
            // 
            // btn_Historico
            // 
            this.btn_Historico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Historico.Location = new System.Drawing.Point(51, 291);
            this.btn_Historico.Name = "btn_Historico";
            this.btn_Historico.Size = new System.Drawing.Size(139, 35);
            this.btn_Historico.TabIndex = 21;
            this.btn_Historico.Text = "Histórico da partida";
            this.btn_Historico.UseVisualStyleBackColor = true;
            this.btn_Historico.Click += new System.EventHandler(this.btn_Historico_Click);
            // 
            // ltb_HistoricoPartida
            // 
            this.ltb_HistoricoPartida.FormattingEnabled = true;
            this.ltb_HistoricoPartida.HorizontalScrollbar = true;
            this.ltb_HistoricoPartida.Location = new System.Drawing.Point(24, 60);
            this.ltb_HistoricoPartida.Name = "ltb_HistoricoPartida";
            this.ltb_HistoricoPartida.Size = new System.Drawing.Size(185, 225);
            this.ltb_HistoricoPartida.TabIndex = 20;
            // 
            // lbl_Jogo
            // 
            this.lbl_Jogo.AutoSize = true;
            this.lbl_Jogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Jogo.Location = new System.Drawing.Point(278, 98);
            this.lbl_Jogo.Name = "lbl_Jogo";
            this.lbl_Jogo.Size = new System.Drawing.Size(204, 20);
            this.lbl_Jogo.TabIndex = 19;
            this.lbl_Jogo.Text = "Escolha o que deseja jogar:";
            // 
            // cbo_Jogar
            // 
            this.cbo_Jogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Jogar.FormattingEnabled = true;
            this.cbo_Jogar.ItemHeight = 20;
            this.cbo_Jogar.Items.AddRange(new object[] {
            "Mover para frente",
            "Mover para trás",
            "Pular vez"});
            this.cbo_Jogar.Location = new System.Drawing.Point(282, 131);
            this.cbo_Jogar.Name = "cbo_Jogar";
            this.cbo_Jogar.Size = new System.Drawing.Size(201, 28);
            this.cbo_Jogar.TabIndex = 18;
            this.cbo_Jogar.SelectedIndexChanged += new System.EventHandler(this.cbo_Jogar_SelectedIndexChanged);
            // 
            // tmrVerificarVez
            // 
            this.tmrVerificarVez.Interval = 3000;
            this.tmrVerificarVez.Tick += new System.EventHandler(this.tmrVerificarVez_Tick);
            // 
            // lblQtdTricornio
            // 
            this.lblQtdTricornio.AutoSize = true;
            this.lblQtdTricornio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdTricornio.Location = new System.Drawing.Point(64, 9);
            this.lblQtdTricornio.Name = "lblQtdTricornio";
            this.lblQtdTricornio.Size = new System.Drawing.Size(18, 20);
            this.lblQtdTricornio.TabIndex = 36;
            this.lblQtdTricornio.Text = "0";
            this.lblQtdTricornio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQtdChave
            // 
            this.lblQtdChave.AutoSize = true;
            this.lblQtdChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdChave.Location = new System.Drawing.Point(64, 9);
            this.lblQtdChave.Name = "lblQtdChave";
            this.lblQtdChave.Size = new System.Drawing.Size(18, 20);
            this.lblQtdChave.TabIndex = 31;
            this.lblQtdChave.Text = "0";
            this.lblQtdChave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQtdFaca
            // 
            this.lblQtdFaca.AutoSize = true;
            this.lblQtdFaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdFaca.Location = new System.Drawing.Point(64, 9);
            this.lblQtdFaca.Name = "lblQtdFaca";
            this.lblQtdFaca.Size = new System.Drawing.Size(18, 20);
            this.lblQtdFaca.TabIndex = 32;
            this.lblQtdFaca.Text = "0";
            this.lblQtdFaca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQtdEsqueleto
            // 
            this.lblQtdEsqueleto.AutoSize = true;
            this.lblQtdEsqueleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdEsqueleto.Location = new System.Drawing.Point(64, 9);
            this.lblQtdEsqueleto.Name = "lblQtdEsqueleto";
            this.lblQtdEsqueleto.Size = new System.Drawing.Size(18, 20);
            this.lblQtdEsqueleto.TabIndex = 33;
            this.lblQtdEsqueleto.Text = "0";
            this.lblQtdEsqueleto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQtdGarrafa
            // 
            this.lblQtdGarrafa.AutoSize = true;
            this.lblQtdGarrafa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdGarrafa.Location = new System.Drawing.Point(64, 9);
            this.lblQtdGarrafa.Name = "lblQtdGarrafa";
            this.lblQtdGarrafa.Size = new System.Drawing.Size(18, 20);
            this.lblQtdGarrafa.TabIndex = 34;
            this.lblQtdGarrafa.Text = "0";
            this.lblQtdGarrafa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQtdPistola
            // 
            this.lblQtdPistola.AutoSize = true;
            this.lblQtdPistola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdPistola.Location = new System.Drawing.Point(64, 9);
            this.lblQtdPistola.Name = "lblQtdPistola";
            this.lblQtdPistola.Size = new System.Drawing.Size(18, 20);
            this.lblQtdPistola.TabIndex = 35;
            this.lblQtdPistola.Text = "0";
            this.lblQtdPistola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlChave
            // 
            this.pnlChave.BackColor = System.Drawing.Color.Transparent;
            this.pnlChave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlChave.BackgroundImage")));
            this.pnlChave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChave.Controls.Add(this.lblQtdChave);
            this.pnlChave.Location = new System.Drawing.Point(50, 19);
            this.pnlChave.Name = "pnlChave";
            this.pnlChave.Size = new System.Drawing.Size(94, 147);
            this.pnlChave.TabIndex = 37;
            this.pnlChave.Click += new System.EventHandler(this.onClick);
            this.pnlChave.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.pnlChave.MouseLeave += new System.EventHandler(this.onMouseExit);
            // 
            // pnlFaca
            // 
            this.pnlFaca.BackColor = System.Drawing.Color.Transparent;
            this.pnlFaca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFaca.BackgroundImage")));
            this.pnlFaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFaca.Controls.Add(this.lblQtdFaca);
            this.pnlFaca.Location = new System.Drawing.Point(50, 196);
            this.pnlFaca.Name = "pnlFaca";
            this.pnlFaca.Size = new System.Drawing.Size(94, 142);
            this.pnlFaca.TabIndex = 38;
            this.pnlFaca.Click += new System.EventHandler(this.onClick);
            this.pnlFaca.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.pnlFaca.MouseLeave += new System.EventHandler(this.onMouseExit);
            // 
            // pnlEsqueleto
            // 
            this.pnlEsqueleto.BackColor = System.Drawing.Color.Transparent;
            this.pnlEsqueleto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEsqueleto.BackgroundImage")));
            this.pnlEsqueleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEsqueleto.Controls.Add(this.lblQtdEsqueleto);
            this.pnlEsqueleto.Location = new System.Drawing.Point(203, 19);
            this.pnlEsqueleto.Name = "pnlEsqueleto";
            this.pnlEsqueleto.Size = new System.Drawing.Size(94, 147);
            this.pnlEsqueleto.TabIndex = 39;
            this.pnlEsqueleto.Click += new System.EventHandler(this.onClick);
            this.pnlEsqueleto.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.pnlEsqueleto.MouseLeave += new System.EventHandler(this.onMouseExit);
            // 
            // pnlGarrafa
            // 
            this.pnlGarrafa.BackColor = System.Drawing.Color.Transparent;
            this.pnlGarrafa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGarrafa.BackgroundImage")));
            this.pnlGarrafa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGarrafa.Controls.Add(this.lblQtdGarrafa);
            this.pnlGarrafa.Location = new System.Drawing.Point(203, 196);
            this.pnlGarrafa.Name = "pnlGarrafa";
            this.pnlGarrafa.Size = new System.Drawing.Size(94, 142);
            this.pnlGarrafa.TabIndex = 40;
            this.pnlGarrafa.Click += new System.EventHandler(this.onClick);
            this.pnlGarrafa.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.pnlGarrafa.MouseLeave += new System.EventHandler(this.onMouseExit);
            // 
            // pnlPistola
            // 
            this.pnlPistola.BackColor = System.Drawing.Color.Transparent;
            this.pnlPistola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPistola.BackgroundImage")));
            this.pnlPistola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPistola.Controls.Add(this.lblQtdPistola);
            this.pnlPistola.Location = new System.Drawing.Point(345, 19);
            this.pnlPistola.Name = "pnlPistola";
            this.pnlPistola.Size = new System.Drawing.Size(94, 147);
            this.pnlPistola.TabIndex = 41;
            this.pnlPistola.Click += new System.EventHandler(this.onClick);
            this.pnlPistola.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.pnlPistola.MouseLeave += new System.EventHandler(this.onMouseExit);
            // 
            // pnlTricornio
            // 
            this.pnlTricornio.BackColor = System.Drawing.Color.Transparent;
            this.pnlTricornio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTricornio.BackgroundImage")));
            this.pnlTricornio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTricornio.Controls.Add(this.lblQtdTricornio);
            this.pnlTricornio.Location = new System.Drawing.Point(345, 196);
            this.pnlTricornio.Name = "pnlTricornio";
            this.pnlTricornio.Size = new System.Drawing.Size(94, 142);
            this.pnlTricornio.TabIndex = 42;
            this.pnlTricornio.Click += new System.EventHandler(this.onClick);
            this.pnlTricornio.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.pnlTricornio.MouseLeave += new System.EventHandler(this.onMouseExit);
            // 
            // tabuleiro
            // 
            this.tabuleiro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabuleiro.BackColor = System.Drawing.Color.Transparent;
            this.tabuleiro.Location = new System.Drawing.Point(557, 46);
            this.tabuleiro.Name = "tabuleiro";
            this.tabuleiro.Size = new System.Drawing.Size(720, 722);
            this.tabuleiro.TabIndex = 27;
            // 
            // pnlEstanteCartas
            // 
            this.pnlEstanteCartas.BackColor = System.Drawing.Color.Transparent;
            this.pnlEstanteCartas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEstanteCartas.BackgroundImage")));
            this.pnlEstanteCartas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEstanteCartas.Controls.Add(this.pnlChave);
            this.pnlEstanteCartas.Controls.Add(this.pnlTricornio);
            this.pnlEstanteCartas.Controls.Add(this.pnlEsqueleto);
            this.pnlEstanteCartas.Controls.Add(this.pnlGarrafa);
            this.pnlEstanteCartas.Controls.Add(this.pnlPistola);
            this.pnlEstanteCartas.Controls.Add(this.pnlFaca);
            this.pnlEstanteCartas.Location = new System.Drawing.Point(11, 374);
            this.pnlEstanteCartas.Name = "pnlEstanteCartas";
            this.pnlEstanteCartas.Size = new System.Drawing.Size(514, 357);
            this.pnlEstanteCartas.TabIndex = 43;
            // 
            // PartidaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlEstanteCartas);
            this.Controls.Add(this.lblVez);
            this.Controls.Add(this.tabuleiro);
            this.Controls.Add(this.lblPosicaoPirata);
            this.Controls.Add(this.txtPosicaoPirata);
            this.Controls.Add(this.btn_JogarPirata);
            this.Controls.Add(this.btn_Historico);
            this.Controls.Add(this.ltb_HistoricoPartida);
            this.Controls.Add(this.lbl_Jogo);
            this.Controls.Add(this.cbo_Jogar);
            this.Name = "PartidaForm";
            this.Size = new System.Drawing.Size(1289, 784);
            this.pnlChave.ResumeLayout(false);
            this.pnlChave.PerformLayout();
            this.pnlFaca.ResumeLayout(false);
            this.pnlFaca.PerformLayout();
            this.pnlEsqueleto.ResumeLayout(false);
            this.pnlEsqueleto.PerformLayout();
            this.pnlGarrafa.ResumeLayout(false);
            this.pnlGarrafa.PerformLayout();
            this.pnlPistola.ResumeLayout(false);
            this.pnlPistola.PerformLayout();
            this.pnlTricornio.ResumeLayout(false);
            this.pnlTricornio.PerformLayout();
            this.pnlEstanteCartas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVez;
        private Tabuleiro tabuleiro;
        private System.Windows.Forms.Label lblPosicaoPirata;
        private System.Windows.Forms.TextBox txtPosicaoPirata;
        private System.Windows.Forms.Button btn_JogarPirata;
        private System.Windows.Forms.Button btn_Historico;
        private System.Windows.Forms.ListBox ltb_HistoricoPartida;
        private System.Windows.Forms.Label lbl_Jogo;
        private System.Windows.Forms.ComboBox cbo_Jogar;
        private System.Windows.Forms.Timer tmrVerificarVez;
        private System.Windows.Forms.Label lblQtdTricornio;
        private System.Windows.Forms.Label lblQtdChave;
        private System.Windows.Forms.Label lblQtdFaca;
        private System.Windows.Forms.Label lblQtdEsqueleto;
        private System.Windows.Forms.Label lblQtdGarrafa;
        private System.Windows.Forms.Label lblQtdPistola;
        private System.Windows.Forms.Panel pnlChave;
        private System.Windows.Forms.Panel pnlFaca;
        private System.Windows.Forms.Panel pnlEsqueleto;
        private System.Windows.Forms.Panel pnlGarrafa;
        private System.Windows.Forms.Panel pnlPistola;
        private System.Windows.Forms.Panel pnlTricornio;
        private System.Windows.Forms.Panel pnlEstanteCartas;
    }
}
