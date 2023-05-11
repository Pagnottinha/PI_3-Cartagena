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

            //BackColor = Color.FromArgb(167, 149, 94);

            this.partida = partida;
            cbo_Jogar.SelectedIndex = 0;
            nameCartaSelecionado = null;
            outraCartaClicada = false;

            tabuleiro.mostrarCasas(partida);      

            foreach (Cartas c in partida.jogador.cartas.Keys)
            {
                qtdCartas(c, partida.jogador.cartas[c]);
            }

            lblVez.Text = $"Vez de {partida.stringVez()}";
 
            tmrVerificarVez.Enabled = true;

            estrategia = new EstrategiaInicial(partida.tabuleiro, partida.jogador);
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
                partida.pegarHistorico();
                int posicao = Convert.ToInt32(txtPosicaoPirata.Text);
                partida.jogador.Jogar(posicao, partida.tabuleiro);
                consultarMao();
            }

            tabuleiro.atualizarPeoes();
        }

        private void btn_Historico_Click(object sender, EventArgs e)
        {
            partida.pegarHistorico();
            ltb_HistoricoPartida.DataSource = partida.historicos.ToList();

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
                partida.pegarHistorico();
                tabuleiro.atualizarPeoes();

                int idVencedor = partida.historicos[partida.historicos.Count - 1].idJogador;

                Jogador vencedor = partida.Jogadores.Find(j => j.id == idVencedor);

                lblVez.Text = $"Partida Finalizada - {vencedor}";

                tmrVerificarVez.Enabled = false;
                return;
            }

            lblVez.Text = $"Vez de {partida.stringVez()}";

            if (partida.vez.idJogador == partida.jogador.id)
            {
                btn_JogarPirata.Enabled = true;
                btnJogadaAutomatica.Enabled = true;
                lblVez.Text = $"Vez de {partida.stringVez()} - SUA VEZ";
            }
            else
            {
                btn_JogarPirata.Enabled = false;
                btnJogadaAutomatica.Enabled = false;
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
                    throw new Exception($"Panel {namePanel} desconhecido!");
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
                    throw new Exception($"Panel {namePanel} desconhecido!");
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

        private void btnJogadaAutomatica_Click(object sender, EventArgs e)
        {
            partida.pegarHistorico();
            estrategia.jogadaAutomatica();
            consultarMao();
            tabuleiro.atualizarPeoes();
        }
    }
}
