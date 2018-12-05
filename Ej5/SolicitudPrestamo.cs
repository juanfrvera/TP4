using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    public class SolicitudPrestamo
    {
        //Variables
        private Cliente iCliente;
        private double iMonto;
        private int iCantidadCuotas;

        //Constructores
        public SolicitudPrestamo(Cliente pCliente, double pMonto, int pCantidadCuotas)
        {
            this.iCliente = pCliente;
            this.iMonto = pMonto;
            this.iCantidadCuotas = pCantidadCuotas;
        }

        //Propiedades
        public double Monto { get { return iMonto; } private set { } }
        public int CantidadCuotas { get { return iCantidadCuotas; } private set { } }
        public Cliente Cliente{ get { return iCliente; } private set { } }
    }
}