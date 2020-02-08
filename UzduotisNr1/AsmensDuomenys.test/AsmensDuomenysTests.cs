using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AsmensDuomenysLibrary;

namespace AsmensDuomenys.test
{
    [TestClass]
    public class AsmensDuomenysTests
    {
        [TestMethod]
        public void GetAgeShouldReturnMyAge()
        {
            //Arrange
            AsmensDuomenys asmensDuomenys = new AsmensDuomenys("Vilija", "Simonaviciene", new DateTime(1989, 01, 25));
            int amzius = 31;
            //Act
            int duomenys = asmensDuomenys.GetAge();
            //Assert
            Assert.AreEqual(amzius, duomenys);
        }
    }
}
