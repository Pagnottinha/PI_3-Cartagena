using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Vez
    {
        public Status status { get; }
        public int idJogador { get; }

        public Jogador Jogador { get; private set; }
        public int numeroJogada { get; }

        public Vez(Status status, int idJogador, int numeroJogada) {
            this.status = status;
            this.idJogador = idJogador;
            this.numeroJogada = numeroJogada;
        }

        public void pegarJogador(List<Jogador> jogadores)
        {
            foreach(Jogador jogador in jogadores)
            {
                if (jogador.id == idJogador)
                {
                    Jogador = jogador;
                    return;
                }
            }
        }

        public override string ToString()
        {
            if (Jogador == null)
            {
                return $"{idJogador} ({numeroJogada})";
            }
            else
            {
                return $"{Jogador.nome} - {idJogador} ({numeroJogada}) - {Jogador.cor}";
            }
        }
    }
}
