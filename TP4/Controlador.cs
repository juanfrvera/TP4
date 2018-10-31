using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class Controlador
    {
        private Matematica mat;


        public float Dividir(int dividendo, int divisor)
        {
            if (mat == null) mat = new Matematica();

            return mat.Dividir(dividendo, divisor);
        }
    }
}
