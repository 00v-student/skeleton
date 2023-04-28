using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
        //good test data
        //create some test data to pass to the method
        string OrderDescription = "BlueWatch";
        string OrderTotal = "20.00";
        string CustomerID = "42";
        string StaffName = "John";
        string OrderDate = "21/02/2021";



        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }


        [TestMethod]
        public void OrderNumberPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNumber, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
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
        public void OrderDescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            String TestData = "Watches";
            //assign the data to the property
            AnOrder.OrderDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDescription, TestData);
        }

        [TestMethod]
        public void OrderTotalPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            int TestData = 10;
            //assign the data to the property
            AnOrder.OrderTotal = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderTotal, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderTotal = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderTotal, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOk()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            string TestData = "Nicole";
            //assign the data to the property
            AnOrder.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.StaffName, TestData);
        }

        [TestMethod]
        public void OrderCompletePropertyOk()
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

        [TestMethod]
        public void FindMethod()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //Booelan variable to store the results of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 Testno = 1;
            //Invoke the method
            Found = AnOrders.Find(Testno);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }



        [TestMethod]
        public void TestOrderNumberFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is ok (assume it is)
            Boolean Ok = true;
            //Create some test data to use with the method
            Int32 OrderNumber = 1;
            //Invoke the method
            Found = AnOrders.Find(OrderNumber);
            //Check the address no
            if (AnOrders.OrderNumber != 1)
            {
                Ok = false;
            }
            //Test to see if that result is correct
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void TestOrderDescriptionFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is ok (assume it is)
            Boolean Ok = true;
            //Create some test data to use with the method
            Int32 OrderNumber = 1;
            //Invoke the method
            Found = AnOrders.Find(OrderNumber);
            //Check the address no
            if (AnOrders.OrderDescription != "watches")
            {
                Ok = false;
            }
            //Test to see if that result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNumber = 2;
            //invoke the method
            Found = AnOrders.Find(OrderNumber);
            //check the property
            if (AnOrders.OrderDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderTotalFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is ok (assume it is)
            Boolean Ok = true;
            //Create some test data to use with the method
            Int32 OrderNumber = 1;
            //Invoke the method
            Found = AnOrders.Find(OrderNumber);
            //Check the address no
            if (AnOrders.OrderTotal != 10)
            {
                Ok = false;
            }
            //Test to see if that result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void testOrderCompleteFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNumber = 1;
            //invoke the method
            Found = AnOrders.Find(OrderNumber);
            //check the property
            if (AnOrders.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is ok (assume it is)
            Boolean Ok = true;
            //Create some test data to use with the method
            Int32 OrderNumber = 3;
            //Invoke the method
            Found = AnOrders.Find(OrderNumber);
            //Check the address no
            if (AnOrders.CustomerID != 1)
            {
                Ok = false;
            }
            //Test to see if that result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is ok (assume it is)
            Boolean Ok = true;
            //Create some test data to use with the method
            Int32 OrderNumber = 1;
            //Invoke the method
            Found = AnOrders.Find(OrderNumber);
            //Check the address no
            if (AnOrders.StaffName != "Nicole")
            {
                Ok = false;
            }
            //Test to see if that result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //Create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //String variable to store any error message
            String Error = "";
            //Invoke the method
            Error = AnOrders.Valid(OrderDescription,StaffName,OrderTotal,OrderDate,CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
       }

}



