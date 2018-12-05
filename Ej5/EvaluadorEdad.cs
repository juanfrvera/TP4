using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class EvaluadorEdad : IEvaluador
    {
        private int iEdadMinima;
        private int iEdadMaxima;
        //Constructor
        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            this.iEdadMinima = pEdadMinima;
            this.iEdadMaxima = pEdadMaxima;
        }
        //Metodos

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            int edad = (DateTime.Now - pSolicitud.Cliente.FechaNacimiento).Days/365;
            return edad >= iEdadMinima && edad <= iEdadMaxima;
        }
    }
}
