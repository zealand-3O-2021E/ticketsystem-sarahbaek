using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    #region
    #endregion
    [TestClass()]
    public class VehicleTests
    {
        #region Test: VehicleTest_LicensePlate_ThrowsAnException()
        /// <summary>
        /// Testing the length of the licence plate. It should not be longer than 7 characters and an exception should be thrown if it exceeds the limit.
        /// </summary>
        [TestMethod()]
        //[DataTestMethod]
        [DataRow("ASDFGHJ", 26 - 04 - 2021)]
        [DataRow("ASDFGHJKASED", 26 - 04 - 2021)]
        [ExpectedException(typeof(System.Reflection.TargetParameterCountException))]
        public void VehicleTest_LicensePlate_ThrowsAnException()
        {
            Assert.Fail();
        }
        #endregion

        #region Test: VehicleType2Test_StoreBeltCar()
        /// <summary>
        /// Checking the type of vehicle crossing the StoreBridge- car
        /// </summary>
        [TestMethod()]
        public void VehicleType2Test_StoreBeltCar()
        {
            //Arrange
            string Expected = "Car";
            Vehicle mC1 = new MotorCycle(1, "Car");
            //Act
            string Actual = mC1.VehicleType2(1, "Car");
            //Assert
            Assert.AreEqual(Expected, Actual);
            //Assert.Fail();
        }
        #endregion

        #region Test: VehicleType2Test_OresundCar()
        /// <summary>
        /// Checking the vehicle type of vehicles  crossing the Oresund Bridge
        /// </summary>
        [TestMethod()]
        public void VehicleType2Test_OresundCar()
        {
            //Arrange
            string Expected = "Oresund Car";
            Vehicle mC1 = new MotorCycle(2, "Car");
            //Act
            string Actual = mC1.VehicleType2(2, "Car");
            //Assert
            Assert.AreEqual(Expected, Actual);
            //Assert.Fail();
        }

        #endregion

    }
}