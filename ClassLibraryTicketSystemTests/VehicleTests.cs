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
    public class VehicleTests
    {
        [TestMethod()]
        //[DataTestMethod]
        [DataRow("ASDFGHJ", 26 - 04 - 2021)]
        [DataRow("ASDFGHJKASED", 26 - 04 - 2021)]
        [ExpectedException(typeof(System.Reflection.TargetParameterCountException))]
        public void VehicleTest_LicensePlate_ThrowsAnException()
        {
            Assert.Fail();
        }

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


    }
}