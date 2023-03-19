namespace Teste
{
    partial class frmLobby
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
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.dgvListarJogadores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDadosJogador = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.lblidJogador = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.grpIniciarPartida = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarJogadores)).BeginInit();
            this.grpIniciarPartida.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarJogadores.Location = new System.Drawing.Point(119, 326);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(144, 40);
            this.btnListarJogadores.TabIndex = 1;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // dgvListarJogadores
            // 
            this.dgvListarJogadores.AllowUserToAddRows = false;
            this.dgvListarJogadores.AllowUserToDeleteRows = false;
            this.dgvListarJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarJogadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Jogador,
            this.Cor});
            this.dgvListarJogadores.Location = new System.Drawing.Point(12, 61);
            this.dgvListarJogadores.Name = "dgvListarJogadores";
            this.dgvListarJogadores.ReadOnly = true;
            this.dgvListarJogadores.Size = new System.Drawing.Size(345, 248);
            this.dgvListarJogadores.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Jogador
            // 
            this.Jogador.DataPropertyName = "nome";
            this.Jogador.Name = "Jogador";
            this.Jogador.ReadOnly = true;
            // 
            // Cor
            // 
            this.Cor.DataPropertyName = "cor";
            this.Cor.Name = "Cor";
            this.Cor.ReadOnly = true;
            // 
            // lblDadosJogador
            // 
            this.lblDadosJogador.AutoSize = true;
            this.lblDadosJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosJogador.Location = new System.Drawing.Point(190, 9);
            this.lblDadosJogador.Name = "lblDadosJogador";
            this.lblDadosJogador.Size = new System.Drawing.Size(256, 20);
            this.lblDadosJogador.TabIndex = 3;
            this.lblDadosJogador.Text = "ID:         Nome:         Senha:       Cor:";
            this.lblDadosJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.Location = new System.Drawing.Point(28, 153);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(134, 38);
            this.btnIniciarPartida.TabIndex = 4;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // lblidJogador
            // 
            this.lblidJogador.AutoSize = true;
            this.lblidJogador.Location = new System.Drawing.Point(25, 23);
            this.lblidJogador.Name = "lblidJogador";
            this.lblidJogador.Size = new System.Drawing.Size(21, 13);
            this.lblidJogador.TabIndex = 5;
            this.lblidJogador.Text = "ID:";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Location = new System.Drawing.Point(25, 82);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaJogador.TabIndex = 6;
            this.lblSenhaJogador.Text = "Senha:";
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(28, 48);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(134, 20);
            this.txtIdJogador.TabIndex = 7;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(28, 107);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(134, 20);
            this.txtSenhaJogador.TabIndex = 8;
            // 
            // grpIniciarPartida
            // 
            this.grpIniciarPartida.Controls.Add(this.txtSenhaJogador);
            this.grpIniciarPartida.Controls.Add(this.txtIdJogador);
            this.grpIniciarPartida.Controls.Add(this.lblSenhaJogador);
            this.grpIniciarPartida.Controls.Add(this.lblidJogador);
            this.grpIniciarPartida.Controls.Add(this.btnIniciarPartida);
            this.grpIniciarPartida.Location = new System.Drawing.Point(467, 106);
            this.grpIniciarPartida.Name = "grpIniciarPartida";
            this.grpIniciarPartida.Size = new System.Drawing.Size(193, 220);
            this.grpIniciarPartida.TabIndex = 9;
            this.grpIniciarPartida.TabStop = false;
            this.grpIniciarPartida.Text = "Iniciar Partida";
            // 
            // frmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpIniciarPartida);
            this.Controls.Add(this.lblDadosJogador);
            this.Controls.Add(this.dgvListarJogadores);
            this.Controls.Add(this.btnListarJogadores);
            this.Name = "frmLobby";
            this.Text = "Form Lobby";
            this.Load += new System.EventHandler(this.frmLobby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarJogadores)).EndInit();
            this.grpIniciarPartida.ResumeLayout(false);
            this.grpIniciarPartida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.DataGridView dgvListarJogadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Jogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Jogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jogador;
        private System.Windows.Forms.Label lblDadosJogador;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblidJogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.GroupBox grpIniciarPartida;
    }
}