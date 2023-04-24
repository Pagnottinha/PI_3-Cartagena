using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public class Peao
    {
        static Image molde = Image.FromFile("../../sprites/modelPeao.png");

        public Panel panel { get; private set; }

        public Jogador jogador { get; private set; }

        public int posicao { get; set; }
        public Peao(Jogador jogador)
        {
            this.jogador = jogador;
            this.panel = new Panel();
            panel.BackgroundImage = molde;
            panel.BackColor = jogador.cor;
            panel.Size = panel.BackgroundImage.Size;
            posicao = 0;
        }
    }
}
