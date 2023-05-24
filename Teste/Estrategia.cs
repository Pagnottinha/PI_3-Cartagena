using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    abstract internal class Estrategia
    {
        static protected Estrategia estrategia;

        protected Dictionary<int, Casa> tabuleiro;
        protected Jogador Jogador;
        protected int numeroJogada;

        protected Estrategia(Dictionary<int, Casa> tabuleiro, Jogador Jogador, int numeroJogada)
        {
            this.tabuleiro = tabuleiro;
            this.Jogador = Jogador;
            this.numeroJogada = numeroJogada;
        }

        protected Estrategia(Dictionary<int, Casa> tabuleiro, Jogador Jogador) : 
            this(tabuleiro, Jogador, 0) { }

        static public Estrategia comecarEstrategia(Dictionary<int, Casa> tabuleiro, Jogador Jogador)
        {
            if (estrategia == null)
            {
                estrategia = new EstrategiaInicial(tabuleiro, Jogador);
            }

            return estrategia;
        }

        public abstract void jogadaAutomatica();

        protected int numeroCartas()
        {
            int qntCartas = 0;

            foreach (int qnt in Jogador.cartas.Values)
            {
                qntCartas += qnt;
            }

            return qntCartas;
        }

        protected Dictionary<Cartas, int> paraOndeVai(int posicaoPeao)
        {
            Dictionary<Cartas, int> posicoes = new Dictionary<Cartas, int>();

            for (int i = posicaoPeao + 1; i < 37 && posicoes.Count < 6; i++)
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

                foreach (Cartas carta in cartas)
                {
                    if (!posicoes.ContainsKey(carta))
                    {
                        posicoes.Add(carta, 37);
                    }
                }
            }

            return posicoes;
        }

        protected int voltaPraOnde(int posicaoPeao)
        {
            for (int i = posicaoPeao - 1; i > 0; i--)
            {
                int qntPeoes = tabuleiro[i].peoes.Count;

                if (qntPeoes > 0 && qntPeoes < 3)
                {
                    return i;
                }
            }

            return 0;
        }

        protected bool voltarComprarDuas(int posicaoPeao)
        {
            int ondeVolta = voltaPraOnde(posicaoPeao);

            if (ondeVolta == 0)
            {
                return false;
            }

            int qntPeoes = tabuleiro[ondeVolta].peoes.Count;

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

        protected Peao peaoProximo(int posicaoPeao)
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

        protected bool deveVoltar(int posicaoPeao)
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

        protected string cartaPraString(Cartas carta)
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

            return c;
        }

        protected void pularTurnos()
        {
            while (numeroJogada < 3)
            {
                Jogador.Jogar();
                numeroJogada++;
            }
        }
    }
}
