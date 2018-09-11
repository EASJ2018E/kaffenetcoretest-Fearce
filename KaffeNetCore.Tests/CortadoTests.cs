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
        public void CortadoMlM�lkTest()
        {
            //Arrange
            int mlM�lk = 25;

            //Act
            var cortado = new Cortado();

            //Assert
            Assert.AreEqual(cortado.MlM�lk(), mlM�lk);
        }

        [TestMethod]
        public void CortadoStyrkeTest()
        {
            //Arrange
            string styrke = "st�rk";

            //Act
            var cortado = new Cortado();

            //Assert
            Assert.AreEqual(cortado.Styrke(), styrke);
        }


    }
}
