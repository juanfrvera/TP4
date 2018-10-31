using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    public class Matematica
    {
        /// <summary>
        /// Divide ambos numeros enteros, el resultado puede ser de punto flotante
        /// Al tratar de dividir por cero, arroja la excepcion "DivisionPorCeroException"
        /// </summary>
        /// <param name="dividendo"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public float Dividir(int dividendo, int divisor)
        {
            if (divisor == 0f)
                throw new DivisionPorCeroException("No se puede dividir por cero");

            return ((float)dividendo) / ((float)divisor);
        }
    }
}
