using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TP4.Test
{
    [TestClass]
    public class UTEj1
    {
        [TestMethod]
        [ExpectedException(typeof(DivisionPorCeroException))]
        public void TestMethod1()
        {
            Matematica mat = new Matematica();
            Assert.AreEqual(4, mat.Dividir(8, 2));
            mat.Dividir(3, 0);
        }
    }
}
