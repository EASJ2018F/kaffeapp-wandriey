using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kaffe;

namespace kaffeTests
{
    [TestClass]
    public class CortadoTest
    {
        [TestMethod]
        public void CortadoPrisCheck()
        {
            //Arrange
            var Cortado = new Cortado();
            //Act
            int pris = Cortado.Pris();
            //Assert
            Assert.AreEqual(25, pris);

        }

        [TestMethod]
        public void CortadoMlMælk()
        {
            //Arrange
            var Cortado = new Cortado();
            //Act
            int mlMælk = Cortado.MlMælk();
            //Assert
            Assert.AreEqual(25, mlMælk);

        }
    }
}
