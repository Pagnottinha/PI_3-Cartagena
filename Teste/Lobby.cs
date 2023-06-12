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
    public partial class Lobby : UserControl
    {
        Partida partida;
        public Lobby(Partida partida)
        {
            InitializeComponent();
            this.partida = partida;
            dgvListarJogadores.ClearSelection();
            dgvListarJogadores.AutoGenerateColumns = false;
            dgvListarJogadores.DataSource = partida.Jogadores.ToList();
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            partida.listarJogadores();
            dgvListarJogadores.DataSource = partida.Jogadores.ToList();
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            if(partida.comecarPartida())
            {
                Parent.Controls.Add(new PartidaForm(partida));
                Parent.Controls.Remove(this);
            }
        }

        private void dgvListarJogadores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.Columns[e.ColumnIndex].Name.Equals("Cor"))
            {
                if (e.Value == null) { return; }

                e.CellStyle.ForeColor = (Color)e.Value;
            }
        }
    }
}
