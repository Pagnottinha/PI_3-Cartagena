﻿namespace Teste
{
    partial class frmJogo
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
            this.ltb_Cartas = new System.Windows.Forms.ListBox();
            this.btn_ConsultarMao = new System.Windows.Forms.Button();
            this.cbo_Jogar = new System.Windows.Forms.ComboBox();
            this.lbl_Jogo = new System.Windows.Forms.Label();
            this.ltb_HistoricoPartida = new System.Windows.Forms.ListBox();
            this.btn_Historico = new System.Windows.Forms.Button();
            this.btn_JogarPirata = new System.Windows.Forms.Button();
            this.txtPosicaoPirata = new System.Windows.Forms.TextBox();
            this.lblPosicaoPirata = new System.Windows.Forms.Label();
            this.lblJogarCarta = new System.Windows.Forms.Label();
            this.txtCartaSelecionada = new System.Windows.Forms.TextBox();
            this.tabuleiro = new Teste.Tabuleiro();
            this.btnVez = new System.Windows.Forms.Button();
            this.lblVez = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltb_Cartas
            // 
            this.ltb_Cartas.FormattingEnabled = true;
            this.ltb_Cartas.Location = new System.Drawing.Point(12, 456);
            this.ltb_Cartas.Margin = new System.Windows.Forms.Padding(2);
            this.ltb_Cartas.Name = "ltb_Cartas";
            this.ltb_Cartas.Size = new System.Drawing.Size(192, 225);
            this.ltb_Cartas.TabIndex = 0;
            // 
            // btn_ConsultarMao
            // 
            this.btn_ConsultarMao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConsultarMao.Location = new System.Drawing.Point(46, 697);
            this.btn_ConsultarMao.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ConsultarMao.Name = "btn_ConsultarMao";
            this.btn_ConsultarMao.Size = new System.Drawing.Size(112, 34);
            this.btn_ConsultarMao.TabIndex = 1;
            this.btn_ConsultarMao.Text = "Consultar Mão";
            this.btn_ConsultarMao.UseVisualStyleBackColor = true;
            this.btn_ConsultarMao.Click += new System.EventHandler(this.btn_ConsultarMao_Click);
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
            this.cbo_Jogar.Location = new System.Drawing.Point(215, 265);
            this.cbo_Jogar.Name = "cbo_Jogar";
            this.cbo_Jogar.Size = new System.Drawing.Size(201, 28);
            this.cbo_Jogar.TabIndex = 2;
            this.cbo_Jogar.SelectedIndexChanged += new System.EventHandler(this.cbo_Jogar_SelectedIndexChanged);
            // 
            // lbl_Jogo
            // 
            this.lbl_Jogo.AutoSize = true;
            this.lbl_Jogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Jogo.Location = new System.Drawing.Point(211, 232);
            this.lbl_Jogo.Name = "lbl_Jogo";
            this.lbl_Jogo.Size = new System.Drawing.Size(204, 20);
            this.lbl_Jogo.TabIndex = 3;
            this.lbl_Jogo.Text = "Escolha o que deseja jogar:";
            // 
            // ltb_HistoricoPartida
            // 
            this.ltb_HistoricoPartida.FormattingEnabled = true;
            this.ltb_HistoricoPartida.HorizontalScrollbar = true;
            this.ltb_HistoricoPartida.Location = new System.Drawing.Point(12, 12);
            this.ltb_HistoricoPartida.Name = "ltb_HistoricoPartida";
            this.ltb_HistoricoPartida.Size = new System.Drawing.Size(185, 225);
            this.ltb_HistoricoPartida.TabIndex = 4;
            // 
            // btn_Historico
            // 
            this.btn_Historico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Historico.Location = new System.Drawing.Point(35, 243);
            this.btn_Historico.Name = "btn_Historico";
            this.btn_Historico.Size = new System.Drawing.Size(139, 35);
            this.btn_Historico.TabIndex = 5;
            this.btn_Historico.Text = "Histórico da partida";
            this.btn_Historico.UseVisualStyleBackColor = true;
            this.btn_Historico.Click += new System.EventHandler(this.btn_Historico_Click);
            // 
            // btn_JogarPirata
            // 
            this.btn_JogarPirata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JogarPirata.Location = new System.Drawing.Point(248, 432);
            this.btn_JogarPirata.Name = "btn_JogarPirata";
            this.btn_JogarPirata.Size = new System.Drawing.Size(131, 37);
            this.btn_JogarPirata.TabIndex = 6;
            this.btn_JogarPirata.Text = "Jogar";
            this.btn_JogarPirata.UseVisualStyleBackColor = true;
            this.btn_JogarPirata.Click += new System.EventHandler(this.btn_JogarPirata_Click);
            // 
            // txtPosicaoPirata
            // 
            this.txtPosicaoPirata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosicaoPirata.Location = new System.Drawing.Point(214, 331);
            this.txtPosicaoPirata.Name = "txtPosicaoPirata";
            this.txtPosicaoPirata.Size = new System.Drawing.Size(201, 22);
            this.txtPosicaoPirata.TabIndex = 9;
            // 
            // lblPosicaoPirata
            // 
            this.lblPosicaoPirata.AutoSize = true;
            this.lblPosicaoPirata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicaoPirata.Location = new System.Drawing.Point(212, 304);
            this.lblPosicaoPirata.Name = "lblPosicaoPirata";
            this.lblPosicaoPirata.Size = new System.Drawing.Size(105, 15);
            this.lblPosicaoPirata.TabIndex = 10;
            this.lblPosicaoPirata.Text = "Posição do pirata:";
            // 
            // lblJogarCarta
            // 
            this.lblJogarCarta.AutoSize = true;
            this.lblJogarCarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogarCarta.Location = new System.Drawing.Point(212, 365);
            this.lblJogarCarta.Name = "lblJogarCarta";
            this.lblJogarCarta.Size = new System.Drawing.Size(134, 15);
            this.lblJogarCarta.TabIndex = 11;
            this.lblJogarCarta.Text = "Carta que deseja jogar:";
            // 
            // txtCartaSelecionada
            // 
            this.txtCartaSelecionada.Location = new System.Drawing.Point(213, 397);
            this.txtCartaSelecionada.Name = "txtCartaSelecionada";
            this.txtCartaSelecionada.Size = new System.Drawing.Size(202, 20);
            this.txtCartaSelecionada.TabIndex = 12;
            // 
            // tabuleiro
            // 
            this.tabuleiro.BackColor = System.Drawing.Color.Transparent;
            this.tabuleiro.Location = new System.Drawing.Point(442, 13);
            this.tabuleiro.Name = "tabuleiro";
            this.tabuleiro.Size = new System.Drawing.Size(720, 722);
            this.tabuleiro.TabIndex = 13;
            // 
            // btnVez
            // 
            this.btnVez.Location = new System.Drawing.Point(248, 515);
            this.btnVez.Name = "btnVez";
            this.btnVez.Size = new System.Drawing.Size(131, 58);
            this.btnVez.TabIndex = 14;
            this.btnVez.Text = "TESTAR ";
            this.btnVez.UseVisualStyleBackColor = true;
            this.btnVez.Click += new System.EventHandler(this.btnVez_Click);
            // 
            // lblVez
            // 
            this.lblVez.AutoEllipsis = true;
            this.lblVez.AutoSize = true;
            this.lblVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVez.Location = new System.Drawing.Point(210, 12);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(0, 25);
            this.lblVez.TabIndex = 15;
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1174, 747);
            this.Controls.Add(this.lblVez);
            this.Controls.Add(this.btnVez);
            this.Controls.Add(this.tabuleiro);
            this.Controls.Add(this.txtCartaSelecionada);
            this.Controls.Add(this.lblJogarCarta);
            this.Controls.Add(this.lblPosicaoPirata);
            this.Controls.Add(this.txtPosicaoPirata);
            this.Controls.Add(this.btn_JogarPirata);
            this.Controls.Add(this.btn_Historico);
            this.Controls.Add(this.ltb_HistoricoPartida);
            this.Controls.Add(this.lbl_Jogo);
            this.Controls.Add(this.cbo_Jogar);
            this.Controls.Add(this.btn_ConsultarMao);
            this.Controls.Add(this.ltb_Cartas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmJogo";
            this.Text = "Jogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltb_Cartas;
        private System.Windows.Forms.Button btn_ConsultarMao;
        private System.Windows.Forms.ComboBox cbo_Jogar;
        private System.Windows.Forms.Label lbl_Jogo;
        private System.Windows.Forms.ListBox ltb_HistoricoPartida;
        private System.Windows.Forms.Button btn_Historico;
        private System.Windows.Forms.Button btn_JogarPirata;
        private System.Windows.Forms.TextBox txtPosicaoPirata;
        private System.Windows.Forms.Label lblPosicaoPirata;
        private System.Windows.Forms.Label lblJogarCarta;
        private System.Windows.Forms.TextBox txtCartaSelecionada;
        private Tabuleiro tabuleiro;
        private System.Windows.Forms.Button btnVez;
        private System.Windows.Forms.Label lblVez;
    }
}