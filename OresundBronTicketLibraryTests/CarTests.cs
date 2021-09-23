using Microsoft.VisualStudio.TestTools.UnitTesting;

using OresundBronTicketLibrary;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBronTicketLibrary.Tests
{
    [TestClass()]
    public class CarTests
    {
       /// <summary>
       /// Testing the price of a car without a brobizz agreement- the price should be 410kr
       /// </summary>

        [TestMethod()]
        public void PriceTest_WithoutBrobizz()
        {
            //Arrange
            double Expected =410;
            //Act
            Car car1 = new Car("ASFDGHY", DateTime.Today, false);
            double Actual = car1.Price();
            //Assert
            Assert.AreEqual(Expected, Actual, 0.01);
            //Assert.Fail();
           
        }
        /// <summary>
        /// / Testing the price of a car with a brobizz agreement- the price should be 161kr
        /// </summary>
        public void PriceTestWithBrobizz_Returning161()
        {
            //Arrange
            double Expected = 161;
            //Act
            Car car1 = new Car("ASFDGHY", DateTime.Today, true);
            double Actual = car1.Price();
            //Assert
            Assert.AreEqual(Expected, Actual, 0.01);
            //Assert.Fail();

        }
        /// <summary>
        /// Testing the type of vehicle - it should return a string "Oresund Car".
        /// </summary>
        [TestMethod()]
        public void VehicleTypeTest_TTheCarType_Should_Be_Oresund_Car()
        {
        // Arrange
            string Expected = "Oresund Car";
            Car car1 = new Car("ASFDGHY", DateTime.Today);
            //Act
            string Actual = car1.VehicleType();
            //Assert
            Assert.AreEqual(Expected, Actual);
            //Assert.Fail();
        }
    }
}