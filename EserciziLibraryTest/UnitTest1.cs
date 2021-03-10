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
    }
}
