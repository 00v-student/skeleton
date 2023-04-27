﻿using ClassLibrary;
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
        public void OrderNumber()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            int TestData = 1232;
            //assign the data to the property
            AnOrder.OrderNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNumber, TestData);
        }

        [TestMethod]
        public void OrderDate()
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that two dates are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
                }
        
        
         [TestMethod]
        public void OrderDescription() 
            string TestData = "Order";
            //assign the data to the property
            AnOrder.OrderDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDescription, TestData);
        }

        [TestMethod]
        public void OrderTotal()
        int TestData = 1 ;
            //assign the data to the property
            AnOrder.OrderTotal = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderTotal, TestData);
        }
       
       [TestMethod]
        public void CustomerID()
            int TestData = 1;
            //assign the data to the property
            AnOrder.OrderTotal = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderTotal, TestData);
        }
    
      [TestMethod]
        public void StaffName()
            //assign the data to the property
            AnOrder.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.StaffName, TestData);
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
       
     
