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
            partida.listarTabuleiro();
            ltb_Tabuleiro.DataSource = partida.tabuleiro.ToList(); 
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
                    try
                    {
                        switch (carta)
                        {
                            case "E":
                                ltb_HistoricoPartida.Items.Add($"{id} ({numJogada}) -> Esqueleto | {posicaoOrigem} -> {posicaoDestino}");
                                break;
                            case "P":
                                ltb_HistoricoPartida.Items.Add($"{id} ({numJogada}) -> Pistola | {posicaoOrigem} -> {posicaoDestino}");
                                break;
                            case "C":
                                ltb_HistoricoPartida.Items.Add($"{id} ({numJogada}) -> Chave | {posicaoOrigem} -> {posicaoDestino}");
                                break;
                            case "T":
                                ltb_HistoricoPartida.Items.Add($"{id} ({numJogada}) -> Tricornio | {posicaoOrigem} -> {posicaoDestino}");
                                break;
                            case "G":
                                ltb_HistoricoPartida.Items.Add($"{id} ({numJogada}) -> Garrafa | {posicaoOrigem} -> {posicaoDestino}");
                                break;
                            case "F":
                                ltb_HistoricoPartida.Items.Add($"{id} ({numJogada}) -> Faca | {posicaoOrigem} -> {posicaoDestino}");
                                break;
                            case "":
                                ltb_HistoricoPartida.Items.Add($"{id} ({numJogada}) voltou | {posicaoOrigem} -> {posicaoDestino}");
                                break;
                            default:
                                throw new Exception("Posição Inválida");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ltb_HistoricoPartida.Items.Add($"Jogador {id} ({numJogada}) pulou");
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
