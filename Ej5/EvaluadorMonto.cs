using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class EvaluadorMonto : IEvaluador
    {
        private double iMontoMaximo;

        //Constructor

        public EvaluadorMonto(double pMontoMaximo)
        {
            this.iMontoMaximo = pMontoMaximo;
        }

        //Metodos

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return pSolicitud.Monto <= iMontoMaximo;
        }
    }
}
