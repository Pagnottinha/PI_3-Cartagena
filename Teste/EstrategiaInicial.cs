using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            while(numeroJogada < 3)
            {
                for (int i = 0; i < Jogador.peoes.Count && numeroJogada < 3; i++)
                {
                    Peao peao = Jogador.peoes[i];
          
                    if (voltarComprarDuas(peao.posicao))
                    {
                        Jogador.Jogar(peao.posicao, tabuleiro);
                        numeroJogada++;

                        if (tabuleiro[peao.posicao].peoes.Count == 2)
                        {
                            Peao proximo = peaoProximo(peao.posicao);
                            Jogador.Jogar(proximo.posicao, tabuleiro);
                            numeroJogada++;
                        }
                    }
                }

                List<(int, Cartas)> jogadas = pegarJogadas();

                if (jogadas.Count == 0)
                {
                    if (tabuleiro[0].peoes.Find(peao => peao.jogador == Jogador) == null)
                    {
                        int qntCartas = numeroCartas();

                        if (qntCartas > 12)
                        {
                            estrategia = new EstrategiaAgressiva(tabuleiro, Jogador, numeroJogada);
                        }
                        else
                        {
                            estrategia = new EstrategiaDefensiva(tabuleiro, Jogador, numeroJogada);
                        }

                        estrategia.jogadaAutomatica();
                        return;
                    }

                    pularTurnos();
                }

                foreach ((int posicao, Cartas carta) in jogadas)
                {

                    Jogador.Jogar(posicao, cartaPraString(carta), tabuleiro);
                    numeroJogada++;
                }
            }

            numeroJogada = 0;
        }

        List<(int, Cartas)> pegarJogadas() {
            List<(int, Cartas)> posicaoParaJogar = new List<(int, Cartas)>();

            int jogadasFaltando = 3 - numeroJogada;

            if (jogadasFaltando == 0)
            {
                return posicaoParaJogar;
            }

            Dictionary<Cartas, int> movimentacao = paraOndeVai(0);

            List<Cartas> simbolosDisponiveis = new List<Cartas>();

            foreach(Cartas carta in movimentacao.Keys)
            {
                if (Jogador.cartas[carta] > 0)
                {
                    simbolosDisponiveis.Add(carta);
                }
            }

            if (simbolosDisponiveis.Count == 0)
            {
                return posicaoParaJogar;
            }

            int peoesNoComeco = 0;
            foreach(Peao peao in Jogador.peoes)
            {
                if (peao.posicao == 0)
                {
                    peoesNoComeco++;
                }
            }

            jogadasFaltando = peoesNoComeco < jogadasFaltando ? peoesNoComeco : jogadasFaltando;

            if (jogadasFaltando == 1)
            {
                int maisLonge = 0;

                foreach(Cartas carta in simbolosDisponiveis)
                {
                    if (movimentacao[carta] > maisLonge)
                    {
                        maisLonge = movimentacao[carta];
                    }
                }

                posicaoParaJogar.Add((0, tabuleiro[maisLonge].carta));
            }
            else if (jogadasFaltando == 2)
            {
                int posicaoAnterior = movimentacao[simbolosDisponiveis[0]];

                for (int i = 1; i < simbolosDisponiveis.Count && posicaoParaJogar.Count == 0; i++)
                {
                    Cartas carta = simbolosDisponiveis[i];

                    if (posicaoAnterior + 1 == movimentacao[carta])
                    {
                        posicaoParaJogar.Add((0, tabuleiro[movimentacao[carta]].carta));
                    }
                    else
                    {
                        posicaoAnterior = movimentacao[carta];
                    }
                }

                posicaoParaJogar.Add((0, tabuleiro[posicaoAnterior].carta));
            }
            else if (jogadasFaltando == 3)
            {
                List<int> maximo = new List<int>();

                List<int> aux = new List<int>() { movimentacao[simbolosDisponiveis[0]] };

                for (int i = 1; i < simbolosDisponiveis.Count && maximo.Count < 3; i++)
                {
                    Cartas carta = simbolosDisponiveis[i];

                    if (aux[aux.Count - 1] + 1 != movimentacao[carta])
                    {
                        aux.Clear();
                    }
                        
                    aux.Add(movimentacao[carta]);

                    if (maximo.Count < aux.Count)
                    {
                        maximo.Clear();
                        maximo.AddRange(aux);
                    }
                }

                foreach(int i in maximo)
                {
                    posicaoParaJogar.Add((0, tabuleiro[i].carta));
                }
            }

            return posicaoParaJogar;
        }
    }
}
