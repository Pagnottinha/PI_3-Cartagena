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
    public partial class Tabuleiro : UserControl
    {
        Partida partida;
        public Tabuleiro()
        {
            InitializeComponent();
            partida = null;
        }

        public void mostrarCasas(Partida partida)
        {
            if (this.partida != null) return;

            this.partida = partida;

            partida.listarTabuleiro(pnlTabuleiro);

            pnlTabuleiro.SendToBack();

            foreach (Casa casa in partida.tabuleiro.Values)
            {
                this.Controls.Add(casa.panel);
                casa.panel.BringToFront();
            }
        }
    }
}
