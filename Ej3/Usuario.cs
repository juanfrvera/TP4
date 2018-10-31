using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    public class Usuario : IComparable<Usuario>
    {
        private String iCodigo;
        public String Codigo { get { return iCodigo; } set { iCodigo = value; } }

        String iNombreCompleto;
        public String NombreCompleto { get { return iNombreCompleto; } set { iNombreCompleto = value; } }

        String iCorreoElectronico;
        public String CorreoElectronico { get { return iCorreoElectronico; } set { iCorreoElectronico = value; } }
        
        public Usuario(String pCodigo, String pNombreCompleto, String pCorreoElectronico)
        {
            this.Codigo = pCodigo;
            this.NombreCompleto = pNombreCompleto;
            this.CorreoElectronico = pCorreoElectronico;
        }

        /// <summary>
        /// Comparacion por codigo alfabeticamente
        /// -1 si el codigo de este usuario es menor al de 'other'
        /// 0 si son iguales, y 1 si el codigo de este es mayor al de 'other'
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Usuario other)
        {
            return String.Compare(this.iCodigo, other.Codigo);
        }
    }
}
