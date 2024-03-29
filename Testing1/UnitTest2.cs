﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace stockTest
{
    [TestClass]
    public class testStock

    {
        String watchid = "2";
        String desc = "desc";
        String price = "50.0";
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
            
            Int32 Testno = 1;
            found = AStock.Find(Testno);
           
            Assert.IsTrue(found);
        }
        public void TestWatchidFound()
        {
            clsStock AStock = new clsStock();
            Boolean found = false;
            Boolean OK = true;
            Int32 Testno = 1;
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
            Int32 watchno = 1;
            //invoke the method
            Found = AStock.Find(watchno);
            //check the property
            if (AStock.desc.Length==0)
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
            Int32 watchno = 1;
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
            Int32 watchno = 1;
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
            Int32 watchno = 3;
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
            Int32 watchno = 1;
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
            string desc = "ha"; //desc minus one is 2 char
            Error = AStock.Valid(desc, price, dateadd , stock, type);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void descMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string desc = "Hah";
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void descMinPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string desc = "Haha";
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void descMaxMinusOne()
        {
            clsStock AStock = new clsStock();
            string desc = "1234567890123456789012345678901234567890123456789";
            string Error = AStock.Valid(desc, price, dateadd, stock, type);
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
            string desc = "";
            desc = desc.PadRight(1000, 'H');
            string Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void dateExtremeMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-100);
            string date = TestDate.ToString();
            Error = AStock.Valid(desc, price, date, stock, type);
            Assert.AreNotEqual(Error, ""); // there should be some error messagE
        }

        [TestMethod]
        public void dateExtremeMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(100);
            string date = TestDate.ToString();
            Error = AStock.Valid(desc, price, date, stock, type);
            Assert.AreNotEqual(Error, ""); // there should be some error messagE
        }

        [TestMethod]
        public void dateMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-10);
            string date = TestDate.ToString();
            Error = AStock.Valid(desc, price, date, stock, type);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void dateMinMinusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-9);
            string date = TestDate.ToString();
            Error = AStock.Valid(desc, price, date, stock, type);
            Assert.AreEqual(Error, ""); // there should be some error messagE
        }

        [TestMethod]
        public void dateMinPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-9);
            string date = TestDate.ToString();
            Error += AStock.Valid(desc, price, date, stock, type);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void dateMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(2);
            string date = TestDate.ToString();
            Error = AStock.Valid(desc, price, date, stock, type);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void dateMaxMinusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(1);
            string date = TestDate.ToString();
            Error = AStock.Valid(desc, price, date, stock, type);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void dateMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(3);
            string date = TestDate.ToString();
            Error = AStock.Valid(desc, price, date, stock, type);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void dateMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-4);
            string date = TestDate.ToString();
            Error = AStock.Valid(desc, price, date, stock, type);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void dateInvalid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string date = "fruit"; // test data
            Error = AStock.Valid(desc, price, date, stock, type);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void stockMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string s = "1";
            Error = AStock.Valid(desc, price, dateadd, s, type);
            Assert.AreEqual(Error, ""); //should not be an error
        }

        [TestMethod]
        public void StockMinPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string s = "2";
            Error = AStock.Valid(desc, price, dateadd, s, type);
            Assert.AreEqual(Error,""); //should not be an error
        }

        [TestMethod]
        public void StockMinMinusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string s = "0";
            Error = AStock.Valid(desc, price, dateadd, s, type);
            Assert.AreNotEqual(Error,"");
        }
        [TestMethod]
        public void StockInvalid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string s = "fruit";
            Error = AStock.Valid(desc, price, dateadd, s, type);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockExtremeMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string s = Convert.ToString(Int32.MinValue);
            Error = AStock.Valid(desc, price, dateadd, s, type);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockExtremeMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string s = Convert.ToString(Int32.MaxValue);
            Error = AStock.Valid(desc, price, dateadd, s, type);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StockMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string s = "100";
            Error = AStock.Valid(desc, price, dateadd, s, type);
            Assert.AreEqual(Error, ""); //should not be an error
        }

        [TestMethod]
        public void StockMaxMinusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string s = "99";
            Error = AStock.Valid(desc, price, dateadd, s, type);
            Assert.AreEqual(Error, ""); //should not be an error
        }
        [TestMethod]
        public void StockMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string s = "50";
            Error = AStock.Valid(desc, price, dateadd, s, type);
            Assert.AreEqual(Error, ""); //should not be an error
        }
        [TestMethod]
        public void StockMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string s = "101";
            Error = AStock.Valid(desc, price, dateadd, s, type);
            Assert.AreNotEqual(Error, ""); //should not be an error
        }
        [TestMethod]
        public void PriceMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string price = "1.0";
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreEqual(Error, ""); //should not be an error
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string price = "2.0";
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreEqual(Error, ""); //should not be an error
        }

        [TestMethod]
        public void PriceMinMinusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string price = "0.0";
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreNotEqual(Error, ""); //should  be an error
        }
        [TestMethod]
        public void PriceInvalid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string price = "fruit";
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreNotEqual(Error, ""); //should  be an error
        }
        [TestMethod]
        public void PriceExtremeMin()

        {
            clsStock AStock = new clsStock();
            string Error = "";
            string price = Convert.ToString(decimal.MinValue);
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreNotEqual(Error, ""); //should  be an error
        }
        [TestMethod]
        public void PriceExtremeMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string price = Convert.ToString(decimal.MaxValue);
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreNotEqual(Error, ""); //should  be an error
        }
        [TestMethod]
        public void PriceMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string price = "500000.0";
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreEqual(Error, ""); //should not be an error
        }


        [TestMethod]
        public void PriceMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string price = "1000000.0";
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreEqual(Error, ""); //should not be an error
        }
        [TestMethod]
        public void PriceMaxMinusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string price = "999999.0";
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreEqual(Error, ""); //should not be an error
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string price = "1000001.0";
            Error = AStock.Valid(desc, price, dateadd, stock, type);
            Assert.AreNotEqual(Error, ""); //should  be an error
        }
        [TestMethod]
        public void typecheckwrong()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string t = "digitalanalog";
            Error = AStock.Valid(desc, price, dateadd, stock, t);
            Assert.AreNotEqual(Error, ""); //should  be an error
        }
      
        [TestMethod]
        public void typecheckrightdig()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string t = "digital";
            Error = AStock.Valid(desc, price, dateadd, stock, t);
            Assert.AreEqual(Error, ""); //should  be an error
        }
        [TestMethod]
        public void typecheckrightana()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string t = "analog";
            Error = AStock.Valid(desc, price, dateadd, stock, t);
            Assert.AreEqual(Error,""); //should not be an error
        }

    }
}

  

