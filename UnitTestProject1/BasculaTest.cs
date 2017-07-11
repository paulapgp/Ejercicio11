using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace UnitTestProject1
{
    [TestClass]
    public class BasculaTest
    {
        [TestMethod]
        public void TestPesarAlimentos()
        {
            Alimento lechuga = new Alimento();
            Alimento tomate = new Alimento();
            lechuga.Peso = 2;
            tomate.Peso = 2;

            IBascula sut = new BasculaService();
            float peso1 = sut.PesarAlimentos(lechuga);
            float peso2 = sut.PesarAlimentos(tomate);

            float resultado = peso1 + peso2;

            Assert.AreEqual(resultado, 4);
        }
    }
}
