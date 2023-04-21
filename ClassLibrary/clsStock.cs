using System;
namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mwatchid;
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
        private decimal mPrice;
        public decimal price
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
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@watchid", testno);
            DB.Execute("sproc_dbWatch_filterby");
            if (DB.Count == 1)
            {
                mwatchid = Convert.ToInt32(DB.DataTable.Rows[0]["watchid"]);
                mStock = Convert.ToInt32(DB.DataTable.Rows[0]["stock"]);
                mdesc = Convert.ToString(DB.DataTable.Rows[0]["desc"]);
                mtype = Convert.ToString(DB.DataTable.Rows[0]["type"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["price"]);
                mdateadd = Convert.ToDateTime(DB.DataTable.Rows[0]["dateadd"]);
                mavailable = Convert.ToBoolean(DB.DataTable.Rows[0]["available"]);
                //always return true
                return true;
            }
            else { return false; }
            
            
        }

        public string Valid(string desc, string price, string dateadd, string stock, string type)
        {
            string err = "";
            DateTime dateaddtmp;



            
            try
            {

                dateaddtmp = Convert.ToDateTime(dateadd);

                if (dateaddtmp < DateTime.Now.Date.AddYears(-40))
                {
                    err = err + "Your date cannot be over 40 years past today.";
                }
                if (dateaddtmp > DateTime.Now.Date.AddYears(5))
                {
                    err = err + "Your date cannot be over 5 years in the future.";
                }

            }
            catch
            {
                err = err + "You have not entered a valid date.";
            }
            if (desc.Length < 3)
            {
                err += "Your desc is too short";
            }
            if (desc.Length > 50)
            {
                err += "Whoa! Your desc is way too large.";
            }
            if ((type != "digital") && (type != "analog") )
            {
                err += "You must enter either digital or analog           , please ensure you get the casing correct.";
            }
            if (Convert.ToDecimal(price) < 1.0m)
            {
                err = err + "too low";
            }
            if (Convert.ToDecimal(price) > 1000000.0m)
            {
                err = err + "too high";
            }
            if (Convert.ToInt32(stock) < 0)
            {
                err = err + "too less";
            }
            if (Convert.ToInt32(stock) > 100)
            {
                err = err + "too many";
            }
            return err;
        }
    }
}