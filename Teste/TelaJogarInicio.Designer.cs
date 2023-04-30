namespace Teste
{
    partial class TelaJogarInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaJogarInicio));
            this.picBotaoJogar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBotaoJogar)).BeginInit();
            this.SuspendLayout();
            // 
            // picBotaoJogar
            // 
            this.picBotaoJogar.BackColor = System.Drawing.Color.Transparent;
            this.picBotaoJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBotaoJogar.Location = new System.Drawing.Point(366, 406);
            this.picBotaoJogar.Name = "picBotaoJogar";
            this.picBotaoJogar.Size = new System.Drawing.Size(307, 53);
            this.picBotaoJogar.TabIndex = 0;
            this.picBotaoJogar.TabStop = false;
            this.picBotaoJogar.Click += new System.EventHandler(this.picBotaoJogar_Click);
            this.picBotaoJogar.MouseEnter += new System.EventHandler(this.picBotaoJogar_MouseEnter);
            this.picBotaoJogar.MouseLeave += new System.EventHandler(this.picBotaoJogar_MouseLeave);
            // 
            // TelaJogarInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.picBotaoJogar);
            this.Name = "TelaJogarInicio";
            this.Size = new System.Drawing.Size(1019, 639);
            this.Load += new System.EventHandler(this.TelaJogarInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBotaoJogar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBotaoJogar;
    }
}
