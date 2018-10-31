using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    public class DivisionPorCeroException : Exception
    {
        public DivisionPorCeroException(string message) : base(message) { }
    }
}
