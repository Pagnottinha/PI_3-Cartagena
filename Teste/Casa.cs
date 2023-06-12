using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public class Casa
    {

        static Dictionary<Cartas, Image> imagens = new Dictionary<Cartas, Image>()
        {
            { Cartas.Garrafa, Image.FromFile("../../sprites/Simbolos/Garrafa.png")},
            { Cartas.Faca, Image.FromFile("../../sprites/Simbolos/Faca.png")},
            { Cartas.Esqueleto, Image.FromFile("../../sprites/Simbolos/Esqueleto.png")},
            { Cartas.Pistola, Image.FromFile("../../sprites/Simbolos/Pistola.png")},
            { Cartas.Chave, Image.FromFile("../../sprites/Simbolos/Chave.png")},
            { Cartas.Tricornio, Image.FromFile("../../sprites/Simbolos/Tricornio.png")}
        };

        public Panel panel { get; }
        public Cartas carta { get; }
        public List<Peao> peoes { get; set; }
        public int linha { get; private set; }
        public Casa(Cartas carta, int linha, int coluna, Panel tabuleiro)
        {
            this.carta = carta;
            this.linha = linha;
            this.peoes = new List<Peao>(3);

            this.panel = new Panel();
            panel.Anchor = AnchorStyles.None;

            panel.BackgroundImage = imagens[carta];
            panel.BackgroundImageLayout = ImageLayout.Stretch;

            panel.BackColor = Color.Transparent;
            panel.Size = panel.BackgroundImage.Size;

            int parede = 14;

            int regiaoSimbolos = tabuleiro.Width - 2 * (panel.Width / 2 + parede);

            int espaco = (regiaoSimbolos - 7 * panel.Width) / 6;

            panel.Left = tabuleiro.Left + parede + coluna * (panel.Width + espaco) - panel.Width / 2 + 50;
            panel.Top = tabuleiro.Height + tabuleiro.Top - linha * panel.Height - parede * (2 * linha - 1);

            tabuleiro.Controls.Add(panel);
        }

        public Casa(int linha)
        {
            this.peoes = new List<Peao>(3);
            this.linha = linha;
        }
    }
}
