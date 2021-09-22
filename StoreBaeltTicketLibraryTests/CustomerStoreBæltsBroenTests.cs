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
            Vehicle v1 = new Car("ASGF", DateTime.Today, true);
            
            
             CustomerStoreBæltsBroen.WeekendDiscountOnCarsOnly(v1, v1);

            //Act

            //Assert
            Assert.AreEqual(v1, v1);
            Assert.Fail();
        }

        //[TestMethod()]
        //public void SerializeObjectTest()
        //{
        //    //Arrange
        //    //Act
        //    //Assert
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void EqualToTest()
        //{
        //    //Arrange
        //    //Act
        //    //Assert
        //    Assert.Fail();
        //}
    }
}