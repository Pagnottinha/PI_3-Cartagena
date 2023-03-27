using CartagenaServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teste
{
    public partial class frmJogo : Form
    {
        Partida partida;
        public frmJogo(Partida partida)
        {
            InitializeComponent();
            this.partida = partida;
            cbo_Jogar.SelectedIndex = 0;
        }

        private void btn_ConsultarMao_Click(object sender, EventArgs e)
        {
            partida.jogador.consultarMao();


            ltb_Cartas.Items.Clear();
            foreach (Cartas item in partida.jogador.cartas.Keys)
            { 
                ltb_Cartas.Items.Add(item + ": " + partida.jogador.cartas[item]);
            }
           
        }

        private void btn_JogarPirata_Click(object sender, EventArgs e)
        {
            try
            {
                string opcaoJogar = cbo_Jogar.Text;
                int posicao;
                string cartaSelecionada = txtCartaSelecionada.Text;

                if (opcaoJogar == "Pular vez")
                    partida.jogador.Jogar(opcaoJogar, -1, cartaSelecionada);
                else
                {
                    posicao = Convert.ToInt32(txtPosicaoPirata.Text);
                    partida.jogador.Jogar(opcaoJogar, posicao, cartaSelecionada);
                }                  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizarTabuleiro_Click(object sender, EventArgs e)
        {
            string[] tabuleiro = Jogo.ExibirTabuleiro(partida.id).Replace("\r", "")
                .Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            ltb_Tabuleiro.Items.Clear();

            foreach (string item in tabuleiro)
            {
                string[] retornoTabuleiro = item.Split(',');

                int posicao = Convert.ToInt32(retornoTabuleiro[0]);

                string carta = retornoTabuleiro[1];

                switch (carta)
                {
                    case "E":
                        ltb_Tabuleiro.Items.Add($"Posição {posicao}: Esqueleto");
                        break;
                    case "P":
                        ltb_Tabuleiro.Items.Add($"Posição {posicao}: Pistola");
                        break;
                    case "C":
                        ltb_Tabuleiro.Items.Add($"Posição {posicao}: Chave");
                        break;
                    case "T":
                        ltb_Tabuleiro.Items.Add($"Posição {posicao}: Tricórnio");
                        break;
                    case "G":
                        ltb_Tabuleiro.Items.Add($"Posição {posicao}: Garrafa");
                        break;
                    case "F":
                        ltb_Tabuleiro.Items.Add($"Posição {posicao}: Faca");
                        break;
                    case " ":
                        ltb_Tabuleiro.Items.Add($"Posição {posicao}");
                        break;
                    default:
                        throw new Exception("Posição Inválida");
                }
                
            }
            
        }

        private void btn_Historico_Click(object sender, EventArgs e)
        {
            //string teste = Jogo.ExibirHistorico(idPartida);
            //MessageBox.Show(teste);

            string[] historico = Jogo.ExibirHistorico(partida.id).Replace("\r", "")
                .Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            ltb_HistoricoPartida.Items.Clear();

            foreach (string item in historico)
            {
                string[] retornoTabuleiro = item.Split(',');

                int id = Convert.ToInt32(retornoTabuleiro[0]);
                int numJogada = Convert.ToInt32(retornoTabuleiro[1]);
                string carta = retornoTabuleiro[2];
                int posicaoOrigem;
                int posicaoDestino;

                if (retornoTabuleiro[3] != "" && retornoTabuleiro[4] != "")
                {
                    posicaoOrigem = Convert.ToInt32(retornoTabuleiro[3]);
                    posicaoDestino = Convert.ToInt32(retornoTabuleiro[4]);

                    switch (carta)
                    {
                        case "E":
                            ltb_HistoricoPartida.Items.Add($"O jogador com ID {id} na jogada\n {numJogada} jogou uma carta de Esqueleto\n e foi da posição {posicaoOrigem} para\n a posição {posicaoDestino}");
                            break;
                        case "P":
                            ltb_HistoricoPartida.Items.Add($"O jogador com ID {id} na jogada\n {numJogada} jogou uma carta de Pistola\n e foi da posição {posicaoOrigem} para\n a posição {posicaoDestino}");
                            break;
                        case "C":
                            ltb_HistoricoPartida.Items.Add($"O jogador com ID {id} na jogada\n {numJogada} jogou uma carta de Chave\n e foi da posição {posicaoOrigem} para\n a posição {posicaoDestino}");
                            break;
                        case "T":
                            ltb_HistoricoPartida.Items.Add($"O jogador com ID {id} na jogada\n {numJogada} jogou uma carta de Tricórnio\n e foi da posição {posicaoOrigem} para\n a posição {posicaoDestino}");
                            break;
                        case "G":
                            ltb_HistoricoPartida.Items.Add($"O jogador com ID  {id} na jogada\n {numJogada} jogou uma carta de Garrafa\n e foi da posição  {posicaoOrigem} para\n a posição {posicaoDestino}");
                            break;
                        case "F":
                            ltb_HistoricoPartida.Items.Add($"O jogador com ID {id} na jogada\n {numJogada} jogou uma carta de Faca\n e foi da posição {posicaoOrigem} para\n a posição {posicaoDestino}");
                            break;
                        case " ":
                            ltb_HistoricoPartida.Items.Add($"O jogador com ID {id} na jogada\n {numJogada} voltou da posição {posicaoOrigem}\n para a posição {posicaoDestino}");
                            break;
                        default:
                            throw new Exception("Posição Inválida");
                    }
                }
                else
                {
                    ltb_HistoricoPartida.Items.Add($"Jogador {id} pulou a vez na jogada {numJogada}");
                }
            }

        }

        private void cbo_Jogar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_Jogar.SelectedIndex == 1)
            {
                txtCartaSelecionada.Enabled = false;
            }
            else if(cbo_Jogar.SelectedIndex == 2)
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
    }
}
