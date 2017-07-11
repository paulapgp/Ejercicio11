using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace UnitTestProject1
{
    [TestClass]
    public class CalentarTest
    {
        [TestMethod]
        public void TestCalentarAlimentos()
        {
            Alimento lechuga = new Alimento();
            Alimento tomate = new Alimento();
            lechuga.Peso = 2;
            tomate.Peso = 2;

            Calentar sut = new Calentar();
            sut.CalentarAlimentos(lechuga, tomate);

            Assert.IsTrue(lechuga.Calentado);
            Assert.IsTrue(tomate.Calentado);
        }
    }
}
