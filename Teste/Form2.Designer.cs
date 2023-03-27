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
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarJogadores)).BeginInit();
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
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.Location = new System.Drawing.Point(483, 160);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(157, 48);
            this.btnIniciarPartida.TabIndex = 4;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // frmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.dgvListarJogadores);
            this.Controls.Add(this.btnListarJogadores);
            this.Name = "frmLobby";
            this.Text = "Form Lobby";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarJogadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.DataGridView dgvListarJogadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Jogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Jogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jogador;
        private System.Windows.Forms.Button btnIniciarPartida;
    }
}