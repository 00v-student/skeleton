using System;

namespace ClassLibrary
{
    public class clsOrders
    {

        //Private data member for the OrderNumber property
        private Int32 mOrderNumber;

        //OrderNumber Public Property
        public Int32 OrderNumber
        {
            get
            {
                //this line of code sends data out the property
                return mOrderNumber;
            }
            set
            {
                //this line of code allows data into the property
                mOrderNumber = value;
            }


        }

        //private date added data member
        private DateTime mDateAdded;
        //public property for date added
        public DateTime OrderDate
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }

        //private data member for active
        private Boolean mActive;
        //public property for OrderComplete
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        //private data member for OrderDescription
        private string mOrderDescription;
        //public property for OrderDescription
        public string OrderDescription
        {
            get
            {
                //return the private data
                return mOrderDescription;
            }
            set
            {
                //set the private data
                mOrderDescription = value;
            }
        }
        //Private data member for the OrderTotal property
         private Int32 mOrderTotal;

        //OrderComplete Public Property
        public Int32 OrderTotal
        {
            get
            {
                //this line of code sends data out the property
                return mOrderTotal;
            }
            set
            {
                //this line of code allows data into the property
                mOrderTotal = value;
            }


        }

        //Private data member for the CustomerID property
        private Int32 mCustomerID;

        //CustomerID Public Property
        public Int32 CustomerID
        {
            get
            {
                //this line of code sends data out the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }

        //private data member for StaffName
        private string mStaffName;
        //public property for StaffName
        public string StaffName
        {
            get
            {
                //return the private data
                return mStaffName;
            }
            set
            {
                //set the private data
                mStaffName = value;
            }
        }

       
        public bool Find(Int32 OrderNumber)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order number to search for 
            DB.AddParameter("@OrderNumber", OrderNumber);
            //Execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderNumber");
            //if one record is found (there should be one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderNumber = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNumber"]);
                mOrderDescription = Convert.ToString(DB.DataTable.Rows[0]["OrderDescription"]);
                mOrderTotal = Convert.ToInt32(DB.DataTable.Rows[0]["OrderTotal"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderComplete"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["Customer ID"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;

            }
        }


        public string Valid(string orderDescription, string staffName, string orderTotal, string orderDate, string customerID)
        {
            return "";
        }
    }
}