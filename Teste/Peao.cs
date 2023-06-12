using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public class Peao
    {
        public Panel panel { get; private set; }

        public Jogador jogador { get; private set; }

        public int posicao { get; set; }
        public Peao(Jogador jogador)
        {
            this.jogador = jogador;
            this.panel = new Panel();
            panel.BackColor = jogador.cor;
            panel.Size = new Size(12, 12);
            panel.Region = criarBorda(panel.Size);
            posicao = 0;
        }

        Region criarBorda(Size size)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, size.Width, size.Height);
            return new Region(gp);
        }
    }
}
