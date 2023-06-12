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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.dgvListarJogadores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.pnlJogadores = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarJogadores)).BeginInit();
            this.pnlJogadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarPartida.BackgroundImage = global::Teste.Properties.Resources.btn_partida;
            this.btnIniciarPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarPartida.FlatAppearance.BorderSize = 0;
            this.btnIniciarPartida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIniciarPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.Location = new System.Drawing.Point(636, 470);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(185, 47);
            this.btnIniciarPartida.TabIndex = 7;
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // dgvListarJogadores
            // 
            this.dgvListarJogadores.AllowUserToAddRows = false;
            this.dgvListarJogadores.AllowUserToDeleteRows = false;
            this.dgvListarJogadores.AllowUserToResizeColumns = false;
            this.dgvListarJogadores.AllowUserToResizeRows = false;
            this.dgvListarJogadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListarJogadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(192)))), ((int)(((byte)(177)))));
            this.dgvListarJogadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListarJogadores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListarJogadores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvListarJogadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(152)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(152)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarJogadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListarJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarJogadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Jogador,
            this.Cor});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(192)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(192)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListarJogadores.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListarJogadores.Enabled = false;
            this.dgvListarJogadores.EnableHeadersVisualStyles = false;
            this.dgvListarJogadores.GridColor = System.Drawing.Color.Black;
            this.dgvListarJogadores.Location = new System.Drawing.Point(15, 43);
            this.dgvListarJogadores.MultiSelect = false;
            this.dgvListarJogadores.Name = "dgvListarJogadores";
            this.dgvListarJogadores.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(192)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarJogadores.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListarJogadores.RowHeadersVisible = false;
            this.dgvListarJogadores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvListarJogadores.RowTemplate.Height = 40;
            this.dgvListarJogadores.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvListarJogadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarJogadores.Size = new System.Drawing.Size(341, 300);
            this.dgvListarJogadores.TabIndex = 6;
            this.dgvListarJogadores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListarJogadores_CellFormatting);
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
            this.btnListarJogadores.BackgroundImage = global::Teste.Properties.Resources.btn_jogadores;
            this.btnListarJogadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListarJogadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarJogadores.FlatAppearance.BorderSize = 0;
            this.btnListarJogadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnListarJogadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnListarJogadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarJogadores.Location = new System.Drawing.Point(636, 410);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(185, 45);
            this.btnListarJogadores.TabIndex = 5;
            this.btnListarJogadores.UseVisualStyleBackColor = false;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // pnlJogadores
            // 
            this.pnlJogadores.BackgroundImage = global::Teste.Properties.Resources.painel_jogadores;
            this.pnlJogadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlJogadores.Controls.Add(this.dgvListarJogadores);
            this.pnlJogadores.Location = new System.Drawing.Point(544, 27);
            this.pnlJogadores.Name = "pnlJogadores";
            this.pnlJogadores.Size = new System.Drawing.Size(371, 359);
            this.pnlJogadores.TabIndex = 8;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Teste.Properties.Resources.bg_lobby;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnlJogadores);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.btnListarJogadores);
            this.DoubleBuffered = true;
            this.Name = "Lobby";
            this.Size = new System.Drawing.Size(964, 544);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarJogadores)).EndInit();
            this.pnlJogadores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.DataGridView dgvListarJogadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.Panel pnlJogadores;
    }
}
