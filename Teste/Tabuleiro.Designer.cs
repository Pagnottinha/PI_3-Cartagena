namespace Teste
{
    partial class Tabuleiro
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
            this.pnlTabuleiro = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlTabuleiro
            // 
            this.pnlTabuleiro.AutoSize = true;
            this.pnlTabuleiro.BackgroundImage = global::Teste.Properties.Resources.Tabuleiro;
            this.pnlTabuleiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabuleiro.Location = new System.Drawing.Point(0, 0);
            this.pnlTabuleiro.Name = "pnlTabuleiro";
            this.pnlTabuleiro.Size = new System.Drawing.Size(720, 722);
            this.pnlTabuleiro.TabIndex = 0;
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlTabuleiro);
            this.Name = "Tabuleiro";
            this.Size = new System.Drawing.Size(720, 722);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTabuleiro;
    }
}
