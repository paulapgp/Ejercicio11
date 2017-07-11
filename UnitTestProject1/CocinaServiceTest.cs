using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace UnitTestProject1
{
    [TestClass]
    public class CocinaServiceTest
    {
        [TestMethod]
        public void TestCalentarAlimentos()
        {
            Alimento lechuga = new Alimento();
            Alimento tomate = new Alimento();

            ICocina sut = new CocinaService();
            sut.CalentarAlimentos(lechuga, tomate);

            Assert.IsTrue(lechuga.Calentado);
            Assert.IsTrue(tomate.Calentado);
        }
    }
}
