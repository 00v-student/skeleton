using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ClassLibrary

{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            //Add an item to the list of objects
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.Active = true;
            TestItem.OrderNumber = 1;
            TestItem.OrderDescription = "brownwatch";
            TestItem.OrderTotal = 20;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.StaffName = "John";
            TestItem.CustomerID = 45;
            //add the iten to the list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        

        [TestMethod]
        public void ThisOrderListPropertyOk()
        {
            //create some test data to assign to the property
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrders TestOrders = new clsOrders();
            //Set the properties of the test object
            TestOrders.Active = true;
            TestOrders.OrderNumber = 1;
            TestOrders.OrderDescription = "bluewatch";
            TestOrders.OrderDate = DateTime.Now.Date;
            TestOrders.OrderTotal = 1;
            TestOrders.StaffName = "John";
            TestOrders.CustomerID = 45;
            //Assign the data to the property
            AllOrders.ThisOrders = TestOrders;
            //Test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrders, TestOrders);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            //add an item to the list
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.OrderNumber = 2;
            TestItem.OrderTotal = 2;
            TestItem.OrderDescription = "brownwatch";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.StaffName = "brownwatch";
            TestItem.CustomerID = 60;
            TestItem.Active = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see if the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
    }
}
