using System;
using kaffe;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNetCore.Tests
{
    [TestClass]
    public class SortKaffeTests
    {
        [DataTestMethod]
        [DataRow(20)]
        [DataRow(21)]
        //[DataRow(19)] ikke for meget - fejler i test
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void PrisTestForMegetRabat20kr(int value)
        {
            //Arrange
            var sortKaffe = new SortKaffe(value);

            //Act
            int pris = sortKaffe.Pris();

            //Assert
            Assert.Fail();
        }

        //[TestMethod()]
        //[ExpectedException(typeof(ArgumentException))]
        //public void PrisTestForMegetRabat21kr()
        //{
        //    //Arrange
        //    var sortKaffe = new SortKaffe(21);

        //    //Act
        //   int pris = sortKaffe.Pris();

        //    //Assert
        //    Assert.Fail();

        //}

        /// <summary>
        /// Rabatten skal være 0 når default ctor kaldes
        /// </summary>
        [TestMethod]
        public void SortKaffeDefaultConstructorRabat()
        {
            //Arrange
            var sortKaffe = new SortKaffe();

            //Act
            int rabat = sortKaffe.Rabat;

            //Assert
            Assert.AreEqual(rabat, 0);

        }

        [TestMethod]
        public void SortKaffeOkRabatPris()
        {
            //Arrange
            var sortKaffe = new SortKaffe(5);

            //Act
            int pris = sortKaffe.Pris();

            //Assert
            Assert.AreEqual(15, pris);

        }

        [TestMethod]
        public void SortKaffeOkRabat()
        {
            //Arrange
            var sortKaffe = new SortKaffe(5);

            //Act
            int rabat = sortKaffe.Rabat;

            //Assert
            Assert.AreEqual(5, rabat);

        }

        [TestMethod]
        public void SortKaffeStyrke()
        {
            //Arrange
            var sortKaffe = new SortKaffe();

            //Act
            var styrke = sortKaffe.Styrke();

            //Assert
            Assert.AreEqual(styrke, "stærk");

        }

        [TestMethod]
        public void SortKaffePris()
        {
            //Arrange
            var sortKaffe = new SortKaffe();

            //Act
            var pris = sortKaffe.Pris();

            //Assert
            Assert.AreEqual(pris,20);
        }


        [TestMethod]
        public void ProgramTest()
        {
            //Arrange
            KaffeNetCore.Program.Main();
            var c = KaffeNetCore.Program.IsRunning;

            //Act
            bool test = true;

            //Assert
            Assert.AreEqual(c, test);
        }



    }
}
