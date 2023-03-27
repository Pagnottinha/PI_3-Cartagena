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

        Main Main = new Main();
        public frmEntrarNaPartida()
        {
            InitializeComponent();
            cboFiltros.SelectedIndex = 0;
            dgvListaPartidas.AutoGenerateColumns = false;
        }

        private void btnListGames_Click(object sender, EventArgs e)
        {
            try
            {
                
                string status = cboFiltros.Text[0].ToString();

                Main.pegarPartidas(status);

                dgvListaPartidas.DataSource = Main.partidas;
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
                    Main.partidas.Add(partida);
                    return;
                }

                Jogador jogador = new Jogador(nomeJogador);
                jogador.entrarPartida(partida, senha);

                MessageBox.Show($"Partida Criada!\nID: {jogador.id}\nNome: {jogador.nome}\nSenha: {jogador.senha}\nCor: {jogador.cor}");
                frmLobby formLobby = new frmLobby(partida.id, jogador);
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
                jogador.entrarPartida(Main.partidas[indexPartida], senha);

                MessageBox.Show($"ID: {jogador.id}\nNome: {jogador.nome}\nSenha: {jogador.senha}\nCor: {jogador.cor}");
                frmLobby formLobby = new frmLobby(Main.partidas[indexPartida].id, jogador);
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
                    case Status.Abertas:
                        e.CellStyle.BackColor = Color.LightGreen;
                        break;
                    case Status.Jogando:
                        e.CellStyle.BackColor = Color.LightGoldenrodYellow;
                        break;
                    case Status.Enceradas: 
                        e.CellStyle.BackColor = Color.Red;
                        break;
                }
            
            }
               
        }
    }
}
