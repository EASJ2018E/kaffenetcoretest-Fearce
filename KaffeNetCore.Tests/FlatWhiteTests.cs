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
        public void FlatWhiteMlMælkTest()
        {
            //Arrange
            int mlMælk = 160;

            //Act
            var flatWhite = new FlatWhite();

            //Assert
            Assert.AreEqual(flatWhite.MlMælk(),mlMælk);
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
