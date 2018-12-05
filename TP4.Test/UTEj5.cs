using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej5;

namespace TP4.Test
{
    [TestClass]
    public class UTEj5
    {
        [TestMethod]
        public void TestMethod1()
        {
            Controlador cont = new Controlador();
            Cliente cliente = new Cliente("Carlos","Ansaldi",new DateTime(1950,1,1),new Empleo(26000,new DateTime(1976,3,1)));

            //68 anios 26000 de sueldo mas de 6 meses de antiguedad 12 cuotas 5000 de prestamo
            Assert.IsTrue(cont.ValidarSolicitud(new SolicitudPrestamo(cliente, 5000, 12)));

            Assert.IsFalse(cont.ValidarSolicitud(new SolicitudPrestamo(cliente, 5000, 13)));

            Cliente cliente2 = new Cliente("Lucas","Ansaldi",new DateTime(1997,1,3),new Empleo(10000,new DateTime(2018,8,7)));

            //No se valida porque el cliente tiene menos de 6 meses de antiguedad (fecha de hoy: 14 de Nov de 2018)
            Assert.IsFalse(cont.ValidarSolicitud(new SolicitudPrestamo(cliente2, 5000, 12)));
        }
    }
}