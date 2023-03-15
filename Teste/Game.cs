using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartagenaServer;

namespace Teste
{
    public enum Status {
        Todas,
        Abertas,
        Jogando,
        Enceradas
    }
    internal class Game
    {
        public int id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public Status status { get; set; }

        public Game(int id, string name, string date, Status status)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.status = status;
        }

        public Game(string name, string password)
        {
            this.id = Convert.ToInt32(Jogo.CriarPartida(name, password));
            this.name = name;
        }


    }
}
