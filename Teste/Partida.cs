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
    internal class Partida
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string data { get; set; }
        public Status status { get; set; }

        public List<Jogador> Jogadores { get; set; }

        public Partida(int id, string nome, string data, Status status)
        {
            this.id = id;
            this.nome = nome;
            this.data = data;
            this.status = status;
        }

        public Partida(string nome, string senha)
        {
            this.id = Convert.ToInt32(Jogo.CriarPartida(nome, senha));
            this.nome = nome;
            this.senha = senha;
            this.data = DateTime.Now.ToString("d");
            this.status = Status.Abertas;
        }


    }
}
