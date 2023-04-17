using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class UnitTest3
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }
        [TestMethod]
        public void StockListPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock testStock = new clsStock();
            testStock.watchid = 3;
            testStock.desc = "watch";
            testStock.price = Convert.ToDecimal("0.0");
            testStock.available = true;
            testStock.dateadd = DateTime.Now.AddYears(-5);
            testStock.type = "CheeseCake";
            TestList.Add(testStock);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);

        }
        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock testStock = new clsStock();
            testStock.watchid = 3;
            testStock.desc = "watch";
            testStock.price = Convert.ToDecimal("0.0");
            testStock.available = true;
            testStock.dateadd = DateTime.Now.AddYears(-5);
            testStock.type = "CheeseCake";
            AllStock.ThisStock = testStock;
            Assert.AreEqual(AllStock.ThisStock, testStock);
        }
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock testStock = new clsStock();
            testStock.watchid = 3;
            testStock.desc = "watch";
            testStock.price = Convert.ToDecimal("0.0");
            testStock.available = true;
            testStock.dateadd = DateTime.Now.AddYears(-5);
            testStock.type = "CheeseCake";
            TestList.Add(testStock);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }


    }
}
