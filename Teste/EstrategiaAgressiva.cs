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
            int qntCartas = numeroCartas();

            if (qntCartas <= 3)
            {
                estrategia = new EstrategiaDefensiva(tabuleiro, Jogador, numeroJogada);
                estrategia.jogadaAutomatica();
                return;
            }

            int qntVezes = 3 - numeroJogada;

            for (int i = 0; i < qntVezes; i++)
            {
                Jogador.peoes.Sort((Peao peao1, Peao peao2) => peao1.posicao > peao2.posicao ? 1 : -1);

                Peao peao = Jogador.peoes[0];

                Dictionary<Cartas, int> movimentacao = paraOndeVai(peao.posicao);

                bool continua = true;

                List<KeyValuePair<Cartas, int>> movimentacaoList = movimentacao.ToList();

                for (int j = movimentacao.Count - 1; j >= 0 && continua; j--)
                {
                    Cartas carta = movimentacaoList[j].Key;

                    if (Jogador.cartas[carta] > 0)
                    {
                        Jogador.Jogar(peao.posicao, cartaPraString(carta), tabuleiro);
                        numeroJogada++;
                        continua = false;
                    }
                }
            }

            pularTurnos();

            numeroJogada = 0;
        }
    }
}
