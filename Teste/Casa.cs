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
            { Cartas.Garrafa, Image.FromFile("../../sprites/Garrafa.png")},
            { Cartas.Faca, Image.FromFile("../../sprites/Faca.png")},
            { Cartas.Esqueleto, Image.FromFile("../../sprites/Esqueleto.png")},
            { Cartas.Pistola, Image.FromFile("../../sprites/Pistola.png")},
            { Cartas.Chave, Image.FromFile("../../sprites/Chave.png")},
            { Cartas.Tricornio, Image.FromFile("../../sprites/Tricornio.png")}
        };

        public Panel panel { get; }
        public Cartas carta { get; }
        public int qntPeoes { get; set; }

        int parede = 35;
        public Casa(Cartas carta, int linha, int coluna, Panel tabuleiro)
        {
            this.carta = carta;
            qntPeoes = 0;
            this.panel = new Panel();
            panel.Anchor = AnchorStyles.None;

            panel.BackgroundImage = imagens[carta];

            panel.Size = panel.BackgroundImage.Size;

            panel.Left = tabuleiro.Left + coluna * 92 + 80 - panel.Width / 2;
            panel.Top = tabuleiro.Height + tabuleiro.Top - linha * panel.Height - parede * (2 * linha - 1);
        }
    }
}
