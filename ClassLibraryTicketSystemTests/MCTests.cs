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
        #region Test: PriceTest_MCRice_Passing()
        /// <summary>
        /// Testing the price of a MC crossing the bridge , without a brobizz.
        /// </summary>
        [TestMethod()]
        public void PriceTest_MCRice_Passing()
        {
            //Arrange
            double Expected = 125.00;
            MotorCycle mc1 = new MotorCycle("ABCDEFG", DateTime.Today, false);

            //Act
            double Actuual = mc1.Price();
            //Assert
            Assert.AreEqual(Expected, Actuual);
            //Assert.Fail();
        }
        #endregion

        #region Test: VehicleTest_withoutBroBizz()

        /// <summary>
        /// Checking the price a MC that has no brobizz, pays, while crossing the StoreBelt bridge
        /// </summary>
        [TestMethod()]
        public void VehicleTest_withoutBroBizz()
        {
            //Arrange
            string Expected = "MC";
            MotorCycle mc1 = new MotorCycle("ABCDEFG", DateTime.Today, false);

            //Act
            string Actual = mc1.VehicleType();
            //Asert
            Assert.AreEqual(Expected, Actual);
            //Assert.Fail();
        }
        #endregion

        #region Test: PriceTest_CorrectPrice_Pass_Testing_MC_Brobizz()
        /// <summary>
        /// Testing the price of an MC that has a brobizz, it gets a discount of 5%
        /// </summary>
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
        #endregion

    }
}