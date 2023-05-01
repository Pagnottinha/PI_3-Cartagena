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
            this.pnlBarco = new System.Windows.Forms.Panel();
            this.pnlTabuleiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabuleiro
            // 
            this.pnlTabuleiro.AutoSize = true;
            this.pnlTabuleiro.BackgroundImage = global::Teste.Properties.Resources.Tabuleiro;
            this.pnlTabuleiro.Controls.Add(this.pnlBarco);
            this.pnlTabuleiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabuleiro.Location = new System.Drawing.Point(0, 0);
            this.pnlTabuleiro.Name = "pnlTabuleiro";
            this.pnlTabuleiro.Size = new System.Drawing.Size(720, 722);
            this.pnlTabuleiro.TabIndex = 0;
            // 
            // pnlBarco
            // 
            this.pnlBarco.Location = new System.Drawing.Point(275, 29);
            this.pnlBarco.Name = "pnlBarco";
            this.pnlBarco.Size = new System.Drawing.Size(135, 64);
            this.pnlBarco.TabIndex = 1;
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlTabuleiro);
            this.Name = "Tabuleiro";
            this.Size = new System.Drawing.Size(720, 722);
            this.pnlTabuleiro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTabuleiro;
        private System.Windows.Forms.Panel pnlBarco;
    }
}
