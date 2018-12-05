using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class EvaluadorCompuesto : IEvaluador
    {
        private IList<IEvaluador> iEvaluadores;

        public EvaluadorCompuesto()
        {
            this.iEvaluadores = new List<IEvaluador>();

        }

        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            iEvaluadores.Add(pEvaluador);
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            foreach (IEvaluador evaluador in iEvaluadores)
            {
                if (!evaluador.EsValida(pSolicitud))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
