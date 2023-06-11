using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Teste
{
    public partial class PartidaForm : UserControl
    {
        Partida partida;
        Estrategia estrategia;
        string nameCartaSelecionado;
        bool outraCartaClicada;
        public PartidaForm(Partida partida)
        {
            InitializeComponent();

            ltb_HistoricoPartida.DrawItem += ltb_HistoricoPartida_DrawItem;
            this.partida = partida;
            btnVoltaLobby.Show();
            partida.listarJogadores();
            tabuleiro.mostrarCasas(partida);

            ltb_HistoricoPartida.BackColor = Color.FromArgb(80, Color.Black);

            if (partida.jogador == null)
            {
                grbJogadas.Hide();
                pnlMao.Hide();
                partida.verificarVez();
            }
            else
            {
                cbo_Jogar.SelectedIndex = 0;
                nameCartaSelecionado = null;
                outraCartaClicada = false;

                foreach (Cartas c in partida.jogador.cartas.Keys)
                {
                    qtdCartas(c, partida.jogador.cartas[c]);
                }
            }

            //BackColor = Color.FromArgb(167, 149, 94);
           

            lblVez.Text = $"Vez de {partida.vez}";
 
            tmrVerificarVez.Enabled = true;
        }

        private void consultarMao()
        {
            foreach(Cartas c in partida.jogador.cartas.Keys)
            {
                qtdCartas(c, partida.jogador.cartas[c]);
            }
        }

        public void qtdCartas(Cartas carta, int qtd)
        {
            string nomeLabel = $"lblQtd{carta}";

            Label label = (Label)Controls.Find(nomeLabel, true).FirstOrDefault();

            if (label != null)
            {
                label.Text = qtd.ToString();
            }
        }

        public bool qtdCartas()
        {
            string nomeLabel = $"lblQtd{nameCartaSelecionado}";

            Label label = (Label)Controls.Find(nomeLabel, true).FirstOrDefault();
            
            if(label != null)
            {
                int qtdCartas = Convert.ToInt32(label.Text);

                if (qtdCartas > 0)
                    return true;
                else
                    return false;
            }
            else 
                return false;
        }

        private void btn_JogarPirata_Click(object sender, EventArgs e)
        {
            string opcaoJogar = cbo_Jogar.Text;

            if (opcaoJogar == "Pular vez")
                partida.jogador.Jogar();
            else if (opcaoJogar == "Mover para frente")
            {
                partida.pegarHistorico();
                int posicao = Convert.ToInt32(txtPosicaoPirata.Text);

                if (nameCartaSelecionado != null)
                {
                    if(qtdCartas())
                    {
                        partida.jogador.Jogar(posicao, nameCartaSelecionado.Substring(0, 1), partida.tabuleiro);
                        mudarLayerCarta();
                        consultarMao();
                    }
                    else
                        MessageBox.Show($"Não foi possível jogar a carta {nameCartaSelecionado}" +
                            $" pois não existem cartas para serem jogadas", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Nenhuma carta selecionada!");
                }
            }
            else
            {
                atualizarHistorico();
                int posicao = Convert.ToInt32(txtPosicaoPirata.Text);
                partida.jogador.Jogar(posicao, partida.tabuleiro);
                consultarMao();
            }

            tabuleiro.atualizarPeoes();
        }

        private void btn_Historico_Click(object sender, EventArgs e)
        {
            atualizarHistorico();
        }

        void atualizarHistorico()
        {
            partida.pegarHistorico();
            ltb_HistoricoPartida.DataSource = partida.historicos.ToList();
            ltb_HistoricoPartida.TopIndex = ltb_HistoricoPartida.Items.Count - 1;
            tabuleiro.atualizarPeoes();
        }

        private void cbo_Jogar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Jogar.SelectedIndex == 1)
            {
                txtPosicaoPirata.Enabled = true;
            }
            else if (cbo_Jogar.SelectedIndex == 2)
            {
                txtPosicaoPirata.Enabled = false;
            }
            else
            {
                txtPosicaoPirata.Enabled = true;
            }
        }

        private void tmrVerificarVez_Tick(object sender, EventArgs e)
        {
            partida.verificarVez();

            if (partida.status == Status.Encerrada)
            {
                atualizarHistorico();
                tabuleiro.atualizarPeoes();

                btnVoltaLobby.Show();

                int idVencedor = partida.historicos[partida.historicos.Count - 1].idJogador;

                Jogador vencedor = partida.Jogadores.Find(j => j.id == idVencedor);

                lblVez.Text = $"Partida Finalizada - {vencedor}";

                tmrVerificarVez.Enabled = false;
                return;
            }

            if (partida.vez.Jogador == partida.jogador)
            {
                btn_JogarPirata.Enabled = true;
                btnJogadaAutomatica.Enabled = true;
                lblVez.Text = $"Vez de {partida.vez} - SUA VEZ";

                JogadaAutomatica();
            }
            else if(partida.jogador == null)
            {
                lblVez.Text = $"Vez de {partida.vez}";

                atualizarHistorico();
            }
            else
            {
                btn_JogarPirata.Enabled = false;
                btnJogadaAutomatica.Enabled = false;

                lblVez.Text = $"Vez de {partida.vez}";
            }
        }

        public void onMouseEnter(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            string namePanel = panel.Name.Substring(3);
            Image imageHover;

            switch (namePanel) 
            {
                case "Chave":
                    imageHover = Image.FromFile("../../sprites/Cartas/CartaChaveSelecionada.png");
                    break;
                case "Faca":
                    imageHover = Image.FromFile("../../sprites/Cartas/CartaFacaSelecionada.png");
                    break;
                case "Esqueleto":
                    imageHover = Image.FromFile("../../sprites/Cartas/CartaEsqueletoSelecionada.png");
                    break;
                case "Garrafa":
                    imageHover = Image.FromFile("../../sprites/Cartas/CartaGarrafaSelecionada.png");
                    break;
                case "Pistola":
                    imageHover = Image.FromFile("../../sprites/Cartas/CartaPistolaSelecionada.png");
                    break;
                case "Tricornio":
                    imageHover = Image.FromFile("../../sprites/Cartas/CartaTricornioSelecionada.png");
                    break;
                default:
                    MessageBox.Show($"Panel {namePanel} desconhecido");
                    return;
            }

            panel.BackgroundImage = imageHover;
        }

        public void onMouseExit(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            string namePanel = panel.Name.Substring(3);
            Image imageHigh;

            switch (namePanel)
            {
                case "Chave":
                    imageHigh = Image.FromFile("../../sprites/Cartas/CartaChave.png");
                    break;
                case "Faca":
                    imageHigh = Image.FromFile("../../sprites/Cartas/CartaFaca.png");
                    break;
                case "Esqueleto":
                    imageHigh = Image.FromFile("../../sprites/Cartas/CartaEsqueleto.png");
                    break;
                case "Garrafa":
                    imageHigh = Image.FromFile("../../sprites/Cartas/CartaGarrafa.png");
                    break;
                case "Pistola":
                    imageHigh = Image.FromFile("../../sprites/Cartas/CartaPistola.png");
                    break;  
                case "Tricornio":
                    imageHigh = Image.FromFile("../../sprites/Cartas/CartaTricornio.png");
                    break;
                default:
                    MessageBox.Show($"Panel {namePanel} desconhecido");
                    return;
            }

            if(namePanel != this.nameCartaSelecionado || outraCartaClicada)
                panel.BackgroundImage = imageHigh;
        }

        public void onClick(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;

            if(nameCartaSelecionado != null)
            {
                outraCartaClicada = true;
                Panel panelAnterior = (Panel)Controls.Find("pnl" + nameCartaSelecionado, true).FirstOrDefault();
                onMouseExit(panelAnterior, e);
            }

            outraCartaClicada = false;
            nameCartaSelecionado = panel.Name.Substring(3);
            onMouseEnter(sender, e);
        }

        public void mudarLayerCarta()
        {
            EventArgs e = new EventArgs();
            Panel panel = (Panel)Controls.Find("pnl" + nameCartaSelecionado, true).FirstOrDefault();
            outraCartaClicada = true;
            onMouseExit(panel, e);
            nameCartaSelecionado = null;
            outraCartaClicada = false;
        }

        void JogadaAutomatica()
        {
            atualizarHistorico();
            estrategia = Estrategia.comecarEstrategia(partida.tabuleiro, partida.jogador);
            estrategia.jogadaAutomatica();
            consultarMao();
            tabuleiro.atualizarPeoes();
        }

        private void btnJogadaAutomatica_Click(object sender, EventArgs e)
        {
            JogadaAutomatica();
        }

        private void btnVoltaLobby_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(new TelaInicial());
            Parent.Controls.Remove(this);
        }

        private void ltb_HistoricoPartida_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if(e.Index >= 0)
            {
                string item = ltb_HistoricoPartida.Items[e.Index].ToString();

                Historico h = (Historico)ltb_HistoricoPartida.Items[e.Index];

                Brush brush = new SolidBrush(h.Jogador.cor);

                e.Graphics.DrawString(item, e.Font ,brush, e.Bounds);      
            }
        }
    }
}
