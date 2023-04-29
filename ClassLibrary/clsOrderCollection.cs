using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {

        //private data member for the list
        List<clsOrders> mOrderList = new List<clsOrders>();

    public clsOrderCollection()
        {
        //create the items of test data
        clsOrders TestItem = new clsOrders(); 
        //set its properties
        TestItem.Active = true;
        TestItem.OrderNumber = 1;
        TestItem.OrderDescription = "bluewatch";
        TestItem.OrderDate = DateTime.Now.Date;
        TestItem.OrderTotal = 1;
        TestItem.StaffName = "John";
        TestItem.CustomerID = 45;
        //add the item to the test list
        mOrderList.Add(TestItem);
        //re initialise the object for some new data
        TestItem = new clsOrders();
        //set its properties
        TestItem.Active = true;
        TestItem.OrderNumber = 2;
        TestItem.OrderDescription = "brownwatch";
        TestItem.OrderDate = DateTime.Now.Date;
        TestItem.OrderTotal = 2;
        TestItem.StaffName = "Jeff";
        TestItem.CustomerID = 55;
        //add the item to the test list
        mOrderList.Add(TestItem);  
        }

        public clsOrderCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //Object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_SelectAll");
            //Get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //Create a blank Order
                clsOrders AnOrders = new clsOrders();
                //read in the fields from the current record
                AnOrders.OrderNumber = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNumber"]);
                AnOrders.OrderDescription = Convert.ToString(DB.DataTable.Rows[0]["OrderDescription"]);
                AnOrders.OrderTotal = Convert.ToInt32(DB.DataTable.Rows[0]["OrderTotal"]);
                AnOrders.Active = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                AnOrders.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                AnOrders.StaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                AnOrders.CustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["Customer ID"]);
                //add the record to the private data member
                mOrderList.Add(AnOrders);
                //Point at the next record
                Index++;

            }

        }

        public List<clsOrders> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the private data
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsOrders ThisOrders { get; set; }


        public List<clsOrders> OrdersList { get; set; }
    }



}
