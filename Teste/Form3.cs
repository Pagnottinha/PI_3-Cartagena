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

            tabuleiro.mostrarCasas(partida);

            foreach (Jogador jogador in partida.Jogadores)
            {
                jogador.iniciarPeoes(partida.tabuleiro);
            }

            ltb_Cartas.DataSource = partida.jogador.cartas.ToList();
            
        }

        private void btn_ConsultarMao_Click(object sender, EventArgs e)
        {
            try
            {
                ltb_Cartas.DataSource = partida.jogador.cartas.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_JogarPirata_Click(object sender, EventArgs e)
        {
            try
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Historico_Click(object sender, EventArgs e)
        {
            try
            {
                partida.pegarHistorico();
                ltb_HistoricoPartida.DataSource = partida.historicos.ToList();

                tabuleiro.atualizarPeoes();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnVez_Click(object sender, EventArgs e)
        {
            partida.verificarVez();

            foreach(Jogador jogador in partida.Jogadores)
            {
                if (jogador.id == partida.vez)
                {
                    lblVez.Text = $"Vez de {jogador}";
                }
            }

        }
    }
}
