﻿using System;
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

            lblVez.Text = $"Vez de {partida.vez}";
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
            catch (Exception ex)
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

        }

        private void btnVez_Click(object sender, EventArgs e)
        {
            partida.verificarVez();

            lblVez.Text = $"Vez de {partida.vez}";
        }
    }
}