using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace Teste
{
    internal class Main
    {
        public BindingList<Partida> partidas { get; } = new BindingList<Partida>();
        public BindingList<Jogador> jogador { get; } = new BindingList<Jogador>();

        public Main() {
           
        }

        public void pegarPartidas(string s)
        {
            string[] partidasR = Jogo.ListarPartidas(s).Replace("\r", "")
                .Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);

            partidas.Clear();

            foreach (string partida in partidasR)
            {
                string[] args = partida.Split(',');

                int id = Convert.ToInt32(args[0]);
                string nome = args[1];
                string data = args[2];

                Status status;
                switch (args[3])
                {
                    case "A":
                        status = Status.Abertas;
                        break;
                    case "J":
                        status = Status.Jogando;
                        break;
                    case "E":
                        status = Status.Enceradas;
                        break;
                    default:
                        throw new Exception("Status inválido");
                }

                partidas.Add(new Partida(id, nome, data, status));
            }

            return;
        }

        public void pegarJogadores(int idPartida)
        {
            string[] pegarJogadores = Jogo.ListarJogadores(idPartida).Replace("\r", "")
                .Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            jogador.Clear();

            foreach(string jogadores in pegarJogadores)
            {
                string[] args = jogadores.Split(',');

                int id = Convert.ToInt32(args[0]);
                string nome = args[1];
                string cor = args[2];

                jogador.Add(new Jogador(id, nome, cor)); 
            }
        }
    }
}
