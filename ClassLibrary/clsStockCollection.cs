using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

  public class clsStockCollection
    {

        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();

        public clsStockCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tbldbWatch_SelectAll");
            PopulateArray(DB);
        }

        

        void PopulateArray(clsDataConnection DB)
        {

            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStockList = new List<clsStock>(); //clear the mStockList var

            //while there are records to process
            while (Index < RecordCount)
            {
                clsStock AStock = new clsStock();

                AStock.watchid = Convert.ToInt16(DB.DataTable.Rows[Index]["watchid"]);
                AStock.desc = Convert.ToString(DB.DataTable.Rows[Index]["desc"]);
                AStock.price = Convert.ToDecimal(DB.DataTable.Rows[Index]["price"]);
                AStock.stock = Convert.ToInt32(DB.DataTable.Rows[Index]["stock"]);
                AStock.dateadd = Convert.ToDateTime(DB.DataTable.Rows[Index]["dateadd"]);
                AStock.available = Convert.ToBoolean(DB.DataTable.Rows[Index]["available"]);
                //add the record to the private data mamber
                mStockList.Add(AStock);
                Index++;
            }

        }

        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                //later
            }
        }
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values ofwatchid
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@dateadd", mThisStock.dateadd);
            DB.AddParameter("@available", mThisStock.available);
            DB.AddParameter("@price", mThisStock.price);
            DB.AddParameter("@desc", mThisStock.desc);
            DB.AddParameter("@stock", mThisStock.stock);
            DB.AddParameter("@type", mThisStock.type);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by watchid
            clsDataConnection DB = new clsDataConnection();
            //DB.AddParameter("@watchid", mThisStock.watchid);
            DB.Execute("sproc_tblStock_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of watchid
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@dateadd", mThisStock.dateadd);
            DB.AddParameter("@available", mThisStock.available);
            DB.AddParameter("@price", mThisStock.price);
            DB.AddParameter("@desc", mThisStock.desc);
            DB.AddParameter("@stock", mThisStock.stock);
            DB.AddParameter("@type", mThisStock.type);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }

        

    }
    

}
