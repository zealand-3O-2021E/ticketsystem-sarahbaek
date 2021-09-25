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
            MotorCycle mc1 = new MotorCycle("ABCDEFG",DateTime.Today, false);
            
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
            MotorCycle mc1 = new MotorCycle("ABCDEFG", DateTime.Today, false);

            //Act
            string Actual=   mc1.VehicleType();
            //Asert
            Assert.AreEqual(Expected, Actual);
            //Assert.Fail();
        }


        [TestMethod()]
        public void PriceTest_CorrectPrice_Pass_Testing_MC_Brobizz()
        {
            //Arrange
            double Expected = 125.00 - (0.05 * 125);
            //Act
            MotorCycle mc1 = new MotorCycle("ASFDGHY", DateTime.Today, true);
            double Actual = mc1.Price();
            //Assert
            Assert.AreEqual(Expected, Actual, 0.01);

            //Assert.Fail();
        }
    }
}