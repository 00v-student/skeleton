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
        public void SupplierIDOK()
        {
            clsStock AStock = new clsStock();
            Int32 TestID = 20;
            AStock.supplierid = TestID;
            Assert.AreEqual(AStock.supplierid, TestID);
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
            float Testp = 0.0F;
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

    }
}
