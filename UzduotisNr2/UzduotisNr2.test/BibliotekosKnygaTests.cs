using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UzduotisNr2;

namespace UzduotisNr2.test
{
    [TestClass]
    public class BibliotekosKnygaTests
    {
        [TestMethod]
        public void TikrinameArVeluojaAtiduotiKnyga()
        {
            //Arrange 
            BibliotekosKnyga bibliotekosKnyga = new BibliotekosKnyga(1, "Pasaka", 20);
            bibliotekosKnyga.PaemimoData = new DateTime(2020, 1, 1);
            //Act
            bool velavimas = bibliotekosKnyga(TikrinameArVeluojaAtiduotiKnyga);
            //Assert
            Assert.AreEqual(velavimas);
        }
    }
}
