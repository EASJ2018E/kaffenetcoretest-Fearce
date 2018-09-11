using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNetCore.Tests
{
    [TestClass]
    public class LatteTests
    {
        [TestMethod]
        public void LattePrisTest()
        {
            //Arrange
            int pris = 40;
            //Act
            var latte = new Latte();
            //Assert 
            Assert.AreEqual(latte.Pris(),pris);
        }

        [TestMethod]
        public void LatteMlMælkTest()
        {
            //Arrange
            int mlMælk = 120;
            //Act
            var latte = new Latte();
            //Assert
            Assert.AreEqual(mlMælk,latte.MlMælk());
        }

        [TestMethod]
        public void LatteStyrkeTest()
        {
            //Arrange
            string styrke = "stærk";

            //Act
            var latte = new Latte();

            //Assert
            Assert.AreEqual(latte.Styrke(), styrke);
        }

    }
}
