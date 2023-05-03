using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {

        //private data member for the list
        List<clsOrders> mOrderList = new List<clsOrders>();

        clsOrders mThisOrders = new clsOrders();


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

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrders>(); //clear the mStaffList var
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

        public clsOrders ThisOrders
        {
            get
            {
                return mThisOrders;
            }
            set
            {
                mThisOrders = value;
            }
        }


        public List<clsOrders> OrdersList { get; set; }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNumber", mThisOrders.OrderNumber);
            DB.AddParameter("@OrderDescription", mThisOrders.OrderDescription);
            DB.AddParameter("@OrderTotal", mThisOrders.OrderTotal);
            DB.AddParameter("@OrderComplete", mThisOrders.Active);
            DB.AddParameter("@OrderDate", mThisOrders.OrderDate);
            DB.AddParameter("@StaffName", mThisOrders.StaffName);
            DB.AddParameter("@CustomerID", mThisOrders.CustomerID);

            return DB.Execute("sproc_tblOrders_Insert");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }




}
