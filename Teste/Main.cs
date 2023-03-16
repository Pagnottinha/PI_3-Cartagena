using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartagenaServer;

namespace Teste
{
    internal class Main
    {

        public Main() { }

        public List<Partida> pegarPartidas(string s)
        {

            string[] partidasR = Jogo.ListarPartidas(s).Replace("\r", "")
                .Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);

            List<Partida> partidas = new List<Partida>();

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

            return partidas;
        }
    }
}
