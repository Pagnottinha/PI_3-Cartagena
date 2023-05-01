namespace Teste
{
    partial class Lobby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.dgvListarJogadores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarJogadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.Location = new System.Drawing.Point(519, 186);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(310, 176);
            this.btnIniciarPartida.TabIndex = 7;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
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
            this.dgvListarJogadores.Location = new System.Drawing.Point(127, 138);
            this.dgvListarJogadores.Name = "dgvListarJogadores";
            this.dgvListarJogadores.ReadOnly = true;
            this.dgvListarJogadores.Size = new System.Drawing.Size(345, 248);
            this.dgvListarJogadores.TabIndex = 6;
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
            // btnListarJogadores
            // 
            this.btnListarJogadores.BackColor = System.Drawing.Color.Transparent;
            this.btnListarJogadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarJogadores.Location = new System.Drawing.Point(217, 402);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(144, 40);
            this.btnListarJogadores.TabIndex = 5;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = false;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.dgvListarJogadores);
            this.Controls.Add(this.btnListarJogadores);
            this.DoubleBuffered = true;
            this.Name = "Lobby";
            this.Size = new System.Drawing.Size(964, 544);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarJogadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.DataGridView dgvListarJogadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.Button btnListarJogadores;
    }
}
