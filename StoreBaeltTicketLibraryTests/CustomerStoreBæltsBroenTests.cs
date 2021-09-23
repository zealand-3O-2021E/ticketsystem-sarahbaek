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
    //Expected to throw an exception if the two objects are not equal
    [TestClass()]
    public class CustomerStoreBæltsBroenTests
    {
        [TestMethod()]
        public void WeekendDiscountOnCarsOnlyTest()
        {
           //Arrange
           Car c1 = new Car("ASGF", DateTime.Today, true);
           Vehicle v1 =  c1;
           //Act
           CustomerStoreBæltsBroen.WeekendDiscountOnCarsOnly(v1, c1);
           //Assert
           Assert.AreEqual(v1, c1);
           //Assert.Fail();
        }

        //[TestMethod()]
        //[DataRow(Car c1)]
        //public void SerializeObjectTest()
        //{
        //    //Arrange
        //    Car c1 = new Car("ASGF", DateTime.Today, true);
        //    //Vehicle v1 = c1;
        //    //Act
        //   //string cc=  SerializeObject<Car>(c1);
        //    var Json = Newtonsoft.Json.JsonConvert.SerializeObject(c1);


        //    //Assert
        //    Assert.AreEqual(c1, Json);
        //    //Assert.Fail();
        //}

        [TestMethod()]
        public void EqualToTest_ComparingIfACarIsAVehicle_PassingTest()
        {
            //Arrange
            Car c1 = new Car("ASGF", DateTime.Today, true);
            Vehicle v1 = c1;
            //Act
         bool AreEqual =    v1.EqualTo(c1);
            //Assert
            Assert.AreEqual(v1, c1);
            //Assert.Fail();
        }
    }
}