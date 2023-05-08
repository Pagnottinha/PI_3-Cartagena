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
            foreach(Peao peao in Jogador.peoes) {
                if (voltarComprarDuas(peao))
                {
                    Jogador.Jogar(peao.posicao, tabuleiro);
                    numeroJogada++;
                    return;
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
              
                numeroJogada = 0;

                return;
            }

            foreach((int posicao, Cartas carta) in jogadas)
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

        List<(int, Cartas)> pegarJogadas() {
            List<(int, Cartas)> posicaoParaJogar = new List<(int, Cartas)>();

            int jogadasFaltando = 3 - numeroJogada;

            if (jogadasFaltando == 0)
            {
                return posicaoParaJogar;
            }
            // Jogador.peoes.Sort((Peao p1, Peao p2) => p1.posicao >= p2.posicao ? 1 : -1);

            Dictionary<Peao, Dictionary<Cartas, int>> movimentoPeoes = new Dictionary<Peao, Dictionary<Cartas, int>>();
            
            foreach(Peao peao in Jogador.peoes)
            {
                movimentoPeoes.Add(peao, paraOndeVai(peao));
            }

            return posicaoParaJogar;
        }

        Dictionary<Cartas, int> paraOndeVai(Peao peao)
        {
            Dictionary<Cartas, int> posicoes = new Dictionary<Cartas, int>();

            for (int i = peao.posicao; i < 37 && posicoes.Count < 6; i++)
            {
                Casa casa = tabuleiro[i];

                if (casa.peoes.Count == 0 && !posicoes.TryGetValue(casa.carta, out _))
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
                    if (!posicoes.TryGetValue(carta, out _))
                    {
                        posicoes.Add(carta, 37);
                    }
                }
            }

            return posicoes;
        }

        bool voltarComprarDuas(Peao peao)
        {
            for (int i = peao.posicao; i > 1; i--)
            {
                int qntPeoes = tabuleiro[i].peoes.Count;

                if (qntPeoes == 1)
                {
                    if (numeroJogada < 3)
                    {
                        return proximoPeao(peao);
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

        bool proximoPeao(Peao peao)
        {
            for (int i = peao.posicao; i < 37; i++)
            {
                Casa casa = tabuleiro[peao.posicao];
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
