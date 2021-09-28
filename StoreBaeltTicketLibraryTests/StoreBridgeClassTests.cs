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
        #region Test: Constructor
        /// <summary>
        /// Testing the constructor
        /// </summary>
        [TestMethod()]
        public void StoreBridgeClassTest()
        {

        }
        #endregion

        #region Test: BrobizzCustomersDiscount_CarTest()
        /// <summary>
        /// Testing the price a car that has a brobizz pays - the car gets a brobizz discount of 5% and pays 228kr.
        /// </summary>
        [TestMethod()]
        public void BrobizzCustomersDiscount_CarTest()
        {
            //Arrange
            double expected = 228;
            StoreBridgeClass sB_Car = new StoreBridgeClass(1, "StoreBælt");
            //Act
            double ActualPrice = sB_Car.BrobizzCustomersDiscount_Car(true);
            //Assert
            Assert.AreEqual(expected, ActualPrice);
            //Assert.Fail();
        }
        #endregion

        #region Test: BrobizzCustomersDiscount_CarTest_NoBBZ()
        /// <summary>
        /// Testing the price a car that has no brobizz pays - the car does NOT get a brobizz discount. A full price of 240kr is paid.
        /// </summary>

        [TestMethod()]
        public void BrobizzCustomersDiscount_CarTest_NoBBZ()
        {
            //Arrange
            double expected = 240;
            StoreBridgeClass sB_Car = new StoreBridgeClass(1, "StoreBælt");
            //Act
            double ActualPrice = sB_Car.BrobizzCustomersDiscount_Car(false);
            //Assert
            Assert.AreEqual(expected, ActualPrice);
            //Assert.Fail();
        }
        #endregion

        #region Test: BrobizzCustomersDiscount_MCTest()
        /// <summary>
        /// A motorbike with a brobizz gets a 5% discount on the bridge and pays 118.75kr.
        /// </summary>
        [TestMethod()]
        public void BrobizzCustomersDiscount_MCTest()
        {
            //Arrange
            double expected = 118.75;
            StoreBridgeClass sB_MC = new StoreBridgeClass(1, "StoreBælt");
            //Act
            double ActualPrice = sB_MC.BrobizzCustomersDiscount_MC(true);
            //Assert
            Assert.AreEqual(expected, ActualPrice);
        }
        #endregion

        #region Test: BrobizzCustomersDiscount_MCTest_NoBBZ()
        /// <summary>
        ///  A motorbike WITHOUT a brobizz does NOT get  5% discount on the bridge and pays 125kr.
        /// </summary>
        [TestMethod()]
        public void BrobizzCustomersDiscount_MCTest_NoBBZ()
        {
            //Arrange
            double expected = 125;
            StoreBridgeClass sB_MC = new StoreBridgeClass(1, "StoreBælt");
            //Act
            double ActualPrice = sB_MC.BrobizzCustomersDiscount_MC(false);
            //Assert
            Assert.AreEqual(expected, ActualPrice);

        }
        #endregion

        #region Test: WeekendBroBizzCustomersPrice_CarTest()
        /// <summary>
        /// A car witha brobizz crossing the bridge on a Saturday gets both discounts. Thus the price paid by the car after the discounts is 182.4kr.
        /// </summary>

        [TestMethod()]

        public void WeekendBroBizzCustomersPrice_CarTest()
        {
            //Arrange
            double expected = 182.4;
            StoreBridgeClass sB_Car = new StoreBridgeClass(1, "StoreBælt");
            //Act
            double ActualPrice = sB_Car.WeekendBroBizzCustomersPrice_Car(6, "Car", true);
            //Assert
            Assert.AreEqual(expected, ActualPrice);
            //Assert.Fail();
        }
        #endregion

        #region Test: WeekendBroBizzCustomersPrice_CarTest1_Sunday_BBZ()
        /// <summary>
        /// A car without brobizz crossing the bridge on a Sunday gets the weekend discount only discounts. Thus the price paid by the car after the discounts is 192kr.
        /// </summary>

        [TestMethod()]
        public void WeekendBroBizzCustomersPrice_CarTest1_Sunday_BBZ()
        {
            //Arrange
            double expected = 192;
            StoreBridgeClass sB_Car = new StoreBridgeClass(1, "StoreBælt");

            //Act
            double ActualPrice = sB_Car.WeekendBroBizzCustomersPrice_Car(7, "Car", false);
            //Assert
            Assert.AreEqual(expected, ActualPrice);
        }
        #endregion

        #region Test: WeekendBroBizzCustomersPrice_CarTest1_Sunday_MC()
        /// <summary>
        /// A motorbike with a Brobizz  crossing the bridge on a weekend receives no  weekend discount and has
        /// but recieves the 5% discount for the Brobizz. The pice is therfore 118.75kr.
        /// </summary>
        [TestMethod()]
        public void WeekendBroBizzCustomersPrice_CarTest1_Sunday_MC()
        {
            //Arrange
            double expected = 118.75;
            StoreBridgeClass sB_Car = new StoreBridgeClass(1, "StoreBælt");

            //Act
            double ActualPrice = sB_Car.WeekendBroBizzCustomersPrice_Car(7, "MC", true);
            //Assert
            Assert.AreEqual(expected, ActualPrice);
        }
        #endregion

        #region Test: WeekendBroBizzCustomersPrice_CarTest1_Sunday_MC_NoBBZ()
        /// <summary>
        /// A mototbike without a Brobizz  crossing the bridge on a weekend recives no discount and has
        /// pay the fuull price 210kr.
        /// </summary>
        [TestMethod()]
        public void WeekendBroBizzCustomersPrice_CarTest1_Sunday_MC_NoBBZ()
        {
            //Arrange
            double expected = 210;
            StoreBridgeClass sB_Car = new StoreBridgeClass(1, "StoreBælt");

            //Act
            double ActualPrice = sB_Car.WeekendBroBizzCustomersPrice_Car(7, "MC", false);
            //Assert
            Assert.AreEqual(expected, ActualPrice);
        }
        #endregion

        #region Test: WeekendBroBizzCustomersPrice_CarTest1_Sunday_NoBBZ()
        /// <summary>
        /// Testing cars that cross the bridh´ge on a sunday without a brobizz
        /// </summary>
        [TestMethod()]
        public void WeekendBroBizzCustomersPrice_CarTest1_Sunday_NoBBZ()
        {
            //Arrange
            double expected = 192;
            StoreBridgeClass sB_Car = new StoreBridgeClass(1, "StoreBælt");

            //Act
            double ActualPrice = sB_Car.WeekendBroBizzCustomersPrice_Car(7, "Car", false);
            //Assert
            Assert.AreEqual(expected, ActualPrice);
        }
        #endregion

        #region Test: VehicleType_CarTest_PassingTest()
        /// <summary>
        ///Chets the type of vehilce that iit is a car 
        /// </summary>
        [TestMethod()]
        public void VehicleType_CarTest_PassingTest()
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

        #endregion

        #region Test: VehicleType_MCTest_Passing()
        /// <summary>
        /// Checking that the vehicle is a motor cycle
        /// </summary>
        #region Test: VehicleType_MCTest_Passing()
        [TestMethod()]
        public void VehicleType_MCTest_Passing()
        {
            //Arrange
            string Expected = "MC";
            MotorCycle mc1 = new MotorCycle("ABCDEFG", DateTime.Today, false);

            //Act
            string Actual = mc1.VehicleType();
            //Asert
            Assert.AreEqual(Expected, Actual);
        }

        #endregion

        #endregion

    }
}