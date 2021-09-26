//using ClassLibraryTicketSystem;

//using Microsoft.VisualStudio.TestTools.UnitTesting;

//using OresundBronTicketLibrary;

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OresundBronTicketLibrary.Tests
//{
//    [TestClass()]
//    public class MotorCycleTests
//    {
    

//        /// <summary>
//        /// Testing the price of a motorcycle which does not have abribizz agreement
//        /// </summary>
//        [TestMethod()]
//        public void PriceTest_MotorCycle_PriceTest_WithoutBrobizz_Passing()
//        {
        

//            //Arrange
//            double Expected = 210;
//            //Act
//            MotorCycle mc1 = new MotorCycle("ASFDGHY", DateTime.Today, false);
//            double Actual = mc1.Price();
//            //Assert
//            Assert.AreEqual(Expected, Actual, 0.01);
//            //Assert.Fail();
//        }

//        /// <summary>
//        /// Testing the price of a motor cycle with a brobizz agreement
//        /// </summary>
//        [TestMethod()]
//        public void PriceTest_CorrectPrice_Pass_Testing_MC_Brobizz()
//        {
//            //Arrange
//            double Expected = 73;
//            //Act
//            MotorCycle mc1 = new MotorCycle("ASFDGHY", DateTime.Today, true);
//            double Actual = mc1.Price();
//            //Assert
//            Assert.AreEqual(Expected, Actual);

//            //Assert.Fail();
//        }

//        /// <summary>
//        /// Testing the type of vehicle - should return a string written "Oresund MC."
//        /// </summary>
//        [TestMethod()]
//        public void VehicleTest()
//        {
//            //Arrange
//            string Expected = "Oresund MC";
//            MotorCycle mc1 = new MotorCycle("ABCDEFG", DateTime.Today, false);

//            //Act
//            string Actual = mc1.VehicleType();
//            //Asert
//            Assert.AreEqual(Expected, Actual);
//            //Assert.Fail();
//        }


       
//    }
//}