using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class PartidaAbertaException : Exception
    {
        public PartidaAbertaException() : base() { }

        public PartidaAbertaException(string message) : base(message) { }
    }
}
