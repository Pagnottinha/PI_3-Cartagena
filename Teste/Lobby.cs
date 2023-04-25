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
            dgvListarJogadores.AutoGenerateColumns = false;
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            partida.listarJogadores();
            dgvListarJogadores.DataSource = partida.Jogadores;
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            if(partida.comecarPartida())
            {
                Parent.Controls.Add(new PartidaForm(partida));
                Parent.Controls.Remove(this);
            }
        }
    }
}
