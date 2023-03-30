using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace Teste
{
    internal class JogoService
    {
        public JogoService() { }

        private string[] separar(string retorno, bool separarVirgulas)
        {
            if (retorno.StartsWith("ERRO")) throw new Exception(retorno);

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

                partida.Add(new Jogador(id, nome, cor)); 
            }

            return partida;
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

                switch (carta)
                {
                    case "E":
                        cartas.Add(Cartas.Esqueleto, qtd);
                        break;
                    
                    case "T":
                        cartas.Add(Cartas.Tricornio, qtd);
                        break;

                    case "G":
                        cartas.Add(Cartas.Garrafa, qtd);
                        break;

                    case "F":
                        cartas.Add(Cartas.Faca, qtd);
                        break;

                    case "P":
                        cartas.Add(Cartas.Pistola, qtd);
                        break;

                    case "C":
                        cartas.Add(Cartas.Chave, qtd);
                        break;

                }

            }

            return cartas;
        }

        public Jogador entrarPartida(int partidaId, string nomePlayer, string senhaPartida)
        {
            string[] retorno = separar(Jogo.EntrarPartida(partidaId, nomePlayer, senhaPartida), true);

            Jogador jogador = new Jogador(Convert.ToInt32(retorno[0]), nomePlayer, retorno[2]);
            jogador.senha = retorno[1];

            return jogador;
        }

        public int iniciarPartida(int idJogador, string senhaJogador)
        {
            return Convert.ToInt32(separar(Jogo.IniciarPartida(idJogador, senhaJogador), false)[0]);
        }

        public Status verStatusPartida(int idPartida)
        {
            string retorno = separar(Jogo.VerificarVez(idPartida), false)[0];

            switch (retorno)
            {
                case "A":
                    return Status.Aberta;
                case "J":
                    return Status.Jogando;
                case "E":
                    return Status.Encerada;
                default:
                    throw new Exception("Status desconhecido!");
            }
        }

        public Dictionary<int, Cartas> pegarTabuleiro(int idPartida)
        {
            string[] retorno = separar(Jogo.ExibirTabuleiro(idPartida), false);

            Dictionary<int, Cartas> tabuleiro = new Dictionary<int, Cartas>();

            foreach (string item in retorno)
            {
                string[] retornoTabuleiro = item.Split(',');

                int posicao = Convert.ToInt32(retornoTabuleiro[0]);

                string carta = retornoTabuleiro[1];

                switch (carta)
                {
                    case "E":
                        tabuleiro.Add(posicao, Cartas.Esqueleto);
                        break;
                    case "P":
                        tabuleiro.Add(posicao, Cartas.Pistola);
                        break;
                    case "C":
                        tabuleiro.Add(posicao, Cartas.Chave);
                        break;
                    case "T":
                        tabuleiro.Add(posicao, Cartas.Tricornio);
                        break;
                    case "G":
                        tabuleiro.Add(posicao, Cartas.Garrafa);
                        break;
                    case "F":
                        tabuleiro.Add(posicao, Cartas.Faca);
                        break;
                    case " ":
                        break;
                    default:
                        throw new Exception("Posição Inválida");
                }

            }

            return tabuleiro;
        }
    }

}
