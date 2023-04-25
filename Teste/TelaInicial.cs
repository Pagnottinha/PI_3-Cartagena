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
    public partial class TelaInicial : UserControl
    {
        public List<Partida> partidas = new List<Partida>();
        public TelaInicial()
        {
            InitializeComponent();
            cboFiltros.SelectedIndex = 0;
            dgvListaPartidas.AutoGenerateColumns = false;
        }

        private void btnListGames_Click(object sender, EventArgs e)
        {
            JogoService service = new JogoService();

            string status = cboFiltros.Text[0].ToString();

            (List <Partida> partidasRetorno, string msgErro)  = service.pegarPartidas(status);

            if (msgErro != null )
            {
                MessageBox.Show(msgErro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvListaPartidas.DataSource = partidasRetorno;
            partidas = partidasRetorno;
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nomePartida = txtNomePartida.Text;
            string senha = txtSenhaCriar.Text;
            string nomeJogador = txtNomeJogadorCriar.Text;


            if (nomePartida == "" || senha == "" || (chkEntrar.Checked && nomeJogador == ""))
            {
                MessageBox.Show("Campos vazios!", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Partida partida = new Partida(nomePartida, senha);

            if (!chkEntrar.Checked)
            {
                MessageBox.Show("Partida Criada!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                partidas.Add(partida);
                return;
            }

            Jogador jogador = new Jogador(nomeJogador);
            jogador.entrarPartida(partida, senha);

            abrirLobby(partida);

        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            int indexPartida = dgvListaPartidas.SelectedRows[0].Index;
            string nomePlayer = txtNomeJogadorEntrar.Text;
            string senha = txtSenhaEntrar.Text;

            Jogador jogador = new Jogador(nomePlayer);
            if(jogador.entrarPartida(partidas[indexPartida], senha))
            {
                abrirLobby(partidas[indexPartida]);
            };

        }

        private void abrirLobby(Partida partida)
        {
            Parent.Controls.Add(new Lobby(partida));
            Parent.Controls.Remove(this);
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
