using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Jogador
    {
        public int id {  get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public string cor { get; set; }

        public Jogador(int id, string nome, string cor)
        {
            this.id = id;
            this.nome = nome;
            this.cor = cor;
        }

        public Jogador(string nome)
        {
            this.nome = nome;
        }

        public void entrarPartida(Partida partida, string senha)
        {
            string[] retorno = Jogo.EntrarPartida(partida.id, this.nome, senha).Split(',');
            this.id = Convert.ToInt32(retorno[0]);
            this.senha = retorno[1];
            this.cor = retorno[2];
        }
    }
}
