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
        [TestMethod()]
        public void BrobizzCustomersDiscount_CarTest()
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


        [TestMethod()]
        public void BrobizzCustomersDiscount_MCTest()
        {
            //Arrange
                double expected =73 ;
            OresundBridgeClass Or_MC = new OresundBridgeClass(2, "Oresund");
            //Act
            double ActualPrice = Or_MC.BrobizzCustomersDiscount_MC(true);
            //Assert
            Assert.AreEqual(expected, ActualPrice);
            //Assert.Fail();
    
        }



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



        [TestMethod()]
        public void VehicleType_CarTest()
        {
            //Arrange
            string Expected = "Oresund Car";

            Car car1 = new Car("ASFDGHY", DateTime.Today);
            //Act

            string Actual = car1.VehicleType();
            //Assert
            Assert.AreEqual(Expected, Actual);
            //Assert.Fail();
        }



        //[TestMethod()]
        //public void VehicleType_MCTest()
        //{
        //    //Arrange
        //    string Expected = "Oresund MC";
        //    MotorCycle mc1 = new MotorCycle("ABCDEFG", DateTime.Today, false);

        //    //Act
        //    string Actual = mc1.VehicleType_MC();
        //    //Asert
        //    Assert.AreEqual(Expected, Actual);
        //}
    }
}