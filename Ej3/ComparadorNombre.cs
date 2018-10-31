using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    public class ComparadorNombre : IComparer<Usuario>
    {
        int IComparer<Usuario>.Compare(Usuario x, Usuario y)
        {
            //Comparar por nombre y guardar el resultado
            int resultado = x.NombreCompleto.CompareTo(y.NombreCompleto);
            //Si los nombres son distintos devolver el resultado de la comparacion
            if (resultado != 0)
                return resultado;
            else//Si los nombres son iguales comparar por defecto
                return x.CompareTo(y);
        }
    }
}
