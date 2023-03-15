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

        public async Task<List<Game>> getGames(string s)
        {
            string request = await Task<string>.Factory.StartNew(() =>
            {
                return Jogo.ListarPartidas(s);
            });

            List<string> gamesR = request.Replace("\r", "").Split('\n').ToList();

            gamesR.Remove("");

            List<Game> games = new List<Game>();

            foreach (string game in gamesR)
            {
                string[] args = game.Split(',');

                int id = Convert.ToInt32(args[0]);
                string name = args[1];
                string date = args[2];

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

                games.Add(new Game(id, name, date, status));
            }

            return games;
        }
    }
}
