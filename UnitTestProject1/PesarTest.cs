using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace UnitTestProject1
{
    [TestClass]
    public class PesarTest
    {
        [TestMethod]
        public void TestPesarAlimentos()
        {
            Alimento lechuga = new Alimento();
            Alimento tomate = new Alimento();
            lechuga.peso = 2;
            tomate.peso = 2;

            Pesar sut = new Pesar();
           int resultado = sut.PesarAlimentos(lechuga, tomate);

            Assert.AreEqual(resultado, 4);
        }
    }
}
