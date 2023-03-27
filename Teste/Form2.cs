﻿using CartagenaServer;
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
    public partial class frmLobby : Form
    {
        Partida partida;

        public frmLobby(Partida partida)
        {
            InitializeComponent();
            this.partida = partida;
            dgvListarJogadores.AutoGenerateColumns = false;
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            try
            {
                partida.listarJogadores();

                dgvListarJogadores.DataSource = partida.Jogadores;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {

            frmJogo frmJogo = new frmJogo(partida);

            try
            {
                Jogador jogador = partida.jogador;

                JogoService service = new JogoService();

                partida.vez = service.iniciarPartida(jogador.id, jogador.senha);
                
                this.Hide();
                frmJogo.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ex.Message == "ERRO:Partida não está aberta")
                {
                    this.Hide();
                    frmJogo.ShowDialog();
                }
            }
        }
    }
}