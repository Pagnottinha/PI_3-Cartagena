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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            this.grbStatus.SuspendLayout();
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
            // frmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbStatus);
            this.Controls.Add(this.dgvGames);
            this.Controls.Add(this.btnListGames);
            this.Name = "frmLobby";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
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
    }
}

