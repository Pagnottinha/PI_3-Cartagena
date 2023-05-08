using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class EstrategiaInicial : Estrategia
    {
        public EstrategiaInicial(Dictionary<int, Casa> tabuleiro, Jogador Jogador)
            : base(tabuleiro, Jogador) { }

        public override void jogadaAutomatica()
        {
            foreach(Peao peao in Jogador.peoes) {
                if (voltarComprarDuas(peao))
                {
                    Jogador.Jogar(peao.posicao, tabuleiro);
                    return;
                }


            }
        }

        bool voltarComprarDuas(Peao peao)
        {
            for (int i = peao.posicao; i > 1; i--)
            {
                switch(tabuleiro[i].peoes.Count)
                {
                    case 1:
                        return false;
                    case 2:
                        return true;
                }
            }

            return false;
        }
    }
}
