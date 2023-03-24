namespace Teste
{
    partial class frmEntrarNaPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntrarNaPartida));
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.dgvListaPartidas = new System.Windows.Forms.DataGridView();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.txtSenhaCriar = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblSenhaCriar = new System.Windows.Forms.Label();
            this.txtNomeJogadorEntrar = new System.Windows.Forms.TextBox();
            this.txtSenhaEntrar = new System.Windows.Forms.TextBox();
            this.lblNomeJogadorEntrar = new System.Windows.Forms.Label();
            this.lblSenhaEntrar = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.grbEntrarPartida = new System.Windows.Forms.GroupBox();
            this.grbCriarPartida = new System.Windows.Forms.GroupBox();
            this.lblNomeJogadorCriar = new System.Windows.Forms.Label();
            this.txtNomeJogadorCriar = new System.Windows.Forms.TextBox();
            this.chkEntrar = new System.Windows.Forms.CheckBox();
            this.cboFiltros = new System.Windows.Forms.ComboBox();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPartidas)).BeginInit();
            this.grbEntrarPartida.SuspendLayout();
            this.grbCriarPartida.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            resources.ApplyResources(this.btnListarPartidas, "btnListarPartidas");
            this.btnListarPartidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListGames_Click);
            // 
            // dgvListaPartidas
            // 
            resources.ApplyResources(this.dgvListaPartidas, "dgvListaPartidas");
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
            this.dgvListaPartidas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaPartidas.MultiSelect = false;
            this.dgvListaPartidas.Name = "dgvListaPartidas";
            this.dgvListaPartidas.ReadOnly = true;
            this.dgvListaPartidas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPartidas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaPartidas_CellFormatting);
            // 
            // txtNomePartida
            // 
            resources.ApplyResources(this.txtNomePartida, "txtNomePartida");
            this.txtNomePartida.Name = "txtNomePartida";
            // 
            // txtSenhaCriar
            // 
            resources.ApplyResources(this.txtSenhaCriar, "txtSenhaCriar");
            this.txtSenhaCriar.Name = "txtSenhaCriar";
            // 
            // btnCriarPartida
            // 
            resources.ApplyResources(this.btnCriarPartida, "btnCriarPartida");
            this.btnCriarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lblNomePartida
            // 
            resources.ApplyResources(this.lblNomePartida, "lblNomePartida");
            this.lblNomePartida.Name = "lblNomePartida";
            // 
            // lblSenhaCriar
            // 
            resources.ApplyResources(this.lblSenhaCriar, "lblSenhaCriar");
            this.lblSenhaCriar.Name = "lblSenhaCriar";
            // 
            // txtNomeJogadorEntrar
            // 
            resources.ApplyResources(this.txtNomeJogadorEntrar, "txtNomeJogadorEntrar");
            this.txtNomeJogadorEntrar.Name = "txtNomeJogadorEntrar";
            // 
            // txtSenhaEntrar
            // 
            resources.ApplyResources(this.txtSenhaEntrar, "txtSenhaEntrar");
            this.txtSenhaEntrar.Name = "txtSenhaEntrar";
            // 
            // lblNomeJogadorEntrar
            // 
            resources.ApplyResources(this.lblNomeJogadorEntrar, "lblNomeJogadorEntrar");
            this.lblNomeJogadorEntrar.Name = "lblNomeJogadorEntrar";
            // 
            // lblSenhaEntrar
            // 
            resources.ApplyResources(this.lblSenhaEntrar, "lblSenhaEntrar");
            this.lblSenhaEntrar.Name = "lblSenhaEntrar";
            // 
            // btnEntrarPartida
            // 
            resources.ApplyResources(this.btnEntrarPartida, "btnEntrarPartida");
            this.btnEntrarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // grbEntrarPartida
            // 
            resources.ApplyResources(this.grbEntrarPartida, "grbEntrarPartida");
            this.grbEntrarPartida.Controls.Add(this.btnEntrarPartida);
            this.grbEntrarPartida.Controls.Add(this.lblSenhaEntrar);
            this.grbEntrarPartida.Controls.Add(this.lblNomeJogadorEntrar);
            this.grbEntrarPartida.Controls.Add(this.txtSenhaEntrar);
            this.grbEntrarPartida.Controls.Add(this.txtNomeJogadorEntrar);
            this.grbEntrarPartida.Name = "grbEntrarPartida";
            this.grbEntrarPartida.TabStop = false;
            // 
            // grbCriarPartida
            // 
            resources.ApplyResources(this.grbCriarPartida, "grbCriarPartida");
            this.grbCriarPartida.Controls.Add(this.lblNomeJogadorCriar);
            this.grbCriarPartida.Controls.Add(this.txtNomeJogadorCriar);
            this.grbCriarPartida.Controls.Add(this.chkEntrar);
            this.grbCriarPartida.Controls.Add(this.lblSenhaCriar);
            this.grbCriarPartida.Controls.Add(this.lblNomePartida);
            this.grbCriarPartida.Controls.Add(this.btnCriarPartida);
            this.grbCriarPartida.Controls.Add(this.txtSenhaCriar);
            this.grbCriarPartida.Controls.Add(this.txtNomePartida);
            this.grbCriarPartida.Name = "grbCriarPartida";
            this.grbCriarPartida.TabStop = false;
            // 
            // lblNomeJogadorCriar
            // 
            resources.ApplyResources(this.lblNomeJogadorCriar, "lblNomeJogadorCriar");
            this.lblNomeJogadorCriar.Name = "lblNomeJogadorCriar";
            // 
            // txtNomeJogadorCriar
            // 
            resources.ApplyResources(this.txtNomeJogadorCriar, "txtNomeJogadorCriar");
            this.txtNomeJogadorCriar.Name = "txtNomeJogadorCriar";
            // 
            // chkEntrar
            // 
            resources.ApplyResources(this.chkEntrar, "chkEntrar");
            this.chkEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkEntrar.Name = "chkEntrar";
            this.chkEntrar.UseVisualStyleBackColor = true;
            this.chkEntrar.CheckedChanged += new System.EventHandler(this.chkEntrar_CheckedChanged);
            // 
            // cboFiltros
            // 
            resources.ApplyResources(this.cboFiltros, "cboFiltros");
            this.cboFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltros.DropDownWidth = 130;
            this.cboFiltros.FormattingEnabled = true;
            this.cboFiltros.Items.AddRange(new object[] {
            resources.GetString("cboFiltros.Items"),
            resources.GetString("cboFiltros.Items1"),
            resources.GetString("cboFiltros.Items2"),
            resources.GetString("cboFiltros.Items3")});
            this.cboFiltros.Name = "cboFiltros";
            // 
            // lblFiltros
            // 
            resources.ApplyResources(this.lblFiltros, "lblFiltros");
            this.lblFiltros.Name = "lblFiltros";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            resources.ApplyResources(this.nome, "nome");
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            resources.ApplyResources(this.data, "data");
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            resources.ApplyResources(this.status, "status");
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // frmEntrarNaPartida
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.cboFiltros);
            this.Controls.Add(this.grbCriarPartida);
            this.Controls.Add(this.grbEntrarPartida);
            this.Controls.Add(this.dgvListaPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.Name = "frmEntrarNaPartida";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPartidas)).EndInit();
            this.grbEntrarPartida.ResumeLayout(false);
            this.grbEntrarPartida.PerformLayout();
            this.grbCriarPartida.ResumeLayout(false);
            this.grbCriarPartida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.DataGridView dgvListaPartidas;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.TextBox txtSenhaCriar;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblSenhaCriar;
        private System.Windows.Forms.TextBox txtNomeJogadorEntrar;
        private System.Windows.Forms.TextBox txtSenhaEntrar;
        private System.Windows.Forms.Label lblNomeJogadorEntrar;
        private System.Windows.Forms.Label lblSenhaEntrar;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.GroupBox grbEntrarPartida;
        private System.Windows.Forms.GroupBox grbCriarPartida;
        private System.Windows.Forms.ComboBox cboFiltros;
        private System.Windows.Forms.CheckBox chkEntrar;
        private System.Windows.Forms.TextBox txtNomeJogadorCriar;
        private System.Windows.Forms.Label lblNomeJogadorCriar;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}

