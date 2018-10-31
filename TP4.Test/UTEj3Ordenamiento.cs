using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej3;
using System.Collections.Generic;

namespace TP4.Test
{
    [TestClass]
    public class UTEj3Ordenamiento
    {
        [TestMethod]
        public void TestMethod1()
        {
            ListaUsuarios lista = new ListaUsuarios();
            Usuario us = new Usuario("102", "Heraldo de la Grieta", "hg10@gmail.com");
            Usuario us2 = new Usuario("100", "Coronel Ansaldi", "ansaldi42@hotmail.com");
            Usuario us3 = new Usuario("998", "Sargento Dilatro", "brillantinaEh@hotmail.com");
            Usuario us4 = new Usuario("55", "Vladimir Nutini", "calleFalsa123@outlook.com");
            lista.Agregar(us);
            lista.Agregar(us2);
            lista.Agregar(us3);
            lista.Agregar(us4);

            //Ordenamiento por defecto (por codigo alfabeticamente)
            IList<Usuario> listaOrd = lista.ObtenerTodos();
            Assert.AreEqual(listaOrd[0], us2);
            Assert.AreEqual(listaOrd[1], us);
            Assert.AreEqual(listaOrd[2], us4);
            Assert.AreEqual(listaOrd[3], us3);
            //Ordenamiento por nombre
            listaOrd = lista.ObtenerOrdenadosPor(new ComparadorNombre());
            Assert.AreEqual(listaOrd[0], us2);
            Assert.AreEqual(listaOrd[1], us);
            Assert.AreEqual(listaOrd[2], us3);
            Assert.AreEqual(listaOrd[3], us4);
            //Ordenamiento por nombre descendente
            listaOrd = lista.ObtenerOrdenadosPor(new ComparadorNombreDescendente());
            Assert.AreEqual(listaOrd[0], us4);
            Assert.AreEqual(listaOrd[1], us3);
            Assert.AreEqual(listaOrd[2], us);
            Assert.AreEqual(listaOrd[3], us2);
            //Ordenamiento por correo
            listaOrd = lista.ObtenerOrdenadosPor(new ComparadorCorreo());
            Assert.AreEqual(listaOrd[0], us2);
            Assert.AreEqual(listaOrd[1], us3);
            Assert.AreEqual(listaOrd[2], us4);
            Assert.AreEqual(listaOrd[3], us);
        }
    }
}
