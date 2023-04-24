namespace Teste
{
    partial class TelaInicial
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
            this.lblFiltros = new System.Windows.Forms.Label();
            this.cboFiltros = new System.Windows.Forms.ComboBox();
            this.grbCriarPartida = new System.Windows.Forms.GroupBox();
            this.lblNomeJogadorCriar = new System.Windows.Forms.Label();
            this.txtNomeJogadorCriar = new System.Windows.Forms.TextBox();
            this.chkEntrar = new System.Windows.Forms.CheckBox();
            this.lblSenhaCriar = new System.Windows.Forms.Label();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.txtSenhaCriar = new System.Windows.Forms.TextBox();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.grbEntrarPartida = new System.Windows.Forms.GroupBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.lblSenhaEntrar = new System.Windows.Forms.Label();
            this.lblNomeJogadorEntrar = new System.Windows.Forms.Label();
            this.txtSenhaEntrar = new System.Windows.Forms.TextBox();
            this.txtNomeJogadorEntrar = new System.Windows.Forms.TextBox();
            this.dgvListaPartidas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.grbCriarPartida.SuspendLayout();
            this.grbEntrarPartida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblFiltros.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFiltros.Location = new System.Drawing.Point(500, 12);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(44, 16);
            this.lblFiltros.TabIndex = 25;
            this.lblFiltros.Text = "Status";
            // 
            // cboFiltros
            // 
            this.cboFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltros.DropDownWidth = 130;
            this.cboFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboFiltros.FormattingEnabled = true;
            this.cboFiltros.Items.AddRange(new object[] {
            "Todos",
            "Abertas",
            "Jogando",
            "Encerradas"});
            this.cboFiltros.Location = new System.Drawing.Point(503, 28);
            this.cboFiltros.Name = "cboFiltros";
            this.cboFiltros.Size = new System.Drawing.Size(129, 28);
            this.cboFiltros.TabIndex = 26;
            // 
            // grbCriarPartida
            // 
            this.grbCriarPartida.Controls.Add(this.lblNomeJogadorCriar);
            this.grbCriarPartida.Controls.Add(this.txtNomeJogadorCriar);
            this.grbCriarPartida.Controls.Add(this.chkEntrar);
            this.grbCriarPartida.Controls.Add(this.lblSenhaCriar);
            this.grbCriarPartida.Controls.Add(this.lblNomePartida);
            this.grbCriarPartida.Controls.Add(this.btnCriarPartida);
            this.grbCriarPartida.Controls.Add(this.txtSenhaCriar);
            this.grbCriarPartida.Controls.Add(this.txtNomePartida);
            this.grbCriarPartida.Location = new System.Drawing.Point(346, 117);
            this.grbCriarPartida.Name = "grbCriarPartida";
            this.grbCriarPartida.Size = new System.Drawing.Size(207, 237);
            this.grbCriarPartida.TabIndex = 24;
            this.grbCriarPartida.TabStop = false;
            this.grbCriarPartida.Text = "Criar uma Partida";
            // 
            // lblNomeJogadorCriar
            // 
            this.lblNomeJogadorCriar.AutoSize = true;
            this.lblNomeJogadorCriar.Enabled = false;
            this.lblNomeJogadorCriar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNomeJogadorCriar.Location = new System.Drawing.Point(13, 127);
            this.lblNomeJogadorCriar.Name = "lblNomeJogadorCriar";
            this.lblNomeJogadorCriar.Size = new System.Drawing.Size(76, 13);
            this.lblNomeJogadorCriar.TabIndex = 19;
            this.lblNomeJogadorCriar.Text = "Nome Jogador";
            // 
            // txtNomeJogadorCriar
            // 
            this.txtNomeJogadorCriar.Enabled = false;
            this.txtNomeJogadorCriar.Location = new System.Drawing.Point(15, 143);
            this.txtNomeJogadorCriar.Name = "txtNomeJogadorCriar";
            this.txtNomeJogadorCriar.Size = new System.Drawing.Size(176, 20);
            this.txtNomeJogadorCriar.TabIndex = 18;
            // 
            // chkEntrar
            // 
            this.chkEntrar.AutoSize = true;
            this.chkEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkEntrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkEntrar.Location = new System.Drawing.Point(15, 107);
            this.chkEntrar.Name = "chkEntrar";
            this.chkEntrar.Size = new System.Drawing.Size(179, 17);
            this.chkEntrar.TabIndex = 13;
            this.chkEntrar.Text = "Deseja entrar automaticamente?";
            this.chkEntrar.UseVisualStyleBackColor = true;
            this.chkEntrar.Click += new System.EventHandler(this.chkEntrar_CheckedChanged);
            // 
            // lblSenhaCriar
            // 
            this.lblSenhaCriar.AutoSize = true;
            this.lblSenhaCriar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSenhaCriar.Location = new System.Drawing.Point(13, 65);
            this.lblSenhaCriar.Name = "lblSenhaCriar";
            this.lblSenhaCriar.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaCriar.TabIndex = 12;
            this.lblSenhaCriar.Text = "Senha";
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNomePartida.Location = new System.Drawing.Point(13, 19);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(71, 13);
            this.lblNomePartida.TabIndex = 11;
            this.lblNomePartida.Text = "Nome Partida";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnCriarPartida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCriarPartida.Location = new System.Drawing.Point(15, 179);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(176, 44);
            this.btnCriarPartida.TabIndex = 10;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // txtSenhaCriar
            // 
            this.txtSenhaCriar.Location = new System.Drawing.Point(15, 81);
            this.txtSenhaCriar.Name = "txtSenhaCriar";
            this.txtSenhaCriar.Size = new System.Drawing.Size(176, 20);
            this.txtSenhaCriar.TabIndex = 9;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(15, 35);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(176, 20);
            this.txtNomePartida.TabIndex = 8;
            // 
            // grbEntrarPartida
            // 
            this.grbEntrarPartida.Controls.Add(this.btnEntrarPartida);
            this.grbEntrarPartida.Controls.Add(this.lblSenhaEntrar);
            this.grbEntrarPartida.Controls.Add(this.lblNomeJogadorEntrar);
            this.grbEntrarPartida.Controls.Add(this.txtSenhaEntrar);
            this.grbEntrarPartida.Controls.Add(this.txtNomeJogadorEntrar);
            this.grbEntrarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grbEntrarPartida.Location = new System.Drawing.Point(569, 139);
            this.grbEntrarPartida.Name = "grbEntrarPartida";
            this.grbEntrarPartida.Size = new System.Drawing.Size(192, 188);
            this.grbEntrarPartida.TabIndex = 23;
            this.grbEntrarPartida.TabStop = false;
            this.grbEntrarPartida.Text = "Entrar na Partida";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnEntrarPartida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEntrarPartida.Location = new System.Drawing.Point(13, 129);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(173, 44);
            this.btnEntrarPartida.TabIndex = 17;
            this.btnEntrarPartida.Text = "Entrar";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // lblSenhaEntrar
            // 
            this.lblSenhaEntrar.AutoSize = true;
            this.lblSenhaEntrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSenhaEntrar.Location = new System.Drawing.Point(10, 72);
            this.lblSenhaEntrar.Name = "lblSenhaEntrar";
            this.lblSenhaEntrar.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaEntrar.TabIndex = 16;
            this.lblSenhaEntrar.Text = "Senha";
            // 
            // lblNomeJogadorEntrar
            // 
            this.lblNomeJogadorEntrar.AutoSize = true;
            this.lblNomeJogadorEntrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNomeJogadorEntrar.Location = new System.Drawing.Point(10, 26);
            this.lblNomeJogadorEntrar.Name = "lblNomeJogadorEntrar";
            this.lblNomeJogadorEntrar.Size = new System.Drawing.Size(76, 13);
            this.lblNomeJogadorEntrar.TabIndex = 15;
            this.lblNomeJogadorEntrar.Text = "Nome Jogador";
            // 
            // txtSenhaEntrar
            // 
            this.txtSenhaEntrar.Location = new System.Drawing.Point(13, 92);
            this.txtSenhaEntrar.Name = "txtSenhaEntrar";
            this.txtSenhaEntrar.Size = new System.Drawing.Size(173, 20);
            this.txtSenhaEntrar.TabIndex = 14;
            // 
            // txtNomeJogadorEntrar
            // 
            this.txtNomeJogadorEntrar.Location = new System.Drawing.Point(13, 42);
            this.txtNomeJogadorEntrar.Name = "txtNomeJogadorEntrar";
            this.txtNomeJogadorEntrar.Size = new System.Drawing.Size(173, 20);
            this.txtNomeJogadorEntrar.TabIndex = 13;
            // 
            // dgvListaPartidas
            // 
            this.dgvListaPartidas.AllowUserToAddRows = false;
            this.dgvListaPartidas.AllowUserToDeleteRows = false;
            this.dgvListaPartidas.AllowUserToResizeColumns = false;
            this.dgvListaPartidas.AllowUserToResizeRows = false;
            this.dgvListaPartidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaPartidas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListaPartidas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvListaPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.data,
            this.status});
            this.dgvListaPartidas.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvListaPartidas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaPartidas.Location = new System.Drawing.Point(0, 0);
            this.dgvListaPartidas.MultiSelect = false;
            this.dgvListaPartidas.Name = "dgvListaPartidas";
            this.dgvListaPartidas.ReadOnly = true;
            this.dgvListaPartidas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPartidas.Size = new System.Drawing.Size(340, 446);
            this.dgvListaPartidas.TabIndex = 22;
            this.dgvListaPartidas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaPartidas_CellFormatting);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnListarPartidas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListarPartidas.Location = new System.Drawing.Point(346, 12);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(151, 44);
            this.btnListarPartidas.TabIndex = 21;
            this.btnListarPartidas.Text = "Listar";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListGames_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.cboFiltros);
            this.Controls.Add(this.grbCriarPartida);
            this.Controls.Add(this.grbEntrarPartida);
            this.Controls.Add(this.dgvListaPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.Name = "TelaInicial";
            this.Size = new System.Drawing.Size(791, 446);
            this.grbCriarPartida.ResumeLayout(false);
            this.grbCriarPartida.PerformLayout();
            this.grbEntrarPartida.ResumeLayout(false);
            this.grbEntrarPartida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPartidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.ComboBox cboFiltros;
        private System.Windows.Forms.GroupBox grbCriarPartida;
        private System.Windows.Forms.Label lblNomeJogadorCriar;
        private System.Windows.Forms.TextBox txtNomeJogadorCriar;
        private System.Windows.Forms.CheckBox chkEntrar;
        private System.Windows.Forms.Label lblSenhaCriar;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.TextBox txtSenhaCriar;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.GroupBox grbEntrarPartida;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Label lblSenhaEntrar;
        private System.Windows.Forms.Label lblNomeJogadorEntrar;
        private System.Windows.Forms.TextBox txtSenhaEntrar;
        private System.Windows.Forms.TextBox txtNomeJogadorEntrar;
        private System.Windows.Forms.DataGridView dgvListaPartidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button btnListarPartidas;
    }
}
