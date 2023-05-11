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
                foreach (Peao peao in Jogador.peoes)
                {
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
                    while (numeroJogada < 3)
                    {
                        Jogador.Jogar();
                        numeroJogada++;
                    }
                }

                foreach ((int posicao, Cartas carta) in jogadas)
                {
                    string c = "";

                    switch (carta)
                    {
                        case Cartas.Esqueleto:
                            c = "E";
                            break;
                        case Cartas.Faca:
                            c = "F";
                            break;
                        case Cartas.Garrafa:
                            c = "G";
                            break;
                        case Cartas.Tricornio:
                            c = "T";
                            break;
                        case Cartas.Chave:
                            c = "C";
                            break;
                        case Cartas.Pistola:
                            c = "P";
                            break;
                    }

                    Jogador.Jogar(posicao, c, tabuleiro);
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

            // Jogador.peoes.Sort((Peao p1, Peao p2) => p1.posicao >= p2.posicao ? 1 : -1);

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

        Dictionary<Cartas, int> paraOndeVai(int posicaoPeao)
        {
            Dictionary<Cartas, int> posicoes = new Dictionary<Cartas, int>();

            for (int i = posicaoPeao; i < 37 && posicoes.Count < 6; i++)
            {
                Casa casa = tabuleiro[i];

                if (casa.peoes.Count == 0 && !posicoes.ContainsKey(casa.carta))
                {
                    posicoes.Add(casa.carta, i);
                }
            }

            if (posicoes.Count < 6)
            {
                List<Cartas> cartas = new List<Cartas>()
                {
                    Cartas.Esqueleto,
                    Cartas.Faca,
                    Cartas.Garrafa,
                    Cartas.Tricornio,
                    Cartas.Pistola,
                    Cartas.Chave
                };

                foreach(Cartas carta in cartas)
                {
                    if (!posicoes.ContainsKey(carta))
                    {
                        posicoes.Add(carta, 37);
                    }
                }
            }

            return posicoes;
        }

        bool voltarComprarDuas(int posicaoPeao)
        {
            for (int i = posicaoPeao - 1; i > 0; i--)
            {
                int qntPeoes = tabuleiro[i].peoes.Count;

                if (qntPeoes == 1)
                {
                    if (numeroJogada <= 1)
                    {
                        return deveVoltar(posicaoPeao);
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (qntPeoes == 2)
                {
                    return true;
                }
            }

            return false;
        }

        Peao peaoProximo(int posicaoPeao)
        {
            for (int i = posicaoPeao + 1; i < 37; i++)
            {
                Casa casa = tabuleiro[i];
                Peao peaoProximo = casa.peoes.Find(p => p.jogador == Jogador);

                if (peaoProximo != null)
                {
                    return peaoProximo;
                }
            }

            return null;
        }

        bool deveVoltar(int posicaoPeao)
        {
            for (int i = posicaoPeao + 1; i < 37; i++)
            {
                Casa casa = tabuleiro[i];
                Peao peaoProximo = casa.peoes.Find(p => p.jogador == Jogador);

                if (casa.peoes.Count > 0 && peaoProximo == null)
                {
                    return false;
                }
                else if (peaoProximo != null)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
