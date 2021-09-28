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
    public class MotorCycleTests
    {
        #region Test: VehicleType2Test_StoreBeltMC()
        /// <summary>
        /// Checking the vehicle types crossing the StoreBeelt Bridge- motocylces
        /// </summary>
        [TestMethod()]
        public void VehicleType2Test_StoreBeltMC()
        {
            //Arrange
            string Expected = "MC";
            Vehicle mC1 = new MotorCycle(1, "MC");
            //Act
            string Actual = mC1.VehicleType2(1, "MC");
            //Assert
            Assert.AreEqual(Expected, Actual);
            //Assert.Fail();
        }

        #endregion

        #region Test:ehicleType2Test_OresundMC()
        /// <summary>
        /// Checking the vehicle type crossing the Oresund bridge is a MC.
        /// </summary>
        [TestMethod()]
        public void VehicleType2Test_OresundMC()
        {
            //Arrange
            string Expected = "Oresund MC";
            Vehicle mC1 = new MotorCycle(2, "MC");
            //Act
            string Actual = mC1.VehicleType2(2, "MC");
            //Assert
            Assert.AreEqual(Expected, Actual);
            //Assert.Fail();
        }
        #endregion

    }
}