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
        //[TestMethod()]
        //public void VehicleTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void PriceTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void VehicleTypeTest()
        //{
        //    Assert.Fail();
        //}


        [TestMethod()]
        //[DataTestMethod]
        [DataRow("ASDFGHJ", 26-04-2021)]
        [DataRow("ASDFGHJKASED", 26 - 04 - 2021)]
        [ExpectedException(typeof(System.Reflection.TargetParameterCountException))]
        public void VehicleTest_LicensePlate_ThrowsAnException()
        {
         Assert.Fail();
        }

       

    }
}