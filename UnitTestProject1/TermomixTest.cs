using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace UnitTestProject1
{
    [TestClass]
    public class TermomixTest
    {
        [TestMethod]
        public void TestPrepararPlato()
        {
            Alimento lechuga = new Alimento();
            Alimento tomate = new Alimento();
            lechuga.peso = 2;
            tomate.peso = 2;

            Termomix sut = new Termomix();
            sut.calentar = new CalentarMock();
            sut.pesar = new PesarMock();
            sut.PreparaPlatos(lechuga, tomate);

        }

        public class PesarMock : IPesar
        {
            public int PesarAlimentos(Alimento a1, Alimento a2)
            {
                return 8;
            }
        }

        public class CalentarMock : ICalentar
        {
            public void CalentarAlimentos(Alimento a1, Alimento a2)
            {
                
            }
        }
    }
}
