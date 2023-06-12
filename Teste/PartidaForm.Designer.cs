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
            this.tmrVerificarVez = new System.Windows.Forms.Timer(this.components);
            this.btnVoltaLobby = new System.Windows.Forms.Button();
            this.cbo_Jogar = new System.Windows.Forms.ComboBox();
            this.lbl_Jogo = new System.Windows.Forms.Label();
            this.ltb_HistoricoPartida = new System.Windows.Forms.ListBox();
            this.btn_Historico = new System.Windows.Forms.Button();
            this.btn_JogarPirata = new System.Windows.Forms.Button();
            this.txtPosicaoPirata = new System.Windows.Forms.TextBox();
            this.lblPosicaoPirata = new System.Windows.Forms.Label();
            this.btnJogadaAutomatica = new System.Windows.Forms.Button();
            this.grbJogadas = new System.Windows.Forms.GroupBox();
            this.pnlChave = new System.Windows.Forms.Panel();
            this.lblQtdChave = new System.Windows.Forms.Label();
            this.pnlTricornio = new System.Windows.Forms.Panel();
            this.lblQtdTricornio = new System.Windows.Forms.Label();
            this.pnlEsqueleto = new System.Windows.Forms.Panel();
            this.lblQtdEsqueleto = new System.Windows.Forms.Label();
            this.pnlGarrafa = new System.Windows.Forms.Panel();
            this.lblQtdGarrafa = new System.Windows.Forms.Label();
            this.pnlPistola = new System.Windows.Forms.Panel();
            this.lblQtdPistola = new System.Windows.Forms.Label();
            this.pnlFaca = new System.Windows.Forms.Panel();
            this.lblQtdFaca = new System.Windows.Forms.Label();
            this.pnlMao = new System.Windows.Forms.Panel();
            this.tabuleiro = new Teste.Tabuleiro();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.pnlHistorico = new System.Windows.Forms.Panel();
            this.grbJogadas.SuspendLayout();
            this.pnlChave.SuspendLayout();
            this.pnlTricornio.SuspendLayout();
            this.pnlEsqueleto.SuspendLayout();
            this.pnlGarrafa.SuspendLayout();
            this.pnlPistola.SuspendLayout();
            this.pnlFaca.SuspendLayout();
            this.pnlMao.SuspendLayout();
            this.pnlHistorico.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrVerificarVez
            // 
            this.tmrVerificarVez.Interval = 7000;
            this.tmrVerificarVez.Tick += new System.EventHandler(this.tmrVerificarVez_Tick);
            // 
            // btnVoltaLobby
            // 
            this.btnVoltaLobby.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltaLobby.BackgroundImage = global::Teste.Properties.Resources.btnVoltarProLobby;
            this.btnVoltaLobby.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltaLobby.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltaLobby.FlatAppearance.BorderSize = 0;
            this.btnVoltaLobby.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVoltaLobby.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVoltaLobby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltaLobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltaLobby.Location = new System.Drawing.Point(28, 701);
            this.btnVoltaLobby.Name = "btnVoltaLobby";
            this.btnVoltaLobby.Size = new System.Drawing.Size(262, 68);
            this.btnVoltaLobby.TabIndex = 45;
            this.btnVoltaLobby.UseVisualStyleBackColor = false;
            this.btnVoltaLobby.Click += new System.EventHandler(this.btnVoltaLobby_Click);
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
            this.cbo_Jogar.Location = new System.Drawing.Point(82, 51);
            this.cbo_Jogar.Name = "cbo_Jogar";
            this.cbo_Jogar.Size = new System.Drawing.Size(201, 28);
            this.cbo_Jogar.TabIndex = 18;
            this.cbo_Jogar.SelectedIndexChanged += new System.EventHandler(this.cbo_Jogar_SelectedIndexChanged);
            // 
            // lbl_Jogo
            // 
            this.lbl_Jogo.AutoSize = true;
            this.lbl_Jogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Jogo.Location = new System.Drawing.Point(79, 16);
            this.lbl_Jogo.Name = "lbl_Jogo";
            this.lbl_Jogo.Size = new System.Drawing.Size(204, 20);
            this.lbl_Jogo.TabIndex = 19;
            this.lbl_Jogo.Text = "Escolha o que deseja jogar:";
            // 
            // ltb_HistoricoPartida
            // 
            this.ltb_HistoricoPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(192)))), ((int)(((byte)(177)))));
            this.ltb_HistoricoPartida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltb_HistoricoPartida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ltb_HistoricoPartida.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltb_HistoricoPartida.FormattingEnabled = true;
            this.ltb_HistoricoPartida.HorizontalScrollbar = true;
            this.ltb_HistoricoPartida.ItemHeight = 30;
            this.ltb_HistoricoPartida.Location = new System.Drawing.Point(21, 50);
            this.ltb_HistoricoPartida.Name = "ltb_HistoricoPartida";
            this.ltb_HistoricoPartida.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ltb_HistoricoPartida.Size = new System.Drawing.Size(301, 390);
            this.ltb_HistoricoPartida.TabIndex = 20;
            this.ltb_HistoricoPartida.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ltb_HistoricoPartida_DrawItem);
            // 
            // btn_Historico
            // 
            this.btn_Historico.BackColor = System.Drawing.Color.Transparent;
            this.btn_Historico.BackgroundImage = global::Teste.Properties.Resources.btnObterHistorico;
            this.btn_Historico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Historico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Historico.FlatAppearance.BorderSize = 0;
            this.btn_Historico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Historico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Historico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Historico.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Historico.Location = new System.Drawing.Point(1003, 495);
            this.btn_Historico.Name = "btn_Historico";
            this.btn_Historico.Size = new System.Drawing.Size(174, 45);
            this.btn_Historico.TabIndex = 21;
            this.btn_Historico.UseVisualStyleBackColor = false;
            this.btn_Historico.Click += new System.EventHandler(this.btn_Historico_Click);
            // 
            // btn_JogarPirata
            // 
            this.btn_JogarPirata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JogarPirata.Location = new System.Drawing.Point(44, 143);
            this.btn_JogarPirata.Name = "btn_JogarPirata";
            this.btn_JogarPirata.Size = new System.Drawing.Size(131, 37);
            this.btn_JogarPirata.TabIndex = 22;
            this.btn_JogarPirata.Text = "Jogar";
            this.btn_JogarPirata.UseVisualStyleBackColor = true;
            this.btn_JogarPirata.Click += new System.EventHandler(this.btn_JogarPirata_Click);
            // 
            // txtPosicaoPirata
            // 
            this.txtPosicaoPirata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosicaoPirata.Location = new System.Drawing.Point(81, 109);
            this.txtPosicaoPirata.Name = "txtPosicaoPirata";
            this.txtPosicaoPirata.Size = new System.Drawing.Size(201, 22);
            this.txtPosicaoPirata.TabIndex = 23;
            // 
            // lblPosicaoPirata
            // 
            this.lblPosicaoPirata.AutoSize = true;
            this.lblPosicaoPirata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicaoPirata.Location = new System.Drawing.Point(79, 82);
            this.lblPosicaoPirata.Name = "lblPosicaoPirata";
            this.lblPosicaoPirata.Size = new System.Drawing.Size(105, 15);
            this.lblPosicaoPirata.TabIndex = 24;
            this.lblPosicaoPirata.Text = "Posição do pirata:";
            // 
            // btnJogadaAutomatica
            // 
            this.btnJogadaAutomatica.Location = new System.Drawing.Point(200, 143);
            this.btnJogadaAutomatica.Name = "btnJogadaAutomatica";
            this.btnJogadaAutomatica.Size = new System.Drawing.Size(129, 37);
            this.btnJogadaAutomatica.TabIndex = 44;
            this.btnJogadaAutomatica.Text = "Jogar Automatico";
            this.btnJogadaAutomatica.UseVisualStyleBackColor = true;
            this.btnJogadaAutomatica.Click += new System.EventHandler(this.btnJogadaAutomatica_Click);
            // 
            // grbJogadas
            // 
            this.grbJogadas.BackColor = System.Drawing.Color.Transparent;
            this.grbJogadas.Controls.Add(this.btnJogadaAutomatica);
            this.grbJogadas.Controls.Add(this.lblPosicaoPirata);
            this.grbJogadas.Controls.Add(this.txtPosicaoPirata);
            this.grbJogadas.Controls.Add(this.btn_JogarPirata);
            this.grbJogadas.Controls.Add(this.lbl_Jogo);
            this.grbJogadas.Controls.Add(this.cbo_Jogar);
            this.grbJogadas.Location = new System.Drawing.Point(910, 573);
            this.grbJogadas.Name = "grbJogadas";
            this.grbJogadas.Size = new System.Drawing.Size(366, 196);
            this.grbJogadas.TabIndex = 46;
            this.grbJogadas.TabStop = false;
            this.grbJogadas.Text = "Jogadas";
            // 
            // pnlChave
            // 
            this.pnlChave.BackColor = System.Drawing.Color.Transparent;
            this.pnlChave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlChave.BackgroundImage")));
            this.pnlChave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChave.Controls.Add(this.lblQtdChave);
            this.pnlChave.Location = new System.Drawing.Point(78, 26);
            this.pnlChave.Name = "pnlChave";
            this.pnlChave.Size = new System.Drawing.Size(94, 147);
            this.pnlChave.TabIndex = 37;
            this.pnlChave.Click += new System.EventHandler(this.onClick);
            this.pnlChave.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.pnlChave.MouseLeave += new System.EventHandler(this.onMouseExit);
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
            // pnlTricornio
            // 
            this.pnlTricornio.BackColor = System.Drawing.Color.Transparent;
            this.pnlTricornio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTricornio.BackgroundImage")));
            this.pnlTricornio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTricornio.Controls.Add(this.lblQtdTricornio);
            this.pnlTricornio.Location = new System.Drawing.Point(314, 87);
            this.pnlTricornio.Name = "pnlTricornio";
            this.pnlTricornio.Size = new System.Drawing.Size(94, 142);
            this.pnlTricornio.TabIndex = 42;
            this.pnlTricornio.Click += new System.EventHandler(this.onClick);
            this.pnlTricornio.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.pnlTricornio.MouseLeave += new System.EventHandler(this.onMouseExit);
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
            // pnlEsqueleto
            // 
            this.pnlEsqueleto.BackColor = System.Drawing.Color.Transparent;
            this.pnlEsqueleto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEsqueleto.BackgroundImage")));
            this.pnlEsqueleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEsqueleto.Controls.Add(this.lblQtdEsqueleto);
            this.pnlEsqueleto.Location = new System.Drawing.Point(230, 26);
            this.pnlEsqueleto.Name = "pnlEsqueleto";
            this.pnlEsqueleto.Size = new System.Drawing.Size(94, 147);
            this.pnlEsqueleto.TabIndex = 39;
            this.pnlEsqueleto.Click += new System.EventHandler(this.onClick);
            this.pnlEsqueleto.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.pnlEsqueleto.MouseLeave += new System.EventHandler(this.onMouseExit);
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
            // pnlGarrafa
            // 
            this.pnlGarrafa.BackColor = System.Drawing.Color.Transparent;
            this.pnlGarrafa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGarrafa.BackgroundImage")));
            this.pnlGarrafa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGarrafa.Controls.Add(this.lblQtdGarrafa);
            this.pnlGarrafa.Location = new System.Drawing.Point(10, 87);
            this.pnlGarrafa.Name = "pnlGarrafa";
            this.pnlGarrafa.Size = new System.Drawing.Size(94, 142);
            this.pnlGarrafa.TabIndex = 40;
            this.pnlGarrafa.Click += new System.EventHandler(this.onClick);
            this.pnlGarrafa.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.pnlGarrafa.MouseLeave += new System.EventHandler(this.onMouseExit);
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
            // pnlPistola
            // 
            this.pnlPistola.BackColor = System.Drawing.Color.Transparent;
            this.pnlPistola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPistola.BackgroundImage")));
            this.pnlPistola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPistola.Controls.Add(this.lblQtdPistola);
            this.pnlPistola.Location = new System.Drawing.Point(392, 26);
            this.pnlPistola.Name = "pnlPistola";
            this.pnlPistola.Size = new System.Drawing.Size(94, 147);
            this.pnlPistola.TabIndex = 41;
            this.pnlPistola.Click += new System.EventHandler(this.onClick);
            this.pnlPistola.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.pnlPistola.MouseLeave += new System.EventHandler(this.onMouseExit);
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
            // pnlFaca
            // 
            this.pnlFaca.BackColor = System.Drawing.Color.Transparent;
            this.pnlFaca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFaca.BackgroundImage")));
            this.pnlFaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFaca.Controls.Add(this.lblQtdFaca);
            this.pnlFaca.Location = new System.Drawing.Point(155, 87);
            this.pnlFaca.Name = "pnlFaca";
            this.pnlFaca.Size = new System.Drawing.Size(94, 142);
            this.pnlFaca.TabIndex = 38;
            this.pnlFaca.Click += new System.EventHandler(this.onClick);
            this.pnlFaca.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.pnlFaca.MouseLeave += new System.EventHandler(this.onMouseExit);
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
            // pnlMao
            // 
            this.pnlMao.BackColor = System.Drawing.Color.Transparent;
            this.pnlMao.Controls.Add(this.pnlTricornio);
            this.pnlMao.Controls.Add(this.pnlFaca);
            this.pnlMao.Controls.Add(this.pnlGarrafa);
            this.pnlMao.Controls.Add(this.pnlChave);
            this.pnlMao.Controls.Add(this.pnlEsqueleto);
            this.pnlMao.Controls.Add(this.pnlPistola);
            this.pnlMao.Location = new System.Drawing.Point(395, 540);
            this.pnlMao.Name = "pnlMao";
            this.pnlMao.Size = new System.Drawing.Size(499, 236);
            this.pnlMao.TabIndex = 48;
            // 
            // tabuleiro
            // 
            this.tabuleiro.BackColor = System.Drawing.Color.Transparent;
            this.tabuleiro.Location = new System.Drawing.Point(395, 26);
            this.tabuleiro.Name = "tabuleiro";
            this.tabuleiro.Size = new System.Drawing.Size(480, 480);
            this.tabuleiro.TabIndex = 47;
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.BackColor = System.Drawing.Color.Transparent;
            this.lblHistorico.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(192)))), ((int)(((byte)(177)))));
            this.lblHistorico.Location = new System.Drawing.Point(108, 8);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(131, 35);
            this.lblHistorico.TabIndex = 49;
            this.lblHistorico.Text = "Histórico";
            // 
            // pnlHistorico
            // 
            this.pnlHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(122)))), ((int)(((byte)(90)))));
            this.pnlHistorico.Controls.Add(this.lblHistorico);
            this.pnlHistorico.Controls.Add(this.ltb_HistoricoPartida);
            this.pnlHistorico.Location = new System.Drawing.Point(925, 18);
            this.pnlHistorico.Name = "pnlHistorico";
            this.pnlHistorico.Size = new System.Drawing.Size(341, 471);
            this.pnlHistorico.TabIndex = 50;
            // 
            // PartidaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Teste.Properties.Resources.bgPartida;
            this.Controls.Add(this.pnlHistorico);
            this.Controls.Add(this.pnlMao);
            this.Controls.Add(this.tabuleiro);
            this.Controls.Add(this.grbJogadas);
            this.Controls.Add(this.btnVoltaLobby);
            this.Controls.Add(this.btn_Historico);
            this.Name = "PartidaForm";
            this.Size = new System.Drawing.Size(1289, 784);
            this.grbJogadas.ResumeLayout(false);
            this.grbJogadas.PerformLayout();
            this.pnlChave.ResumeLayout(false);
            this.pnlChave.PerformLayout();
            this.pnlTricornio.ResumeLayout(false);
            this.pnlTricornio.PerformLayout();
            this.pnlEsqueleto.ResumeLayout(false);
            this.pnlEsqueleto.PerformLayout();
            this.pnlGarrafa.ResumeLayout(false);
            this.pnlGarrafa.PerformLayout();
            this.pnlPistola.ResumeLayout(false);
            this.pnlPistola.PerformLayout();
            this.pnlFaca.ResumeLayout(false);
            this.pnlFaca.PerformLayout();
            this.pnlMao.ResumeLayout(false);
            this.pnlHistorico.ResumeLayout(false);
            this.pnlHistorico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button btnVoltaLobby;
        private System.Windows.Forms.ComboBox cbo_Jogar;
        private System.Windows.Forms.Label lbl_Jogo;
        private System.Windows.Forms.ListBox ltb_HistoricoPartida;
        private System.Windows.Forms.Button btn_Historico;
        private System.Windows.Forms.Button btn_JogarPirata;
        private System.Windows.Forms.TextBox txtPosicaoPirata;
        private System.Windows.Forms.Label lblPosicaoPirata;
        private System.Windows.Forms.Button btnJogadaAutomatica;
        private System.Windows.Forms.GroupBox grbJogadas;
        private Tabuleiro tabuleiro;
        private System.Windows.Forms.Panel pnlMao;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Panel pnlHistorico;
    }
}
