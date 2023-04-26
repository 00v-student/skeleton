using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
            
            
        [TestMethod]
        public void OrderComplete()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            AnOrders.Active = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrders.Active, TestData);
            }
    }
}
