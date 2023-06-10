using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class EstrategiaInicial2 : Estrategia
    {

        public EstrategiaInicial2(Dictionary<int, Casa> tabuleiro, Jogador Jogador)
           : base(tabuleiro, Jogador) { }

        public override void jogadaAutomatica()
        {
            while (numeroJogada < 3)
            {
                tentarComprarCartas();

                realizarJogada();

                if (qntPeoesInicio() == 0)
                {
                    estrategia = new EstrategiaDefensiva(tabuleiro, Jogador, numeroJogada);

                    estrategia.jogadaAutomatica();
                    return;
                }
            }

            numeroJogada = 0;
        }

        void realizarJogada()
        {
            if (Jogador.qntCartas == 0)
            {
                Jogador.peoes.Sort((Peao peao1, Peao peao2) => peao1.posicao < peao2.posicao ? 1 : -1);

                if (voltaPraOnde(Jogador.peoes[0].posicao) != 0 == numeroJogada < 3)
                {
                    Jogador.Jogar(Jogador.peoes[0].posicao, tabuleiro);
                    numeroJogada++;
                }

                return;
            }

            int qntPeoesNoInicio = qntPeoesInicio();

            Dictionary<Cartas, int> movimentacaoPrimeiro = paraOndeVai(0);

            List<KeyValuePair<Cartas, int>> list = movimentacaoPrimeiro.ToList();

            for(int i = 5; i > 0 && numeroJogada < 3; i--)
            {
                KeyValuePair<Cartas, int> keyValuePair = list[i];

                if (Jogador.cartas[keyValuePair.Key] > 0)
                {
                    int posOndeVolta = voltaPraOnde(keyValuePair.Value);
                    int qntPeoesOndeVolta = tabuleiro[posOndeVolta].peoes.Count;

                    if (qntPeoesOndeVolta == 2 && posOndeVolta != 0)
                    {
                        Jogador.Jogar(0, cartaPraString(keyValuePair.Key), tabuleiro);
                        numeroJogada++;
                        return;
                    }

                    Peao p1 = peaoProximo(keyValuePair.Value);

                    if (p1 != null && qntPeoesOndeVolta == 1 && posOndeVolta != 0)
                    {
                        Jogador.Jogar(0, cartaPraString(keyValuePair.Key), tabuleiro);
                        numeroJogada++;
                        return;
                    }
                }
                
            }

            if (numeroJogada == 0 && qntPeoesNoInicio >= 2)
            {
                List<Cartas> cartasJogaveis = new List<Cartas>();

                foreach(KeyValuePair<Cartas, int> keyValuePair in Jogador.cartas)
                {
                    if (keyValuePair.Value >= 2)
                    {
                        cartasJogaveis.Add(keyValuePair.Key);
                    }
                }

                List<int> maximo = new List<int>();
                List<int> aux = new List<int>();

                for (int i = 0; i < cartasJogaveis.Count; i++)
                {
                    Cartas carta = cartasJogaveis[i];

                    int pos1 = movimentacaoPrimeiro[carta];

                    aux.Add(pos1);

                    int pos2 = paraOndeVai(pos1, carta);
                    
                    if (Jogador.cartas[tabuleiro[pos2 + 1].carta] > 0 && tabuleiro[pos2 + 1].peoes.Count == 0 && paraOndeVai(pos1, tabuleiro[pos2 + 1].carta) == pos2 + 1)
                    {
                        if (tabuleiro[pos2 + 1].carta != carta || (tabuleiro[pos2 + 1].carta == carta && Jogador.cartas[tabuleiro[pos2 + 1].carta] >= 3))
                        {
                            aux.Add(pos2 + 1);
                        }
                    }
                    else if (Jogador.cartas[tabuleiro[pos2 - 1].carta] > 0 && tabuleiro[pos2 - 1].peoes.Count == 0 && paraOndeVai(pos1, tabuleiro[pos2 - 1].carta) == pos2 - 1)
                    {
                        if (tabuleiro[pos2 - 1].carta != carta || (tabuleiro[pos2 - 1].carta == carta && Jogador.cartas[tabuleiro[pos2 - 1].carta] >= 3))
                        {
                            aux.Add(pos2 - 1);
                        }
                    }

                    if (maximo.Count < aux.Count)
                    {
                        maximo.Clear();
                        maximo.AddRange(aux);
                    }
                    else if (maximo.Count == aux.Count)
                    {
                        if (maximo[maximo.Count - 1] < aux[maximo.Count - 1])
                        {
                            maximo.Clear();
                            maximo.AddRange(aux);
                        }
                    }

                    aux.Clear();
                }

                if (maximo.Count == 2)
                {
                    Jogador.Jogar(0, cartaPraString(tabuleiro[maximo[0]].carta), tabuleiro);
                    Jogador.Jogar(0, cartaPraString(tabuleiro[maximo[0]].carta), tabuleiro);

                    Jogador.Jogar(maximo[0], cartaPraString(tabuleiro[maximo[1]].carta), tabuleiro);

                    numeroJogada += 3;

                }
                else if (maximo.Count == 1)
                {
                    Jogador.Jogar(0, cartaPraString(tabuleiro[maximo[0]].carta), tabuleiro);
                    Jogador.Jogar(0, cartaPraString(tabuleiro[maximo[0]].carta), tabuleiro);
                    jogarPeaoLonge(maximo[0]);

                    numeroJogada += 3;
                }
                else
                {
                    jogarPeaoLonge(0);
                }

                return;
            }
            else if (numeroJogada < 3)
            {
                jogarPeaoLonge(0);
            }
        }

        int qntPeoesInicio()
        {
            int cont = 0;

            foreach(Peao peao in Jogador.peoes)
            {
                if (peao.posicao == 0)
                {
                    cont++;
                }
            }

            return cont;
        }

        void tentarComprarCartas()
        {
            Jogador.peoes.Sort((Peao peao1, Peao peao2) => peao1.posicao < peao2.posicao ? 1 : -1);

            for (int i = 5; i > 0 && numeroJogada < 3; i--)
            {
                Peao peao = Jogador.peoes[i];
                
                int pos = voltaPraOnde(peao.posicao);

                if (pos > 0 && tabuleiro[pos].peoes.Count == 2)
                {
                    Jogador.Jogar(peao.posicao, tabuleiro);
                    numeroJogada++;
                    
                    return;
                }
                
            }

            for (int i = 1; i < Jogador.peoes.Count && numeroJogada < 2; i++)
            {
                Peao peao = Jogador.peoes[i];

                Peao proximo = peaoProximo(peao.posicao);

                int ondeVolta = voltaPraOnde(peao.posicao);

                if (proximo != null && tabuleiro[ondeVolta].peoes.Count == 1 && ondeVolta != 0)
                {
                    if (numeroJogada == 1)
                    {
                        Jogador.Jogar(peao.posicao, tabuleiro);
                        Jogador.Jogar(proximo.posicao, tabuleiro);
                        numeroJogada += 2;
                    }
                    else if (numeroJogada == 0)
                    {
                        if (tabuleiro[peao.posicao].peoes.Count < 3)
                        {
                            Jogador.Jogar(proximo.posicao, tabuleiro);
                            Jogador.Jogar(proximo.posicao, tabuleiro);
                            Jogador.Jogar(peao.posicao, tabuleiro);
                            numeroJogada += 3;
                        }
                        else
                        {
                            Jogador.Jogar(peao.posicao, tabuleiro);
                            Jogador.Jogar(proximo.posicao, tabuleiro);
                            Jogador.Jogar(proximo.posicao, tabuleiro);
                            numeroJogada += 3;
                        }
                    }
                }
            }
        }

        protected override Peao peaoProximo(int posicaoPeao)
        {
            for (int i = posicaoPeao + 1; i < 37; i++)
            {
                Casa casa = tabuleiro[i];
                Peao peaoProximo = casa.peoes.Find(p => p.jogador == Jogador);

                if (peaoProximo != null)
                {
                    return peaoProximo;
                }
                else if (casa.peoes.Count > 0)
                {
                    return null;
                }
            }

            return null;
        }

    }
}
