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
    public partial class frmJogo : Form
    {
        Jogador jogador;
        public frmJogo(Jogador jogador)
        {
            InitializeComponent();
            this.jogador = jogador;
        }

        private void btn_ConsultarMao_Click(object sender, EventArgs e)
        {
            jogador.consultarMao();

            foreach (Cartas item in jogador.cartas.Keys)
            { 
                ltb_Cartas.Items.Add(item + " " + jogador.cartas[item]);
            }
           
        }
    }
}
