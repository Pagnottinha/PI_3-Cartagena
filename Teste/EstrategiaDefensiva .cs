﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class EstrategiaDefensiva : Estrategia
    {
        public EstrategiaDefensiva(Dictionary<int, Casa> tabuleiro, Jogador Jogador)
            : base(tabuleiro, Jogador) { }

        public EstrategiaDefensiva(Dictionary<int, Casa> tabuleiro, Jogador Jogador, int numeroJogada)
            : base(tabuleiro, Jogador, numeroJogada) { }

        public override void jogadaAutomatica()
        {

            Jogador.peoes.Sort((Peao peao1, Peao peao2) => peao1.posicao > peao2.posicao ? 1 : -1);

            Dictionary<Cartas, int> movimentacaoUltimo = paraOndeVai(Jogador.peoes[0].posicao);

            foreach (KeyValuePair<Cartas, int> valuePair in movimentacaoUltimo)
            {
                if (valuePair.Value > 30)
                {
                    int peoesAntes = 0;

                    foreach (Peao p in Jogador.peoes)
                    {
                        if (valuePair.Value > p.posicao)
                        {
                            peoesAntes++;
                        }
                    }

                    int qntCartas = Jogador.cartas[valuePair.Key];

                    if (qntCartas >= peoesAntes)
                    {
                        estrategia = new EstrategiaAgressiva(tabuleiro, Jogador, numeroJogada);
                        estrategia.jogadaAutomatica();
                        return;
                    }
                }
            }

            for (int i = 0; i < Jogador.peoes.Count && numeroJogada <= 1; i++)
            {
                Peao peao = Jogador.peoes[i];
                
                Dictionary<Cartas, int> movimentacao = paraOndeVai(peao.posicao);

                List<Cartas> simbolosDisponiveis = new List<Cartas>();
                    
                foreach (Cartas carta in movimentacao.Keys)
                {
                    if (Jogador.cartas[carta] > 0)
                    {
                        simbolosDisponiveis.Add(carta);
                    }
                }

                bool continua = true;

                for(int j = 0; j < simbolosDisponiveis.Count && continua; j++)
                {
                    Cartas carta = simbolosDisponiveis[j];

                    int posicao = movimentacao[carta];

                    if (voltarComprarDuas(posicao, peao))
                    {
                        Jogador.Jogar(peao.posicao, cartaPraString(carta), tabuleiro);
                        Jogador.Jogar(posicao, tabuleiro);
                        numeroJogada += 2;
                        continua = false;
                    }
                }
            }
            

            Jogador.peoes.Sort((Peao peao1, Peao peao2) => peao1.posicao < peao2.posicao ? 1 : -1);

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

            if (numeroCartas() > 15)
            {
                estrategia = new EstrategiaAgressiva(tabuleiro, Jogador, numeroJogada);
                estrategia.jogadaAutomatica();
                return;
            }

            pularTurnos();

            numeroJogada = 0;
        }

        protected int voltaPraOnde(int posicaoPeao, Peao peao)
        {
            for (int i = posicaoPeao - 1; i > 0; i--)
            {
                int qntPeoes = tabuleiro[i].peoes.Count;

                if (i == peao.posicao)
                {
                    qntPeoes--;
                }

                if (qntPeoes > 0 && qntPeoes < 3)
                {
                    return i;
                }
            }

            return 0;
        }

        bool voltarComprarDuas(int posicaoPeao, Peao peao)
        {
            int ondeVolta = voltaPraOnde(posicaoPeao, peao);

            if (ondeVolta == 0)
            {
                return false;
            }

            int qntPeoes = tabuleiro[ondeVolta].peoes.Count;

            if(ondeVolta == peao.posicao)
            {
                qntPeoes--;
            }

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


            return false;
        }
    }

}
