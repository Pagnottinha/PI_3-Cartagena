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

        public Jogador(int id, string nome, string senha, string cor)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.cor = cor;
        }
    }
}
