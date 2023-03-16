namespace Teste
{
    partial class frmLobby
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListGames = new System.Windows.Forms.Button();
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radTodos = new System.Windows.Forms.RadioButton();
            this.radAbertas = new System.Windows.Forms.RadioButton();
            this.radJogando = new System.Windows.Forms.RadioButton();
            this.radEncerradas = new System.Windows.Forms.RadioButton();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.grbEntrarPartida = new System.Windows.Forms.GroupBox();
            this.grbCriarPartida = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            this.grbStatus.SuspendLayout();
            this.grbEntrarPartida.SuspendLayout();
            this.grbCriarPartida.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListGames
            // 
            this.btnListGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListGames.Location = new System.Drawing.Point(346, 12);
            this.btnListGames.Name = "btnListGames";
            this.btnListGames.Size = new System.Drawing.Size(151, 44);
            this.btnListGames.TabIndex = 0;
            this.btnListGames.Text = "Listar";
            this.btnListGames.UseVisualStyleBackColor = true;
            this.btnListGames.Click += new System.EventHandler(this.btnListGames_Click);
            // 
            // dgvGames
            // 
            this.dgvGames.AllowUserToAddRows = false;
            this.dgvGames.AllowUserToDeleteRows = false;
            this.dgvGames.AllowUserToResizeColumns = false;
            this.dgvGames.AllowUserToResizeRows = false;
            this.dgvGames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGames.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvGames.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.date,
            this.status});
            this.dgvGames.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvGames.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGames.Location = new System.Drawing.Point(0, 0);
            this.dgvGames.MultiSelect = false;
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.ReadOnly = true;
            this.dgvGames.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGames.Size = new System.Drawing.Size(340, 450);
            this.dgvGames.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nome";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Data";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // radTodos
            // 
            this.radTodos.AutoSize = true;
            this.radTodos.Checked = true;
            this.radTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTodos.Location = new System.Drawing.Point(19, 30);
            this.radTodos.Name = "radTodos";
            this.radTodos.Size = new System.Drawing.Size(71, 24);
            this.radTodos.TabIndex = 3;
            this.radTodos.TabStop = true;
            this.radTodos.Text = "Todos";
            this.radTodos.UseVisualStyleBackColor = true;
            // 
            // radAbertas
            // 
            this.radAbertas.AutoSize = true;
            this.radAbertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAbertas.Location = new System.Drawing.Point(19, 60);
            this.radAbertas.Name = "radAbertas";
            this.radAbertas.Size = new System.Drawing.Size(83, 24);
            this.radAbertas.TabIndex = 4;
            this.radAbertas.Text = "Abertas";
            this.radAbertas.UseVisualStyleBackColor = true;
            // 
            // radJogando
            // 
            this.radJogando.AutoSize = true;
            this.radJogando.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radJogando.Location = new System.Drawing.Point(19, 90);
            this.radJogando.Name = "radJogando";
            this.radJogando.Size = new System.Drawing.Size(89, 24);
            this.radJogando.TabIndex = 5;
            this.radJogando.Text = "Jogando";
            this.radJogando.UseVisualStyleBackColor = true;
            // 
            // radEncerradas
            // 
            this.radEncerradas.AutoSize = true;
            this.radEncerradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEncerradas.Location = new System.Drawing.Point(19, 120);
            this.radEncerradas.Name = "radEncerradas";
            this.radEncerradas.Size = new System.Drawing.Size(109, 24);
            this.radEncerradas.TabIndex = 6;
            this.radEncerradas.Text = "Encerradas";
            this.radEncerradas.UseVisualStyleBackColor = true;
            // 
            // grbStatus
            // 
            this.grbStatus.Controls.Add(this.radEncerradas);
            this.grbStatus.Controls.Add(this.radJogando);
            this.grbStatus.Controls.Add(this.radAbertas);
            this.grbStatus.Controls.Add(this.radTodos);
            this.grbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStatus.Location = new System.Drawing.Point(346, 62);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(151, 157);
            this.grbStatus.TabIndex = 7;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "Status Partida";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(15, 35);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(149, 20);
            this.txtNomePartida.TabIndex = 8;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(15, 72);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(149, 20);
            this.txtSenhaPartida.TabIndex = 9;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPartida.Location = new System.Drawing.Point(15, 98);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(149, 44);
            this.btnCriarPartida.TabIndex = 10;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(13, 19);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(71, 13);
            this.lblNomePartida.TabIndex = 11;
            this.lblNomePartida.Text = "Nome Partida";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Location = new System.Drawing.Point(13, 58);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaPartida.TabIndex = 12;
            this.lblSenhaPartida.Text = "Senha";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(13, 32);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(149, 20);
            this.txtNomeJogador.TabIndex = 13;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(13, 71);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(149, 20);
            this.txtSenha.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome Jogador";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(10, 55);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 16;
            this.lblSenha.Text = "Senha";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarPartida.Location = new System.Drawing.Point(13, 106);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(149, 44);
            this.btnEntrarPartida.TabIndex = 17;
            this.btnEntrarPartida.Text = "Entrar";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // grbEntrarPartida
            // 
            this.grbEntrarPartida.Controls.Add(this.btnEntrarPartida);
            this.grbEntrarPartida.Controls.Add(this.lblSenha);
            this.grbEntrarPartida.Controls.Add(this.label1);
            this.grbEntrarPartida.Controls.Add(this.txtSenha);
            this.grbEntrarPartida.Controls.Add(this.txtNomeJogador);
            this.grbEntrarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEntrarPartida.Location = new System.Drawing.Point(552, 49);
            this.grbEntrarPartida.Name = "grbEntrarPartida";
            this.grbEntrarPartida.Size = new System.Drawing.Size(180, 170);
            this.grbEntrarPartida.TabIndex = 18;
            this.grbEntrarPartida.TabStop = false;
            this.grbEntrarPartida.Text = "Entrar na Partida";
            // 
            // grbCriarPartida
            // 
            this.grbCriarPartida.Controls.Add(this.lblSenhaPartida);
            this.grbCriarPartida.Controls.Add(this.lblNomePartida);
            this.grbCriarPartida.Controls.Add(this.btnCriarPartida);
            this.grbCriarPartida.Controls.Add(this.txtSenhaPartida);
            this.grbCriarPartida.Controls.Add(this.txtNomePartida);
            this.grbCriarPartida.Location = new System.Drawing.Point(346, 241);
            this.grbCriarPartida.Name = "grbCriarPartida";
            this.grbCriarPartida.Size = new System.Drawing.Size(182, 160);
            this.grbCriarPartida.TabIndex = 19;
            this.grbCriarPartida.TabStop = false;
            this.grbCriarPartida.Text = "Criar uma Partida";
            // 
            // frmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbCriarPartida);
            this.Controls.Add(this.grbEntrarPartida);
            this.Controls.Add(this.grbStatus);
            this.Controls.Add(this.dgvGames);
            this.Controls.Add(this.btnListGames);
            this.Name = "frmLobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            this.grbEntrarPartida.ResumeLayout(false);
            this.grbEntrarPartida.PerformLayout();
            this.grbCriarPartida.ResumeLayout(false);
            this.grbCriarPartida.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListGames;
        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.RadioButton radTodos;
        private System.Windows.Forms.RadioButton radAbertas;
        private System.Windows.Forms.RadioButton radJogando;
        private System.Windows.Forms.RadioButton radEncerradas;
        private System.Windows.Forms.GroupBox grbStatus;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.GroupBox grbEntrarPartida;
        private System.Windows.Forms.GroupBox grbCriarPartida;
    }
}

