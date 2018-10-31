using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    public class ComparadorCorreo : IComparer<Usuario>
    {
        //Asumimos que los correos no pueden ser iguales
        int IComparer<Usuario>.Compare(Usuario x, Usuario y)
        {
            return x.CorreoElectronico.CompareTo(y.CorreoElectronico);
        }
    }
}