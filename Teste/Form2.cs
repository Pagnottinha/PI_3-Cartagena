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

namespace Teste
{
    public partial class frmLobby : Form
    {
        private int idPartida;
        Main Main = new Main();
        Jogador jogador;

        public frmLobby(int idPartida, Jogador jogador)
        {
            InitializeComponent();
            this.idPartida = idPartida;
            this.jogador = jogador;
            lblDadosJogador.Text = $"ID:  {jogador.id}   -   Nome:  {jogador.nome}   -   Senha:  {jogador.senha}   -   Cor:  {jogador.cor}";
            dgvListarJogadores.AutoGenerateColumns = false;
        }

        private void frmLobby_Load(object sender, EventArgs e)
        {

        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            try
            {
                Main.pegarJogadores(idPartida);

                dgvListarJogadores.DataSource = Main.jogador;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            int idJogador = Convert.ToInt32(txtIdJogador.Text);
            string senha = txtSenhaJogador.Text;

            try
            {
                string teste = Jogo.IniciarPartida(idJogador, senha);
                string test = Jogo.ConsultarMao(idJogador, senha);


                MessageBox.Show(test);

                frmJogo frmJogo = new frmJogo(jogador);
                this.Hide();
                frmJogo.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
