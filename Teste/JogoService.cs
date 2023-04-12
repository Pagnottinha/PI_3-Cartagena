using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;
using static System.Windows.Forms.LinkLabel;

namespace Teste
{
    internal class JogoService
    {
        public JogoService() { }

        private string[] separar(string retorno, bool separarVirgulas)
        {
            if (retorno.StartsWith("ERRO"))
            {
                switch(retorno)
                {
                    case "ERRO:Partida não está aberta":
                        throw new PartidaAbertaException();
                    default:
                        throw new Exception(retorno);
                }
            }

            string[] array;
            
            array = retorno.Replace("\r", "").Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            
            if (separarVirgulas)
            {
                return array[0].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            }

            return array;
        }

        public List<Partida> pegarPartidas(string s)
        {
            string[] retorno = separar(Jogo.ListarPartidas(s), false);

            List<Partida> partidas = new List<Partida>();

            foreach (string partida in retorno)
            {
                string[] args = partida.Split(',');

                int id = Convert.ToInt32(args[0]);
                string nome = args[1];
                string data = args[2];

                Status status;
                switch (args[3])
                {
                    case "A":
                        status = Status.Aberta;
                        break;
                    case "J":
                        status = Status.Jogando;
                        break;
                    case "E":
                        status = Status.Encerada;
                        break;
                    default:
                        throw new Exception("Status inválido");
                }

                partidas.Add(new Partida(id, nome, data, status));
            }

            return partidas;
        }

        public List<Jogador> pegarJogadores(int idPartida)
        {
            string[] pegarJogadores = separar(Jogo.ListarJogadores(idPartida), false);

            List<Jogador> partida = new List<Jogador>();

            foreach(string jogadores in pegarJogadores)
            {
                string[] args = jogadores.Split(',');

                int id = Convert.ToInt32(args[0]);
                string nome = args[1];
                string cor = args[2];

                partida.Add(new Jogador(id, nome, tratarCor(cor))); 
            }

            return partida;
        }

        public Jogador entrarPartida(int partidaId, string nomePlayer, string senhaPartida)
        {
            string[] retorno = separar(Jogo.EntrarPartida(partidaId, nomePlayer, senhaPartida), true);

            Jogador jogador = new Jogador(Convert.ToInt32(retorno[0]), retorno[1], nomePlayer, tratarCor(retorno[2]));

            return jogador;
        }

        Color tratarCor(string cor)
        {
            switch(cor)
            {
                case "Vermelho":
                    return Color.Red;
                case "Verde":
                    return Color.Green;
                case "Azul":
                    return Color.Blue;
                case "Roxo":
                    return Color.Purple;
                case "Amarelo":
                    return Color.Yellow;
                case "Branco":
                    return Color.White;
                case "Rosa":
                    return Color.Pink;
                default:
                    throw new Exception($"Cor {cor} desconhecida!");
            }
        }

        public Dictionary<Cartas, int> consultarMao(int idJogador, string senhaJogador)
        {
            string[] ret = separar(Jogo.ConsultarMao(idJogador, senhaJogador), false);

            Dictionary<Cartas, int> cartas = new Dictionary<Cartas, int>();

            foreach (string item in ret)
            {
                string[] retornoConsultMao = item.Split(',');

                string carta = retornoConsultMao[0];
                int qtd = Convert.ToInt32(retornoConsultMao[1]);

                cartas.Add(tratarCarta(carta), qtd);

            }

            return cartas;
        }

        Cartas tratarCarta(string carta)
        {
            Cartas cartaRetorno;

            switch (carta)
            {
                case "E":
                    cartaRetorno = Cartas.Esqueleto;
                    break;
                case "T":
                    cartaRetorno = Cartas.Tricornio;
                    break;
                case "G":
                    cartaRetorno = Cartas.Garrafa;
                    break;
                case "F":
                    cartaRetorno = Cartas.Faca;
                    break;
                case "P":
                    cartaRetorno = Cartas.Pistola;
                    break;
                case "C":
                    cartaRetorno = Cartas.Chave;
                    break;
                default:
                    throw new Exception($"Carta {carta} desconhecia!");
            }

            return cartaRetorno;
        }
        public int iniciarPartida(int idJogador, string senhaJogador)
        {
            return Convert.ToInt32(separar(Jogo.IniciarPartida(idJogador, senhaJogador), false)[0]);
        }

        public Dictionary<int, Casa> pegarTabuleiro(int idPartida, Panel pnlTabuleiro)
        {
            string[] retorno = separar(Jogo.ExibirTabuleiro(idPartida), false);

            Dictionary<int, Casa> tabuleiro = new Dictionary<int, Casa>();

            int coluna = 0;
            int linha = 1;
            int sentido = 1;

            foreach (string item in retorno)
            {
                string[] retornoTabuleiro = item.Split(',');

                int posicao = Convert.ToInt32(retornoTabuleiro[0]);

                string carta = retornoTabuleiro[1];

                switch (carta)
                {
                    case "E":
                        tabuleiro.Add(posicao, new Casa(Cartas.Esqueleto, linha, coluna, pnlTabuleiro));
                        break;
                    case "P":
                        tabuleiro.Add(posicao, new Casa(Cartas.Pistola, linha, coluna, pnlTabuleiro));
                        break;
                    case "C":
                        tabuleiro.Add(posicao, new Casa(Cartas.Chave, linha, coluna, pnlTabuleiro));
                        break;
                    case "T":
                        tabuleiro.Add(posicao, new Casa(Cartas.Tricornio, linha, coluna, pnlTabuleiro));
                        break;
                    case "G":
                        tabuleiro.Add(posicao, new Casa(Cartas.Garrafa, linha, coluna, pnlTabuleiro));
                        break;
                    case "F":
                        tabuleiro.Add(posicao, new Casa(Cartas.Faca, linha, coluna, pnlTabuleiro));
                        break;
                    case " ":
                        tabuleiro.Add(posicao, new Casa(linha));
                        break;
                    default:
                        throw new Exception("Posição Inválida");
                }

                if (carta != " ")
                {
                    if ((sentido == 1 && coluna < 6) || (sentido == -1 && coluna > 0))
                    {
                        coluna += 1 * sentido;
                    }
                    else
                    {
                        linha++;
                        sentido *= -1;
                    }
                }

            }

            return tabuleiro;
        }

        public List<Historico> pegarHistorico(int idPartida, int inicio)
        {
            List<Historico> historicos = new List<Historico> ();

            string[] retorno = separar(Jogo.ExibirHistorico(idPartida), false);

            for(int i = inicio; i < retorno.Length; i++)
            {
                string stringHistorico = retorno[i];

                string[] array = stringHistorico.Split(',');

                int id = Convert.ToInt32(array[0]);
                int numJogada = Convert.ToInt32(array[1]);

                Historico historico;

                if (array[3] == "" && array[4] == "")
                {
                    historico = new Historico(id, numJogada);
                }
                else if (array[2] == "")
                {
                    int origem = Convert.ToInt32(array[3]);
                    int destino = Convert.ToInt32(array[4]);

                    historico = new Historico(id, numJogada, origem, destino);
                }
                else
                {
                    int origem = Convert.ToInt32(array[3]);
                    int destino = Convert.ToInt32(array[4]);
                    Cartas carta = tratarCarta(array[2]);

                    historico = new Historico(id, numJogada, carta, origem, destino);
                }

                historicos.Add(historico);
            }

            return historicos;
        }

        public int verificarVez(int idPartida)
        {
            string[] retorno = separar(Jogo.VerificarVez(idPartida), false);

            return Convert.ToInt32(retorno[0].Split(',')[1]);
        }
    }
}
