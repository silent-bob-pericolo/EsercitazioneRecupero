using Microsoft.VisualStudio.TestTools.UnitTesting;
using EserciziLibrary;

namespace EserciziLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcoloPercentualeTest()
        {
            double numero = 200;
            double scontoaspettato = 20;
            double scontoeffettivo = GestioneTest.Sconto(numero);
            Assert.AreEqual(scontoaspettato, scontoeffettivo);
        }
        [TestMethod]
        public void CalcoloIncremento()
        {
            double inc = 50;
            double numero = 40;
            double incrementoaspettato =60;
            double incrementoeffetivo = GestioneTest.Incremento(numero,inc);
            Assert.AreEqual(incrementoaspettato, incrementoeffetivo);
        }
    }
}
