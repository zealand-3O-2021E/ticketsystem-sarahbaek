using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest_MCRice_Passing()
        {
            //Arrange
            double Expected = 125.00;
            MC mc1 = new MC();
            
            //Act
           double Actuual =  mc1.Price();
            //Assert
            Assert.AreEqual(Expected, Actuual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void VehicleTest()
        {
            //Arrange
            string Expected = "MC";
            MC mc1 = new MC();

            //Act
          string Actual=   mc1.Vehicle();
            //Asert
            Assert.AreEqual(Expected, Actual);
            //Assert.Fail();
        }
    }
}