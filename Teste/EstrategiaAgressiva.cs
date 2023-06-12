using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class EstrategiaAgressiva : Estrategia
    {
        public EstrategiaAgressiva(Dictionary<int, Casa> tabuleiro, Jogador Jogador)
            : base(tabuleiro, Jogador) { }

        public EstrategiaAgressiva(Dictionary<int, Casa> tabuleiro, Jogador Jogador, int numeroJogada)
            : base(tabuleiro, Jogador, numeroJogada) { }

        public override void jogadaAutomatica()
        {

            int qntVezes = 3 - numeroJogada;

            for (int i = 0; i < qntVezes; i++)
            {
                Jogador.peoes.Sort((Peao peao1, Peao peao2) => peao1.posicao > peao2.posicao ? 1 : -1);

                Peao peao = Jogador.peoes[0];

                if (peao.posicao == 37)
                    return;

                jogarPeaoLonge(peao.posicao);
            }

            if (Jogador.qntCartas == 0 || !finalizaJogo())
            {
                estrategia = new EstrategiaDefensiva(tabuleiro, Jogador, numeroJogada);
                estrategia.jogadaAutomatica();
                return;
            }

            numeroJogada = 0;
        }
    }
}
