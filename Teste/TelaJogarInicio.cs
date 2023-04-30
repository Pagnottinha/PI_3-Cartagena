using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class TelaJogarInicio : UserControl
    {
        Image botao;
        Image botaoHover;

        public TelaJogarInicio()
        {
            InitializeComponent();
            
            botao = Image.FromFile("../../sprites/BotaoJogar.png");
            botaoHover = Image.FromFile("../../sprites/BotaoJogarHover.png");
        }

        private void TelaJogarInicio_Load(object sender, EventArgs e)
        {
            picBotaoJogar.BackgroundImage = botao;
        }

        private void picBotaoJogar_MouseEnter(object sender, EventArgs e)
        {
            picBotaoJogar.BackgroundImage = botaoHover;
        }

        private void picBotaoJogar_MouseLeave(object sender, EventArgs e)
        {
            picBotaoJogar.BackgroundImage = botao;
        }

        private void picBotaoJogar_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(new TelaInicial());
            Parent.Controls.Remove(this);
        }
    }
}
