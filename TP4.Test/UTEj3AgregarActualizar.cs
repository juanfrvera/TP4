using System;
using Ej3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TP4.Test
{
    [TestClass]
    public class UTEj3AgregarActualizar
    {
        [TestMethod]
        public void TestMethod1()
        {
            ListaUsuarios lista = new ListaUsuarios();
            Usuario us = new Usuario("101","Heraldo de la Grieta","hg10@gmail.com");
            Usuario us2 = new Usuario("102", "Coronel Ansaldi", "ansaldi42@hotmail.com");
            Usuario us3 = new Usuario("998", "Sargento Dilatro", "brillantinaEh@hotmail.com");
            lista.Agregar(us);
            lista.Agregar(us2);
            lista.Agregar(us3);
            Assert.AreEqual(us.NombreCompleto, lista.ObtenerPorCodigo("101").NombreCompleto);
            us.NombreCompleto = "Gerardo de la Grieta";
            lista.Actualizar(us);
            Assert.AreEqual("Gerardo de la Grieta", lista.ObtenerPorCodigo("101").NombreCompleto);
        }
    }
}
