using kaffe;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kaffeTests
{
    [TestClass]
    public class FlatwhiteTest
    {
        [TestMethod]
        public void FlatwhitePrisCheck()
        {
                //Arrange
                var Flatwhite = new FlatWhite();

                //Act
                int pris = Flatwhite.Pris();

                //assert
                Assert.AreEqual(75, pris);
        }

        [TestMethod]
        public void FlatwhiteMlMælkCheck()
        {
            //Arrange
            var Flatwhite = new FlatWhite();

            //Act
            int mlMælk = Flatwhite.MlMælk();

            //assert
            Assert.AreEqual(25, mlMælk);
        }

        [TestMethod]
        public void FlatwhiteStyrkeCheck()
        {
            //Arrange
            var Flatwhite = new FlatWhite();

            //Act
            string styrke = Flatwhite.Styrke();

            //assert
            Assert.AreEqual("Svag", styrke);
        }
    }
}
