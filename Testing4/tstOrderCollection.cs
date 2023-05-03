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

        [TestMethod]
        public void AddMethodOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            TestItem.OrderNumber = 2;
            TestItem.OrderTotal = 2;
            TestItem.OrderDescription = "brownwatch";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.StaffName = "brownwatch";
            TestItem.CustomerID = 60;
            TestItem.Active = true;
            AllOrders.ThisOrders = TestItem;
            PrimaryKey = AllOrders.Add();
            AllOrders.ThisOrders.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrders, TestItem);
        }


        [TestMethod]
        public void UpdateMethodOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            TestItem.OrderNumber = 2;
            TestItem.OrderTotal = 2;
            TestItem.OrderDescription = "brownwatch";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.StaffName = "Jeff";
            TestItem.CustomerID = 60;
            TestItem.Active = true;
            AllOrders.ThisOrders = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNumber = PrimaryKey;
            TestItem.OrderNumber = 5;
            TestItem.OrderTotal = 1;
            TestItem.OrderDescription = "bluewatch";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.StaffName = "John";
            TestItem.CustomerID = 40;
            TestItem.Active = false;
            AllOrders.ThisOrders = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrders.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrders, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            TestItem.OrderNumber = 2;
            TestItem.OrderTotal = 2;
            TestItem.OrderDescription = "brownwatch";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.StaffName = "Jeff";
            TestItem.CustomerID = 60;
            TestItem.Active = true;
            AllOrders.ThisOrders = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNumber = PrimaryKey;
            AllOrders.ThisOrders.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrders.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrders, TestItem);
        }

        [TestMethod]
        public void ReportByOrderDescription()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByOrderDescription("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderDescriptionNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            FilteredOrders.ReportByOrderDescription("xxx xxx");
            Assert.AreEqual(0, FilteredOrders.Count);
        }


        [TestMethod]
        public void ReportByOrderDescriptionTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean Ok = true;
            FilteredOrders.ReportByOrderDescription("yyy yyy");
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].OrderNumber != 36)
                {
                    Ok = false;

                }

                if (FilteredOrders.OrderList[1].OrderNumber != 37)
                {
                    Ok = false;
                }
                else
                {
                    Ok = false;
                }
                Assert.IsTrue(Ok);
            }
        }

    }
}

        
    
