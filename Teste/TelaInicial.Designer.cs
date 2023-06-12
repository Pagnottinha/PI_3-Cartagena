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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.cboFiltros = new System.Windows.Forms.ComboBox();
            this.txtNomeJogadorCriar = new System.Windows.Forms.TextBox();
            this.chkEntrar = new System.Windows.Forms.CheckBox();
            this.lblSenhaCriar = new System.Windows.Forms.Label();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.txtSenhaCriar = new System.Windows.Forms.TextBox();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.lblSenhaEntrar = new System.Windows.Forms.Label();
            this.lblNomeJogadorEntrar = new System.Windows.Forms.Label();
            this.txtSenhaEntrar = new System.Windows.Forms.TextBox();
            this.txtNomeJogadorEntrar = new System.Windows.Forms.TextBox();
            this.dgvListaPartidas = new System.Windows.Forms.DataGridView();
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.btnAssistirPartida = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCriarPartida = new System.Windows.Forms.Panel();
            this.lblNomeJogadorCriar = new System.Windows.Forms.Label();
            this.pnlEntrarPartida = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPartidas)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlCriarPartida.SuspendLayout();
            this.pnlEntrarPartida.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(192)))), ((int)(((byte)(177)))));
            this.lblFiltros.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFiltros.Location = new System.Drawing.Point(566, 19);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(82, 29);
            this.lblFiltros.TabIndex = 25;
            this.lblFiltros.Text = "Status";
            // 
            // cboFiltros
            // 
            this.cboFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltros.DropDownWidth = 130;
            this.cboFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboFiltros.FormattingEnabled = true;
            this.cboFiltros.Items.AddRange(new object[] {
            "Todos",
            "Abertas",
            "Jogando",
            "Encerradas"});
            this.cboFiltros.Location = new System.Drawing.Point(571, 51);
            this.cboFiltros.Name = "cboFiltros";
            this.cboFiltros.Size = new System.Drawing.Size(129, 28);
            this.cboFiltros.TabIndex = 26;
            // 
            // txtNomeJogadorCriar
            // 
            this.txtNomeJogadorCriar.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomeJogadorCriar.Enabled = false;
            this.txtNomeJogadorCriar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeJogadorCriar.Location = new System.Drawing.Point(38, 241);
            this.txtNomeJogadorCriar.Name = "txtNomeJogadorCriar";
            this.txtNomeJogadorCriar.Size = new System.Drawing.Size(176, 27);
            this.txtNomeJogadorCriar.TabIndex = 18;
            // 
            // chkEntrar
            // 
            this.chkEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkEntrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkEntrar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEntrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkEntrar.Location = new System.Drawing.Point(38, 166);
            this.chkEntrar.Name = "chkEntrar";
            this.chkEntrar.Size = new System.Drawing.Size(176, 48);
            this.chkEntrar.TabIndex = 13;
            this.chkEntrar.Text = "Deseja entrar automaticamente?";
            this.chkEntrar.UseVisualStyleBackColor = true;
            this.chkEntrar.CheckedChanged += new System.EventHandler(this.chkEntrar_CheckedChanged);
            // 
            // lblSenhaCriar
            // 
            this.lblSenhaCriar.AutoSize = true;
            this.lblSenhaCriar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaCriar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSenhaCriar.Location = new System.Drawing.Point(33, 105);
            this.lblSenhaCriar.Name = "lblSenhaCriar";
            this.lblSenhaCriar.Size = new System.Drawing.Size(71, 25);
            this.lblSenhaCriar.TabIndex = 12;
            this.lblSenhaCriar.Text = "Senha";
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNomePartida.Location = new System.Drawing.Point(33, 42);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(139, 25);
            this.lblNomePartida.TabIndex = 11;
            this.lblNomePartida.Text = "Nome Partida";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackgroundImage = global::Teste.Properties.Resources.btn_criarPartida;
            this.btnCriarPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCriarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarPartida.FlatAppearance.BorderSize = 0;
            this.btnCriarPartida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCriarPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCriarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnCriarPartida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCriarPartida.Location = new System.Drawing.Point(34, 278);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(180, 57);
            this.btnCriarPartida.TabIndex = 10;
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // txtSenhaCriar
            // 
            this.txtSenhaCriar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCriar.Location = new System.Drawing.Point(38, 133);
            this.txtSenhaCriar.Name = "txtSenhaCriar";
            this.txtSenhaCriar.Size = new System.Drawing.Size(176, 27);
            this.txtSenhaCriar.TabIndex = 9;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePartida.Location = new System.Drawing.Point(38, 70);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(176, 27);
            this.txtNomePartida.TabIndex = 8;
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackgroundImage = global::Teste.Properties.Resources.btn_entrar;
            this.btnEntrarPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntrarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrarPartida.FlatAppearance.BorderSize = 0;
            this.btnEntrarPartida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEntrarPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEntrarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnEntrarPartida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEntrarPartida.Location = new System.Drawing.Point(39, 203);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(173, 44);
            this.btnEntrarPartida.TabIndex = 17;
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // lblSenhaEntrar
            // 
            this.lblSenhaEntrar.AutoSize = true;
            this.lblSenhaEntrar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaEntrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSenhaEntrar.Location = new System.Drawing.Point(34, 116);
            this.lblSenhaEntrar.Name = "lblSenhaEntrar";
            this.lblSenhaEntrar.Size = new System.Drawing.Size(71, 25);
            this.lblSenhaEntrar.TabIndex = 16;
            this.lblSenhaEntrar.Text = "Senha";
            // 
            // lblNomeJogadorEntrar
            // 
            this.lblNomeJogadorEntrar.AutoSize = true;
            this.lblNomeJogadorEntrar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogadorEntrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNomeJogadorEntrar.Location = new System.Drawing.Point(34, 54);
            this.lblNomeJogadorEntrar.Name = "lblNomeJogadorEntrar";
            this.lblNomeJogadorEntrar.Size = new System.Drawing.Size(148, 25);
            this.lblNomeJogadorEntrar.TabIndex = 15;
            this.lblNomeJogadorEntrar.Text = "Nome Jogador";
            // 
            // txtSenhaEntrar
            // 
            this.txtSenhaEntrar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaEntrar.Location = new System.Drawing.Point(39, 144);
            this.txtSenhaEntrar.Name = "txtSenhaEntrar";
            this.txtSenhaEntrar.Size = new System.Drawing.Size(173, 27);
            this.txtSenhaEntrar.TabIndex = 14;
            // 
            // txtNomeJogadorEntrar
            // 
            this.txtNomeJogadorEntrar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeJogadorEntrar.Location = new System.Drawing.Point(39, 82);
            this.txtNomeJogadorEntrar.Name = "txtNomeJogadorEntrar";
            this.txtNomeJogadorEntrar.Size = new System.Drawing.Size(173, 27);
            this.txtNomeJogadorEntrar.TabIndex = 13;
            // 
            // dgvListaPartidas
            // 
            this.dgvListaPartidas.AllowUserToAddRows = false;
            this.dgvListaPartidas.AllowUserToDeleteRows = false;
            this.dgvListaPartidas.AllowUserToResizeColumns = false;
            this.dgvListaPartidas.AllowUserToResizeRows = false;
            this.dgvListaPartidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaPartidas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaPartidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(192)))), ((int)(((byte)(177)))));
            this.dgvListaPartidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaPartidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListaPartidas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvListaPartidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(152)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(152)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaPartidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.data,
            this.status});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(192)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(176)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaPartidas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListaPartidas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaPartidas.EnableHeadersVisualStyles = false;
            this.dgvListaPartidas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(192)))), ((int)(((byte)(177)))));
            this.dgvListaPartidas.Location = new System.Drawing.Point(18, 53);
            this.dgvListaPartidas.MultiSelect = false;
            this.dgvListaPartidas.Name = "dgvListaPartidas";
            this.dgvListaPartidas.ReadOnly = true;
            this.dgvListaPartidas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListaPartidas.RowHeadersVisible = false;
            this.dgvListaPartidas.RowTemplate.Height = 30;
            this.dgvListaPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPartidas.Size = new System.Drawing.Size(280, 378);
            this.dgvListaPartidas.TabIndex = 22;
            this.dgvListaPartidas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaPartidas_CellFormatting);
            this.dgvListaPartidas.Click += new System.EventHandler(this.dgvListaPartidas_Click);
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.BackgroundImage = global::Teste.Properties.Resources.btn_listar;
            this.btnListarPartidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListarPartidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarPartidas.FlatAppearance.BorderSize = 0;
            this.btnListarPartidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnListarPartidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnListarPartidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnListarPartidas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListarPartidas.Location = new System.Drawing.Point(399, 35);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(151, 44);
            this.btnListarPartidas.TabIndex = 21;
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListGames_Click);
            // 
            // btnAssistirPartida
            // 
            this.btnAssistirPartida.BackgroundImage = global::Teste.Properties.Resources.btn_assistirPartida;
            this.btnAssistirPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAssistirPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssistirPartida.FlatAppearance.BorderSize = 0;
            this.btnAssistirPartida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAssistirPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAssistirPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssistirPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssistirPartida.Location = new System.Drawing.Point(105, 496);
            this.btnAssistirPartida.Name = "btnAssistirPartida";
            this.btnAssistirPartida.Size = new System.Drawing.Size(179, 54);
            this.btnAssistirPartida.TabIndex = 27;
            this.btnAssistirPartida.UseVisualStyleBackColor = true;
            this.btnAssistirPartida.Click += new System.EventHandler(this.btnAssistirPartida_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Teste.Properties.Resources.partidas;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dgvListaPartidas);
            this.panel1.Location = new System.Drawing.Point(42, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 448);
            this.panel1.TabIndex = 28;
            // 
            // pnlCriarPartida
            // 
            this.pnlCriarPartida.BackgroundImage = global::Teste.Properties.Resources.criarPartida;
            this.pnlCriarPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCriarPartida.Controls.Add(this.lblNomeJogadorCriar);
            this.pnlCriarPartida.Controls.Add(this.btnCriarPartida);
            this.pnlCriarPartida.Controls.Add(this.txtNomeJogadorCriar);
            this.pnlCriarPartida.Controls.Add(this.txtNomePartida);
            this.pnlCriarPartida.Controls.Add(this.chkEntrar);
            this.pnlCriarPartida.Controls.Add(this.txtSenhaCriar);
            this.pnlCriarPartida.Controls.Add(this.lblSenhaCriar);
            this.pnlCriarPartida.Controls.Add(this.lblNomePartida);
            this.pnlCriarPartida.Location = new System.Drawing.Point(399, 127);
            this.pnlCriarPartida.Name = "pnlCriarPartida";
            this.pnlCriarPartida.Size = new System.Drawing.Size(254, 356);
            this.pnlCriarPartida.TabIndex = 29;
            // 
            // lblNomeJogadorCriar
            // 
            this.lblNomeJogadorCriar.AutoSize = true;
            this.lblNomeJogadorCriar.Enabled = false;
            this.lblNomeJogadorCriar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogadorCriar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNomeJogadorCriar.Location = new System.Drawing.Point(33, 213);
            this.lblNomeJogadorCriar.Name = "lblNomeJogadorCriar";
            this.lblNomeJogadorCriar.Size = new System.Drawing.Size(148, 25);
            this.lblNomeJogadorCriar.TabIndex = 19;
            this.lblNomeJogadorCriar.Text = "Nome Jogador";
            // 
            // pnlEntrarPartida
            // 
            this.pnlEntrarPartida.BackgroundImage = global::Teste.Properties.Resources.Entrar_em_uma_partida;
            this.pnlEntrarPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEntrarPartida.Controls.Add(this.btnEntrarPartida);
            this.pnlEntrarPartida.Controls.Add(this.lblSenhaEntrar);
            this.pnlEntrarPartida.Controls.Add(this.txtNomeJogadorEntrar);
            this.pnlEntrarPartida.Controls.Add(this.lblNomeJogadorEntrar);
            this.pnlEntrarPartida.Controls.Add(this.txtSenhaEntrar);
            this.pnlEntrarPartida.Location = new System.Drawing.Point(690, 208);
            this.pnlEntrarPartida.Name = "pnlEntrarPartida";
            this.pnlEntrarPartida.Size = new System.Drawing.Size(257, 275);
            this.pnlEntrarPartida.TabIndex = 30;
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
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Teste.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnlEntrarPartida);
            this.Controls.Add(this.pnlCriarPartida);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAssistirPartida);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.cboFiltros);
            this.Controls.Add(this.btnListarPartidas);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "TelaInicial";
            this.Size = new System.Drawing.Size(985, 573);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPartidas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlCriarPartida.ResumeLayout(false);
            this.pnlCriarPartida.PerformLayout();
            this.pnlEntrarPartida.ResumeLayout(false);
            this.pnlEntrarPartida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.ComboBox cboFiltros;
        private System.Windows.Forms.TextBox txtNomeJogadorCriar;
        private System.Windows.Forms.CheckBox chkEntrar;
        private System.Windows.Forms.Label lblSenhaCriar;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.TextBox txtSenhaCriar;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Label lblSenhaEntrar;
        private System.Windows.Forms.Label lblNomeJogadorEntrar;
        private System.Windows.Forms.TextBox txtSenhaEntrar;
        private System.Windows.Forms.TextBox txtNomeJogadorEntrar;
        private System.Windows.Forms.DataGridView dgvListaPartidas;
        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.Button btnAssistirPartida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCriarPartida;
        private System.Windows.Forms.Panel pnlEntrarPartida;
        private System.Windows.Forms.Label lblNomeJogadorCriar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}
