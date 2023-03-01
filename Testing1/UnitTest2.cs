using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace stockTest
{
    [TestClass]
    public class testStock
    {
        public void InstanceOK() // can the instance be instantiated properly?
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void WatchAvailabilityOK()
        {
            clsStock AStock = new clsStock(); //create instance of class
            Boolean TestBool = true; // make some data
            AStock.available = TestBool; //assign that data to the field we are checking
            Assert.AreEqual(AStock.available, TestBool); // check if field equals that data, did the assignment go through?
        }

        [TestMethod]
        public void AddDateOK()
        {
            clsStock AStock = new clsStock();
            DateTime TestDate = DateTime.Now.Date;
            AStock.dateadd = TestDate;
            Assert.AreEqual(AStock.dateadd, TestDate);
        }
       
        [TestMethod]
        public void typeOK()
        {
            clsStock AStock = new clsStock();
            string Testtype = "something";
            AStock.type = Testtype;
            Assert.AreEqual(AStock.type, Testtype);
        }

        [TestMethod]
        public void descOK()
        {
            clsStock AStock = new clsStock();
            string Testd = "Hakuna Matata";
            AStock.desc = Testd;
            Assert.AreEqual(AStock.desc, Testd);
        }


        [TestMethod]
        public void priceOK()
        {
            clsStock AStock = new clsStock();
            decimal Testp = 0.0M;
            AStock.price = Testp;
            Assert.AreEqual(AStock.price, Testp);
        }
        [TestMethod]
        public void StockOK()
        {
            clsStock AStock = new clsStock();
            Int32 Testno = 20;
            AStock.stock = Testno;
            Assert.AreEqual(AStock.stock, Testno);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AStock = new clsStock();
            Boolean found = false;
            
            int Testno = 2;
            found = AStock.Find(Testno);
           
            Assert.IsTrue(found);
        }
        public void TestWatchidFound()
        {
            clsStock AStock = new clsStock();
            Boolean found = false;
            Boolean OK = true;
            int Testno = 2;
            found = AStock.Find(Testno);
            if (AStock.watchid != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDescfound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int watchno = 2;
            //invoke the method
            Found = AStock.Find(watchno);
            //check the property
            if (AStock.desc != "Test")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPricefound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int watchno = 2;
            //invoke the method
            Found = AStock.Find(watchno);
            //check the property
            if (AStock.price != 0.0m)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTypeFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int watchno = 2;
            //invoke the method
            Found = AStock.Find(watchno);
            //check the property
            if (AStock.type != "analog")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int watchno = 2;
            //invoke the method
            Found = AStock.Find(watchno);
            //check the property
            if (AStock.stock != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int watchno = 2;
            //invoke the method
            Found = AStock.Find(watchno);
            //check the property
            if (AStock.dateadd != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int watchno = 2;
            //invoke the method
            Found = AStock.Find(watchno);
            //check the property
            if (AStock.available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}

  

