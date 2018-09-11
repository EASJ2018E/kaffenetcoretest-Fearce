using kaffe;
using KaffeNetCore.kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNetCore.Tests
{
    [TestClass]
    public class FlatWhiteTests
    {
        [TestMethod]
        public void FlatWhitePrisTest()
        {
            //Arrange
            int pris = 45;

            //Act
            var flatWhite = new FlatWhite();

            //Assert 
            Assert.AreEqual(flatWhite.Pris(),pris);
        }

        [TestMethod]
        public void FlatWhiteMlM�lkTest()
        {
            //Arrange
            int mlM�lk = 160;

            //Act
            var flatWhite = new FlatWhite();

            //Assert
            Assert.AreEqual(flatWhite.MlM�lk(),mlM�lk);
        }

        [TestMethod]
        public void FlatWhiteStyrkeTest()
        {
            //Arrange
            string styrke = "Mild";

            //Act
            var flatWhite = new FlatWhite();

            //Assert
            Assert.AreEqual(flatWhite.Styrke(),styrke);
        }


    }
}
