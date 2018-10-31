using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class SaldoInvalidoException : Exception
    {
        public SaldoInvalidoException(string message) : base(message){}
    }
}
