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
            testStock.type = "digital";
            TestList.Add(testStock);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection allstock = new clsStockCollection();
            clsStock test = new clsStock();
            Int32 pk = 0;
            test.available = true;
            test.desc = "abcdef";
            test.price = 100.0m;
            test.stock = 5;
            test.dateadd = DateTime.Now.Date;
            test.type = "analog";
            allstock.ThisStock = test;
            pk = allstock.Add();
            test.watchid = pk;
            allstock.ThisStock.Find(pk);
            Assert.AreEqual(allstock.ThisStock, test);

        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection allstock = new clsStockCollection();
            clsStock test = new clsStock();
            Int32 pk = 0;
            test.available = true;
            test.desc = "abcdef";
            test.price = 100.0m;
            test.stock = 5;
            test.dateadd = DateTime.Now.Date;
            test.type = "analog";
            allstock.ThisStock = test;
            pk = allstock.Add();
            test.watchid = pk;
            test.available = false;
            test.desc = "abcdefgh";
            test.price = 105.0m;
            test.stock = 10;
            test.dateadd = DateTime.Now.Date;
            test.type = "digital";
            allstock.ThisStock = test;
            allstock.Update();
            allstock.ThisStock.Find(pk);
            Assert.AreEqual(allstock.ThisStock, test);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection allstock = new clsStockCollection();
            clsStock test = new clsStock();
            Int32 pk = 0;
            test.available = true;
            test.desc = "abcdef";
            test.price = 100.0m;
            test.stock = 5;
            test.dateadd = DateTime.Now.Date;
            test.type = "analog";
            allstock.ThisStock = test;
            pk = allstock.Add();
            test.watchid = pk;
            allstock.ThisStock.Find(pk);
            allstock.Delete();
            Boolean found = allstock.ThisStock.Find(pk);
            Assert.IsFalse(found);

        }
        [TestMethod]
        public void ReportByTypeMethodOK()
        {
            clsStockCollection allstock = new clsStockCollection();
            clsStockCollection filterstock = new clsStockCollection();
            filterstock.ReportBytype("");
            Assert.AreEqual(allstock.Count, filterstock.Count);
        }
        [TestMethod]
        public void ReportBytypenonefound()
        {
            clsStockCollection allstock = new clsStockCollection();
            clsStockCollection filterstock = new clsStockCollection();
            filterstock.ReportBytype("xyz");
            Assert.AreEqual(0, filterstock.Count);
        }
        [TestMethod]
        public void ReportBytypetestdatafound()
        {
            clsStockCollection filter = new clsStockCollection();
            Boolean Ok = true;
            filter.ReportBytype("digital");
            if (filter.Count == 3)
            {
                if (filter.StockList[0].watchid != 4)
                {
                    Ok = false;
                }
            }
            else Ok = false;
            Assert.IsTrue(Ok);
        }
    }
}
