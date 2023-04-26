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
        public int numeroJogada { get; }

        public Vez(Status status, int idJogador, int numeroJogada) {
            this.status = status;
            this.idJogador = idJogador;
            this.numeroJogada = numeroJogada;
        }

        public override string ToString()
        {
            return $"{idJogador} ({numeroJogada})";
        }
    }
}
