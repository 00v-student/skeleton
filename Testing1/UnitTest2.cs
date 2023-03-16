using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace stockTest
{
    [TestClass]
    public class testStock

    {
        String watchid = "2";
        String desc = "desc";
        String price = "0.0";
        String dateadd = DateTime.Now.Date.ToString();
        String stock = "2";
        String type = "analog";
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
            
            Int32 Testno = 2;
            found = AStock.Find(Testno);
           
            Assert.IsTrue(found);
        }
        public void TestWatchidFound()
        {
            clsStock AStock = new clsStock();
            Boolean found = false;
            Boolean OK = true;
            Int32 Testno = 2;
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
            Int32 watchno = 2;
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
            Int32 watchno = 2;
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
            Int32 watchno = 2;
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
            Int32 watchno = 2;
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
            Int32 watchno = 2;
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
            Int32 watchno = 2;
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
        [TestMethod]
        public void ValidMethhodOK() {
            clsStock astock = new clsStock();
            String Error = " ";
            Error = astock.Valid( desc,price, dateadd, stock, type);

        }
        [TestMethod]
        public void descMinMinusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string desc = ""; //desc minus one is 0 char
            Error = AStock.Valid(desc, price, dateadd , stock, type);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void descMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string desc = "H";
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void descMinPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string desc = "Ha";
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void descMaxMinusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string desc = "1234567890123456789012345678901234567890123456789";
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void descMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string desc = "12345678901234567890123456789012345678901234567890";
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void descMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string desc = "123456789012345678901234567890123456789012345678901";
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreNotEqual(Error, ""); //Error message should not be empty
        }

        [TestMethod]
        public void descMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string desc = "1234567890123456789012345";
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void descExtremeMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string desc = "";
            desc = desc.PadRight(1000, 'H');
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddExtremeMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-100);
            string dateadd = TestDate.ToString();
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreNotEqual(Error, ""); // there should be some error messagE
        }

        [TestMethod]
        public void DateAddExtremeMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(100);
            string dateadd = TestDate.ToString();
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreNotEqual(Error, ""); // there should be some error messagE
        }

        [TestMethod]
        public void DateAddMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-10);
            string dateadd = TestDate.ToString();
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddMinMinusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-9);
            string dateadd = TestDate.ToString();
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreNotEqual(Error, ""); // there should be some error messagE
        }

        [TestMethod]
        public void DateAddMinPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-11);
            string dateadd = TestDate.ToString();
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(2);
            string dateadd = TestDate.ToString();
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddMaxMinusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(1);
            string dateadd = TestDate.ToString();
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(3);
            string dateadd = TestDate.ToString();
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-4);
            string dateadd = TestDate.ToString();
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddInvalid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string dateadd = "fruit"; // test data
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMin()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string ContactNumber = "123";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, ""); //should not be an error
        }

        [TestMethod]
        public void ContactNumberMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string ContactNumber = "1234";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, ""); //should not be an error
        }

        [TestMethod]
        public void ContactNumberMinMinusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string ContactNumber = "12";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreNotEqual(Error, "");
        }

        //status: did name, hiredate, doing contact number

        [TestMethod]
        public void ContactNumberMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string ContactNumber = "+240 87092 5333";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, ""); //should not be an error
        }

        [TestMethod]
        public void ContactNumberMaxMinusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string ContactNumber = "+240 87092 533";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, ""); //should not be an error
        }
    }
}

  

