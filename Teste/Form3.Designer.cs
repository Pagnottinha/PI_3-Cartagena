namespace Teste
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
            this.SuspendLayout();
            // 
            // ltb_Cartas
            // 
            this.ltb_Cartas.FormattingEnabled = true;
            this.ltb_Cartas.ItemHeight = 16;
            this.ltb_Cartas.Location = new System.Drawing.Point(12, 12);
            this.ltb_Cartas.Name = "ltb_Cartas";
            this.ltb_Cartas.Size = new System.Drawing.Size(191, 164);
            this.ltb_Cartas.TabIndex = 0;
            // 
            // btn_ConsultarMao
            // 
            this.btn_ConsultarMao.Location = new System.Drawing.Point(34, 182);
            this.btn_ConsultarMao.Name = "btn_ConsultarMao";
            this.btn_ConsultarMao.Size = new System.Drawing.Size(140, 60);
            this.btn_ConsultarMao.TabIndex = 1;
            this.btn_ConsultarMao.Text = "Consultar Mão";
            this.btn_ConsultarMao.UseVisualStyleBackColor = true;
            this.btn_ConsultarMao.Click += new System.EventHandler(this.btn_ConsultarMao_Click);
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 554);
            this.Controls.Add(this.btn_ConsultarMao);
            this.Controls.Add(this.ltb_Cartas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmJogo";
            this.Text = "Jogo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltb_Cartas;
        private System.Windows.Forms.Button btn_ConsultarMao;
    }
}