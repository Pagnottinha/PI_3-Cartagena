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
    public partial class frmEntrarNaPartida : Form
    {

        public List<Partida> partidas = new List<Partida>();
        public frmEntrarNaPartida()
        {
            InitializeComponent();
            cboFiltros.SelectedIndex = 0;
            dgvListaPartidas.AutoGenerateColumns = false;
        }

        private void btnListGames_Click(object sender, EventArgs e)
        {
            JogoService service = new JogoService();

            try
            {
                
                string status = cboFiltros.Text[0].ToString();

                partidas = service.pegarPartidas(status);

                dgvListaPartidas.DataSource = partidas;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nomePartida = txtNomePartida.Text;
            string senha = txtSenhaCriar.Text;
            string nomeJogador = txtNomeJogadorCriar.Text;


            if (nomePartida == "" ||  senha == "" || (chkEntrar.Checked && nomeJogador == ""))
            {
                MessageBox.Show("Campos vazios!", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Partida partida = new Partida(nomePartida, senha);

                if (!chkEntrar.Checked)
                {
                    MessageBox.Show("Partida Criada!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    partidas.Add(partida);
                    return;
                }

                Jogador jogador = new Jogador(nomeJogador);
                jogador.entrarPartida(partida, senha);

                frmLobby formLobby = new frmLobby(partida);
                this.Hide();
                formLobby.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            int indexPartida = dgvListaPartidas.SelectedRows[0].Index;
            string nomePlayer = txtNomeJogadorEntrar.Text;
            string senha = txtSenhaEntrar.Text;

            try
            {
                Jogador jogador = new Jogador(nomePlayer);
                jogador.entrarPartida(partidas[indexPartida], senha);

                frmLobby formLobby = new frmLobby(partidas[indexPartida]);
                this.Hide();
                formLobby.ShowDialog();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void chkEntrar_CheckedChanged(object sender, EventArgs e)
        {
            lblNomeJogadorCriar.Enabled = !lblNomeJogadorCriar.Enabled;
            txtNomeJogadorCriar.Enabled = !txtNomeJogadorCriar.Enabled;
        }

        private void dgvListaPartidas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.Columns[e.ColumnIndex].Name.Equals("status"))
            {
                if (e.Value == null) { return; }

                switch ((Status)e.Value)
                {
                    case Status.Aberta:
                        e.CellStyle.BackColor = Color.LightGreen;
                        break;
                    case Status.Jogando:
                        e.CellStyle.BackColor = Color.LightGoldenrodYellow;
                        break;
                    case Status.Encerrada: 
                        e.CellStyle.BackColor = Color.Red;
                        break;
                }
            
            }
               
        }
    }
}
