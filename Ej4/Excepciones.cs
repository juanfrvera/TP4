using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    public class CodigoNoEncontradoException : Exception
    {
        public CodigoNoEncontradoException() : base("Codigo no encontrado") { }
    }
    public class CodigoRepetidoException : Exception
    {
        public CodigoRepetidoException() : base("Este codigo ya se encuentra en la lista") { }
    }
}
