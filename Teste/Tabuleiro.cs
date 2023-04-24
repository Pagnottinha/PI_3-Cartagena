using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

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

            for (int i = 1; i < partida.tabuleiro.Count - 1; i++)
            {
                Casa casa = partida.tabuleiro[i];
                this.Controls.Add(casa.panel);
                casa.panel.BringToFront();
            }

            iniciarPeoes();

            pnlTabuleiro.SendToBack();
        }

        void iniciarPeoes()
        {
            foreach (Jogador jogador in partida.Jogadores)
            {
                jogador.iniciarPeoes(partida.tabuleiro);
            }

            int linha = 1;
            int coluna = 1;

            foreach(Peao peao in partida.tabuleiro[0].peoes)
            {
                this.Controls.Add(peao.panel);

                int distanciaHeight = (pnlInicio.Height - peao.panel.Height * partida.Jogadores.Count) / (partida.Jogadores.Count + 1);
                peao.panel.Top = pnlInicio.Top + distanciaHeight * linha + peao.panel.Height * (linha - 1);

                int distanciaWidth = (pnlInicio.Width - peao.panel.Width * 6) / 7;
                peao.panel.Left = pnlInicio.Left + distanciaWidth * coluna + peao.panel.Width * (coluna - 1);

                coluna++;

                if (coluna % 7 == 0)
                {
                    coluna = 1;
                    linha++;
                }

            }
        }

        public void atualizarPeoes()
        {
            if (this.partida == null) return;

            for (int i = 1; i < partida.tabuleiro.Count - 1; i++)
            {
                Casa casa = partida.tabuleiro[i];

                for (int j = 0; j < casa.peoes.Count; j++)
                {
                    Peao peao = casa.peoes[j];

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

            if (partida.tabuleiro[partida.tabuleiro.Count - 1].peoes.Count > 0)
            {
                for(int i = 0; i < partida.Jogadores.Count; i++)
                {
                    Jogador jogador = partida.Jogadores[i];

                    int numPeoes = 0;

                    foreach(Peao peao in jogador.peoes)
                    {
                        if (peao.posicao == 37)
                        {

                            int distanciaHeight = (pnlBarco.Height - peao.panel.Height * partida.Jogadores.Count) / (partida.Jogadores.Count + 1);
                            peao.panel.Top = pnlBarco.Top + distanciaHeight * i + peao.panel.Height * (i - 1);

                            int distanciaWidth = (pnlBarco.Width - peao.panel.Width * 6) / 7;
                            peao.panel.Left = pnlBarco.Left + distanciaWidth * numPeoes + peao.panel.Width * (numPeoes - 1);

                            numPeoes++;
                        }
                    }
                }
            }

        }
    }
}
