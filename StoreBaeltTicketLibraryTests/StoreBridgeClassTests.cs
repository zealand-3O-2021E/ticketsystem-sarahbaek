using ClassLibraryTicketSystem;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using StoreBaeltTicketLibrary;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StoreBridgeClassTests
    {
        [TestMethod()]
        public void StoreBridgeClassTest()
        {

        }

        [TestMethod()]
        public void BrobizzCustomersDiscount_CarTest()
        {
            //Arrange
            double expected = 240;
            StoreBridgeClass sB_Car = new StoreBridgeClass(1, "StoreBælt");
            //Act
            double ActualPrice = sB_Car.BrobizzCustomersDiscount_Car(true);
            //Assert
            Assert.AreEqual(expected, ActualPrice);
            //Assert.Fail();
        }

        [TestMethod()]
        public void BrobizzCustomersDiscount_MCTest()
        {
            //Arrange
            double expected = 125;
            StoreBridgeClass sB_MC = new StoreBridgeClass(1, "StoreBælt");
            //Act
            double ActualPrice = sB_MC.BrobizzCustomersDiscount_MC(true);
            //Assert
            Assert.AreEqual(expected, ActualPrice);

        }

        [TestMethod()]
        public void EverydayPrice_CarTest()
        {
            //Arrange
            double expected = 228;
            StoreBridgeClass sB_Car = new StoreBridgeClass(1, "StoreBælt");
            //Act
            double ActualPrice = sB_Car.EverydayPrice_Car();

            //Assert
            Assert.AreEqual(expected, ActualPrice);
            //Assert.Fail();
        }

        [TestMethod()]
        public void EverydayPrice_MCTest()
        {
            //Arrange
            double expected = 118.75;
            StoreBridgeClass sB_MC = new StoreBridgeClass(1, "StoreBælt");
            //Act
            double ActualPrice = sB_MC.EverydayPrice_MC();
            //Assert
            Assert.AreEqual(expected, ActualPrice);

        }


        [TestMethod()]
    
        public void WeekendBroBizzCustomersPrice_CarTest()
        {
            //Arrange
            double expected = 182.4;
            StoreBridgeClass sB_Car = new StoreBridgeClass(1, "StoreBælt");
            //Act
            double ActualPrice = sB_Car.WeekendBroBizzCustomersPrice_Car(6,"Car", true);
            //Assert
            Assert.AreEqual(expected, ActualPrice);
            //Assert.Fail();
        }




    
        /// <summary>
        /// There are error in this method.
        /// </summary>
        [TestMethod()]
        public void Weekend_No_BroBizzPrice_CarTest()
        {
            //Arrange
            double expected = 228;
            StoreBridgeClass sB_Car = new StoreBridgeClass(1, "StoreBælt");
            //Act
            double ActualPrice = sB_Car.WeekendBroBizzCustomersPrice_Car(1,"Car", true);
            //Assert
            Assert.AreEqual(expected, ActualPrice);
        }


        [TestMethod()]
        public void VehicleType_CarTest()
        {
            //Arrange
            string Expected = "Car";
            Car car1 = new Car("ASFDGHY", DateTime.Today);
            //Act
            string Actual = car1.VehicleType();
            //Assert
            Assert.AreEqual(Expected, Actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void VehicleType_MCTest()
        {
            //Arrange
            string Expected = "MC";
            MotorCycle mc1 = new MotorCycle("ABCDEFG", DateTime.Today, false);

            //Act
            string Actual = mc1.VehicleType();
            //Asert
            Assert.AreEqual(Expected, Actual);
        }

     
    }
}