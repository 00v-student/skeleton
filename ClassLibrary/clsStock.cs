using System;
namespace ClassLibrary
{
    public class clsStock
    {
        private int mwatchid;
        public int watchid {
            get {
                return mwatchid;
            }
            set {
                mwatchid = value;
            }
        }

        private bool mavailable;
            public bool available { 
            get {
                return mavailable;
            }
            set {
                mavailable = value;
            }
        }
        private DateTime mdateadd;
        
        public DateTime dateadd
        {
            get
            {
                return mdateadd;
            }
            set
            {
                mdateadd = value;
            }
        }
        private string mtype;
       
        public String type
        {
            get
            {
                return mtype;
            }
            set
            {
                mtype = value;
            }
        }
        private string mdesc;
        public String desc
        {
            get
            {
                return mdesc;
            }
            set
            {
                mdesc = value;
            }
        }
        private float mPrice;
        public float price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        private int mStock;
        public int stock
        {
            get
            {
                return mStock;
            }
            set
            {
                mStock = value;
            }
        }
        public bool Find(int testno)
        {
            mwatchid = 2; 
            mdesc = "Test";
            mtype = "analog";
            mPrice = 0.0F;
            mStock = 1;
            mdateadd = Convert.ToDateTime("16/9/2015");
            mavailable = true;
            //always return true
            return true;
        }
    }
}