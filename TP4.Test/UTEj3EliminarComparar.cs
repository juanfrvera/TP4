using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej3;

namespace TP4.Test
{
    [TestClass]
    public class UTEj3EliminarComparar
    {
        [TestMethod]
        [ExpectedException(typeof(System.Collections.Generic.KeyNotFoundException))]
        public void TestMethod1()
        {
            ListaUsuarios lista = new ListaUsuarios();
            Usuario us = new Usuario("101", "Heraldo de la Grieta", "hg10@gmail.com");
            Usuario us2 = new Usuario("102", "Coronel Ansaldi", "ansaldi42@hotmail.com");
            Usuario us3 = new Usuario("998", "Sargento Dilatro", "brillantinaEh@hotmail.com");
            lista.Agregar(us);
            lista.Agregar(us2);
            lista.Agregar(us3);

            Assert.AreEqual(lista.Compare(us, us2), -1);

            lista.Eliminar("102");
            //Probamos si se elimino
            Assert.AreEqual(2, lista.ObtenerTodos().Count);
            lista.ObtenerPorCodigo("102");
        }
    }
}
