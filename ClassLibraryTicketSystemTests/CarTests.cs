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
    public class CarTests
    {
        /// <summary>
        /// Testing the Price method. It should retun a double 240.00.
        /// </summary>
        [TestMethod()]
        public void PriceTest_CorrectPrice_Pass()
        {
            //Arrange
            double Expected = 240.00 ;
            //Act
            Car car1 = new Car("ASFDGHY", DateTime.Today, false );
            double Actual = car1.Price();
            //Assert
            Assert.AreEqual(Expected, Actual, 0.01);
            //Assert.Fail();
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            string Expected = "Car";
            Car car1 = new Car("ASFDGHY", DateTime.Today);
            //Act
            string Actual =  car1.VehicleType();
            //Assert
            Assert.AreEqual(Expected, Actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void PriceTest_CorrectPrice_Pass_Testing_Brobizz()
        {
            //Arrange
            double Expected = 240.00 - (0.05 * 240);
            //Act
            Car car1 = new Car("ASFDGHY", DateTime.Today, true);
            double Actual = car1.Price();
            //Assert
            Assert.AreEqual(Expected, Actual, 0.01);
    
            //Assert.Fail();
        }
    }
}