using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class EvaluadorCantidadCuotas : IEvaluador
    {
        private int iCantidadMaximaCuotas;

        public EvaluadorCantidadCuotas(int pCantidadMaximaCuotas)
        {
            this.iCantidadMaximaCuotas = pCantidadMaximaCuotas;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return pSolicitud.CantidadCuotas <= iCantidadMaximaCuotas;
        }
    }
}
