using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class GestorPrestamos
    {
        private IDictionary<Cliente.Tipo, IEvaluador> iEvaluadoresPorCliente;

        public GestorPrestamos()
        {
            this.iEvaluadoresPorCliente = new Dictionary<Cliente.Tipo, IEvaluador>();
            
            this.iEvaluadoresPorCliente.Add(Cliente.Tipo.NoCliente, new EvaluadorCompuesto());
            this.iEvaluadoresPorCliente.Add(Cliente.Tipo.Cliente, new EvaluadorCompuesto());
            this.iEvaluadoresPorCliente.Add(Cliente.Tipo.ClienteGold, new EvaluadorCompuesto());
            this.iEvaluadoresPorCliente.Add(Cliente.Tipo.ClientePlatinum, new EvaluadorCompuesto());

            foreach (EvaluadorCompuesto ev in iEvaluadoresPorCliente.Values)
            {
                ev.AgregarEvaluador(new EvaluadorEdad(18, 75));
                ev.AgregarEvaluador(new EvaluadorAntiguedadLaboral(6));
                ev.AgregarEvaluador(new EvaluadorSueldo(5000));
            }
            //No cliente
            ((EvaluadorCompuesto)iEvaluadoresPorCliente[Cliente.Tipo.NoCliente]).AgregarEvaluador(
                new EvaluadorMonto(20000)
            );
            ((EvaluadorCompuesto)iEvaluadoresPorCliente[Cliente.Tipo.NoCliente]).AgregarEvaluador(
                new EvaluadorCantidadCuotas(12)
            );
            //Cliente
            ((EvaluadorCompuesto)iEvaluadoresPorCliente[Cliente.Tipo.Cliente]).AgregarEvaluador(
                new EvaluadorMonto(100000)
            );
            ((EvaluadorCompuesto)iEvaluadoresPorCliente[Cliente.Tipo.Cliente]).AgregarEvaluador(
                new EvaluadorCantidadCuotas(32)
            );
            //Cliente Gold
            ((EvaluadorCompuesto)iEvaluadoresPorCliente[Cliente.Tipo.ClienteGold]).AgregarEvaluador(
                new EvaluadorMonto(150000)
            );
            ((EvaluadorCompuesto)iEvaluadoresPorCliente[Cliente.Tipo.ClienteGold]).AgregarEvaluador(
                new EvaluadorCantidadCuotas(60)
            );
            //Cliente Platinum
            ((EvaluadorCompuesto)iEvaluadoresPorCliente[Cliente.Tipo.ClientePlatinum]).AgregarEvaluador(
                new EvaluadorMonto(200000)
            );
            ((EvaluadorCompuesto)iEvaluadoresPorCliente[Cliente.Tipo.ClientePlatinum]).AgregarEvaluador(
                new EvaluadorCantidadCuotas(60)
            );
        }
        public bool EsValida(SolicitudPrestamo pSolicitudPrestamo)
        {
            return iEvaluadoresPorCliente[pSolicitudPrestamo.Cliente.TipoCliente].EsValida(pSolicitudPrestamo);
        }
    }
}
