using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class EstrategiaInicial2 : Estrategia
    {
        bool estrategiaRealizada = false;

        public EstrategiaInicial2(Dictionary<int, Casa> tabuleiro, Jogador Jogador)
           : base(tabuleiro, Jogador) { }

        public override void jogadaAutomatica()
        {
            Dictionary<Cartas, int> cartas = new Dictionary<Cartas, int>(Jogador.cartas);
            List<Cartas> listaCartas = new List<Cartas>();

            foreach(Cartas cartasJogaveis in cartas.Keys)
            {
                if (cartas[cartasJogaveis] > 1)
                    listaCartas.Add(cartasJogaveis);
            }

            if(listaCartas.Count > 0 && !estrategiaRealizada)
            {
                for (int i = 6; i > 0; i--)
                {
                    Casa casa = tabuleiro[i];

                    if (listaCartas.Contains(casa.carta))
                    {
                        Jogador.Jogar(0, cartaPraString(casa.carta), tabuleiro);
                        Jogador.Jogar(0, cartaPraString(casa.carta), tabuleiro);

                        Dictionary<Cartas, int> ondeVai = paraOndeVai(i);

                        Cartas cartaParaJogar = Cartas.Garrafa; //atribuição apenas para ele parar de reclamar
                        int maiorPosicao = 0;

                        foreach(Cartas cartas2 in ondeVai.Keys)
                        {
                            if (ondeVai[cartas2] > maiorPosicao && Jogador.cartas[cartas2] > 0)
                            {
                                maiorPosicao = ondeVai[cartas2];
                                cartaParaJogar = cartas2;
                            }
                                
                        }

                        Jogador.Jogar(i, cartaPraString(cartaParaJogar), tabuleiro);

                        numeroJogada += 3;
                        break;
                    }
                }
                estrategiaRealizada = true;
            }  
            else
                estrategia = new EstrategiaInicial(tabuleiro, Jogador);
            
        }


    }
}
