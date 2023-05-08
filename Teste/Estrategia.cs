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
        protected int numeroJogada;

        public Estrategia(Dictionary<int, Casa> tabuleiro, Jogador Jogador)
        {
            this.tabuleiro = tabuleiro;
            this.Jogador = Jogador;
            numeroJogada = 0;
        }

        public abstract void jogadaAutomatica();
    }
}
