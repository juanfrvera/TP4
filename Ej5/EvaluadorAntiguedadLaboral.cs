using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class EvaluadorAntiguedadLaboral : IEvaluador
    {
        private int iAntiguedadMinima;

        //Constructor

        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }
        //Metodos

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            int meses = (DateTime.Now - pSolicitud.Cliente.Empleo.FechaIngreso).Days / 30;
            return meses >= iAntiguedadMinima;
        }
    }
}