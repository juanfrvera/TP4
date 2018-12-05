using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej4;
using System.Collections.Generic;

namespace TP4.Test
{
    [TestClass]
    public class UTEj4Aproximacion
    {
        [TestMethod]
        public void TestMethod1()
        {
            ListaUsuarios lista = new ListaUsuarios();
            Ej3.Usuario user = new Ej3.Usuario("1", "Vicente Calderon", "vcalderas@gmail.com");
            Ej3.Usuario user2 = new Ej3.Usuario("2", "Luis Vicente", "luisv@gmail.com");
            Ej3.Usuario user3 = new Ej3.Usuario("3", "Lucas Adert", "ladert@gmail.com");
            Ej3.Usuario user4 = new Ej3.Usuario("4", "Luxx LP", "lelapietra@gmail.com");
            Ej3.Usuario user5 = new Ej3.Usuario("5", "Lucia Berezaga", "lberzg@gmail.com");


            lista.Agregar(user);
            lista.Agregar(user2);
            lista.Agregar(user3);
            lista.Agregar(user4);
            lista.Agregar(user5);

            //La lista solo tiene al usuario "Vicente Calderon"
            IList<Ej3.Usuario> resultado = lista.ObtenerAproximado("Calderon");

            resultado[0].NombreCompleto = "Ansaldi Carlos";

            //Si son iguales se cumple la defensive copy
            Assert.AreEqual(user.NombreCompleto, "Vicente Calderon");
        }
    }
}
