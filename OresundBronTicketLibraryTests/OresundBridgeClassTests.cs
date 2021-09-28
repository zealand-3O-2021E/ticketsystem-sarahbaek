using ClassLibraryTicketSystem;

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
    public class OresundBridgeClassTests
    {
        #region Test:BrobizzCustomersDiscount_CarTest_Failing()
        /// <summary>
        /// Checking the price of a car without a brobizz crossing over the Oresund Bridge
        /// </summary>
        [TestMethod()]
        public void BrobizzCustomersDiscount_CarTest_Failing()
        {
            //Arrange
            double expected = 410;
            OresundBridgeClass Or_Car = new OresundBridgeClass(2, "Oresund");
            //Act
            double ActualPrice = Or_Car.BrobizzCustomersDiscount_Car(false);
            //Assert
            Assert.AreEqual(expected, ActualPrice);
            //Assert.Fail();
        }
        #endregion

        #region Test: BrobizzCustomersDiscount_CarTest_Bbz()
        /// <summary>
        /// Chacking the price of a car that has a brobizz crossing the Oresund Bridge
        /// </summary>
        [TestMethod()]
        public void BrobizzCustomersDiscount_CarTest_Bbz()
        {
            //Arrange
            double expected = 161;
            OresundBridgeClass Or_Car = new OresundBridgeClass(2, "Oresund");
            //Act
            double ActualPrice = Or_Car.BrobizzCustomersDiscount_Car(true);
            //Assert
            Assert.AreEqual(expected, ActualPrice);
            //Assert.Fail();
        }
        #endregion

        #region Test: BrobizzCustomersDiscount_MCTest()
        /// <summary>
        /// Calculating the discount offered to a MC with a brobizz subscription, on the Oresund Bridge.
        /// </summary>
        [TestMethod()]
        public void BrobizzCustomersDiscount_MCTest()
        {
            //Arrange
            double expected = 73;
            OresundBridgeClass Or_MC = new OresundBridgeClass(2, "Oresund");
            //Act
            double ActualPrice = Or_MC.BrobizzCustomersDiscount_MC(true);
            //Assert
            Assert.AreEqual(expected, ActualPrice);
            //Assert.Fail();
        }

        #endregion

        #region Test: EverydayPrice_CarTest()
        /// <summary>
        /// Checking the price for a car crossing the Oresung bridge
        /// </summary>
        [TestMethod()]
        public void EverydayPrice_CarTest()
        {
            //Arrange
            double expected = 410;
            OresundBridgeClass Or_Car = new OresundBridgeClass(2, "Oresund");
            //Act
            double ActualPrice = Or_Car.EverydayPrice_Car();
            //Assert
            Assert.AreEqual(expected, ActualPrice);
            //Assert.Fail();
        }
        #endregion

        #region Test: EverydayPrice_MCTest()
        /// <summary>
        /// Checking for the price of a motorcycle  with no brobizz on the Oresund Bridge
        /// </summary>
        [TestMethod()]
        public void EverydayPrice_MCTest()
        {
            //Arrange
            double expected = 210;
            OresundBridgeClass Or_Car = new OresundBridgeClass(2, "Oresund");
            //Act
            double ActualPrice = Or_Car.EverydayPrice_MC();
            //Assert
            Assert.AreEqual(expected, ActualPrice);
            //Assert.Fail();
        }
        #endregion

        #region Test: WeekendBroBizzCustomersPrice_CarTest()
        /// <summary>
        /// Checking the weekend price of a car that has a brobizz crossing the Oresund bridge
        /// </summary>
        [TestMethod()]
        public void WeekendBroBizzCustomersPrice_CarTest()
        {
            //Arrange
            double expected = 161;
            OresundBridgeClass Or_Car = new OresundBridgeClass(2, "Oresund");
            //Act
            double ActualPrice = Or_Car.WeekendBroBizzCustomersPrice_Car(7, "Car", true);
            //Assert
            Assert.AreEqual(expected, ActualPrice);
            //Assert.Fail();
            //Assert.Fail();
        }
        #endregion

        #region Test: eekend_NoBroBizz_Price_CarTest()
        /// <summary>
        /// Checking the weekennd price for a car without a brobizz
        /// </summary>
        [TestMethod()]
        public void Weekend_NoBroBizz_Price_CarTest()
        {
            //Arrange
            double expected = 410;
            OresundBridgeClass Or_Car = new OresundBridgeClass(2, "Oresund");
            //Act
            double ActualPrice = Or_Car.Weekend_No_BroBizzPrice_Car(1, "Car", false);
            //Assert
            Assert.AreEqual(expected, ActualPrice);
        }
        #endregion

        #region Test:  VehicleType_CarTest_Passing()

        [TestMethod()]
        public void VehicleType_CarTest_Passing()
        {
            //Arrange
            string Expected = "Oresund Car";

            Car car1 = new Car("ASFDGHY", DateTime.Today);
            //Act

            string Actual = car1.VehicleType2(2, "Car");
            //Assert
            Assert.AreEqual(Expected, Actual);
            //Assert.Fail();
        }

        #endregion

        #region Test:  VehicleType_MCTest_Passing()
        /// <summary>
        /// Checking that the type of vehicle crossing the Oresund  bridge is a MC
        /// </summary>
        [TestMethod()]
        public void VehicleType_MCTest_Passing()
        {
            //Arrange
            string Expected = "Oresund MC";
            MotorCycle mc1 = new MotorCycle("ABCDEFG", DateTime.Today, false);

            //Act
            string Actual = mc1.VehicleType2(2, "MC");
            //Asert
            Assert.AreEqual(Expected, Actual);
        }
        #endregion

    }
}