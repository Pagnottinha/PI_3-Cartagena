using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    abstract internal class Estrategia
    {
        protected Dictionary<int, Casa> tabuleiro;
        protected Jogador Jogador;

        public Estrategia(Dictionary<int, Casa> tabuleiro, Jogador Jogador)
        {
            this.tabuleiro = tabuleiro;
            this.Jogador = Jogador;
        }

        public abstract void jogadaAutomatica();
    }
}
