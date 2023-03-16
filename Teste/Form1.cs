using CartagenaServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class frmLobby : Form
    {

        Main Main = new Main();
        public frmLobby()
        {
            InitializeComponent();
        }

        private async void btnListGames_Click(object sender, EventArgs e)
        {
            try
            {
                string status;

                if (radTodos.Checked) status = "T";
                else if (radAbertas.Checked) status = "A";
                else if (radJogando.Checked) status = "J";
                else if (radEncerradas.Checked) status = "E";
                else
                {
                    throw new Exception("Ocorreu algum erro!");
                }
                
                dgvGames.DataSource = await Main.getGames(status);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nome = txtNomePartida.Text;
            string senha = txtSenhaPartida.Text;

            try
            {
                Game game = new Game(nome, senha);
                MessageBox.Show("Partida Criada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            int idPartida = Convert.ToInt32(dgvGames.SelectedRows[0].Cells["ID"].Value.ToString());
            string nomePlayer = txtNomeJogador.Text;
            string senha = txtSenha.Text;

            try
            {
                string player = Jogo.EntrarPartida(idPartida, nomePlayer, senha);
                MessageBox.Show(player);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
