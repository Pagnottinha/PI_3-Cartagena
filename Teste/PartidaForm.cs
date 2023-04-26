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
    public partial class PartidaForm : UserControl
    {
        Partida partida;
        public PartidaForm(Partida partida)
        {
            InitializeComponent();

            BackColor = Color.FromArgb(167, 149, 94);

            this.partida = partida;
            cbo_Jogar.SelectedIndex = 0;

            tabuleiro.mostrarCasas(partida);

            ltb_Cartas.DataSource = partida.jogador.cartas.ToList();

            lblVez.Text = $"Vez de {partida.stringVez()}";
        }

        private void btn_ConsultarMao_Click(object sender, EventArgs e)
        {
            ltb_Cartas.DataSource = partida.jogador.cartas.ToList();
        }

        private void btn_JogarPirata_Click(object sender, EventArgs e)
        {
            string opcaoJogar = cbo_Jogar.Text;
            int posicao = Convert.ToInt32(txtPosicaoPirata.Text);
            string cartaSelecionada = txtCartaSelecionada.Text;

            if (opcaoJogar == "Pular vez")
                partida.jogador.Jogar();
            else if (opcaoJogar == "Mover para frente")
            {
                partida.pegarHistorico();
                posicao = Convert.ToInt32(txtPosicaoPirata.Text);
                partida.jogador.Jogar(posicao, cartaSelecionada, partida.tabuleiro);
            }
            else
            {
                partida.pegarHistorico();
                posicao = Convert.ToInt32(txtPosicaoPirata.Text);
                partida.jogador.Jogar(posicao, partida.tabuleiro);
            }

            tabuleiro.atualizarPeoes();
        }

        private void btn_Historico_Click(object sender, EventArgs e)
        {
            partida.pegarHistorico();
            ltb_HistoricoPartida.DataSource = partida.historicos.ToList();

            tabuleiro.atualizarPeoes();
        }

        private void cbo_Jogar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Jogar.SelectedIndex == 1)
            {
                txtPosicaoPirata.Enabled = true;
                txtCartaSelecionada.Enabled = false;
            }
            else if (cbo_Jogar.SelectedIndex == 2)
            {
                txtCartaSelecionada.Enabled = false;
                txtPosicaoPirata.Enabled = false;
            }
            else
            {
                txtCartaSelecionada.Enabled = true;
                txtPosicaoPirata.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            partida.verificarVez();

            if (partida.vez.status == Status.Encerrada)
            {
                partida.pegarHistorico();
                int idVencedor = partida.historicos[partida.historicos.Count - 1].idJogador;

                Jogador vencedor = partida.Jogadores.Find(j => j.id == idVencedor);

                lblVez.Text = $"Partida Finalizada - {vencedor}";
                return;
            }

            lblVez.Text = $"Vez de {partida.stringVez()}";

            if (partida.vez.idJogador == partida.jogador.id)
            {
                btn_JogarPirata.Enabled = true;
            }
            else
            {
                btn_JogarPirata.Enabled = false;
            }
        }
    }
}
