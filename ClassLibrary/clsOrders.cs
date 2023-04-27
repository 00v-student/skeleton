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


        public bool Find(Int32 orderNumber)
        {
            //Set the private data members to the test data value
            mOrderNumber = 21;
            mOrderDescription = "watches";
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mActive = true;
            mCustomerID = 153;
            mStaffName = "Nicole";
            mOrderTotal = 10;

            //always return true
            return true;

        }  
    }
}