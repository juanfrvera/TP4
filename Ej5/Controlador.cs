using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    public class Controlador
    {
        GestorPrestamos iGestor;

        public Controlador()
        {
            iGestor = new GestorPrestamos();
        }

        public bool ValidarSolicitud(SolicitudPrestamo pSolicitud)
        {
            return iGestor.EsValida(pSolicitud);
        }
    }
}