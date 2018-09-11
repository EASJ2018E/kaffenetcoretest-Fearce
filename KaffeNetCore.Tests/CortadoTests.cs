using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNetCore.Tests
{
    [TestClass]
    public class CortadoTests
    {
        [TestMethod]
        public void CortadoPrisTest()
        {
            //Arrange
            int pris = 25;

            //Act
            var cortado = new Cortado();

            //Assert 
            Assert.AreEqual(cortado.Pris(), pris);
        }

        [TestMethod]
        public void CortadoMlMælkTest()
        {
            //Arrange
            int mlMælk = 25;

            //Act
            var cortado = new Cortado();

            //Assert
            Assert.AreEqual(cortado.MlMælk(), mlMælk);
        }

        [TestMethod]
        public void CortadoStyrkeTest()
        {
            //Arrange
            string styrke = "stærk";

            //Act
            var cortado = new Cortado();

            //Assert
            Assert.AreEqual(cortado.Styrke(), styrke);
        }


    }
}
