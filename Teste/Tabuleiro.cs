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
                if (casa.panel != null)
                {
                    this.Controls.Add(casa.panel);
                    casa.panel.BringToFront();
                }
            }
        }

        public void atualizarPeoes()
        {
            if (this.partida == null) return;

            for (int i = 1; i < partida.tabuleiro.Count; i++)
            {
                Casa casa = partida.tabuleiro[i];

                for (int j = 0; j < casa.peoes.Count; j++)
                {
                    Peao peao = casa.peoes[j];

                    if (!this.Controls.Contains(peao.panel))
                    {
                        this.Controls.Add(peao.panel);
                        peao.panel.BringToFront();
                    }

                    if (i == partida.tabuleiro.Count - 1)
                    {
                        this.Controls.Remove(peao.panel);
                    }
                    else
                    {
                        if (casa.linha % 2 == 0)
                        {
                            peao.panel.Left = casa.panel.Left - peao.panel.Width - 5;
                        }
                        else
                        {
                            peao.panel.Left = casa.panel.Left + casa.panel.Width + 5;
                        }

                        peao.panel.Top = casa.panel.Top + peao.panel.Height * j;
                    }
                }
            }
        }
    }
}
