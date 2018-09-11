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
        public void LatteMlM�lkTest()
        {
            //Arrange
            int mlM�lk = 120;
            //Act
            var latte = new Latte();
            //Assert
            Assert.AreEqual(mlM�lk,latte.MlM�lk());
        }

        [TestMethod]
        public void LatteStyrkeTest()
        {
            //Arrange
            string styrke = "st�rk";

            //Act
            var latte = new Latte();

            //Assert
            Assert.AreEqual(latte.Styrke(), styrke);
        }

    }
}
