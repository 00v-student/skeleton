using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

  public class clsStaffCollection
    {

        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public clsStaffCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblAddress_SelectAll");
            PopulateArray(DB);
        }

        

        void PopulateArray(clsDataConnection DB)
        {

            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>(); //clear the mStaffList var

            //while there are records to process
            while (Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();

                AStaff.StaffId = Convert.ToInt16(DB.DataTable.Rows[Index]["StaffId"]);
                AStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AStaff.Department = Convert.ToString(DB.DataTable.Rows[Index]["Department"]);
                AStaff.ContactNumber = Convert.ToString(DB.DataTable.Rows[Index]["ContactNumber"]);
                AStaff.HireDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["HireDate"]);
                AStaff.WeekendAvailability = Convert.ToBoolean(DB.DataTable.Rows[Index]["WeekendAvailability"]);
                //add the record to the private data mamber
                mStaffList.Add(AStaff);
                Index++;
            }

        }

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //later
            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisAddress
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@HireDate", mThisStaff.HireDate);
            DB.AddParameter("@WeekendAvailability", mThisStaff.WeekendAvailability);
            DB.AddParameter("@ContactNumber", mThisStaff.ContactNumber);
            DB.AddParameter("@Department", mThisStaff.Department);
            DB.AddParameter("@StaffID", mThisStaff.StaffId);
            DB.AddParameter("@Name", mThisStaff.Name);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblAddress_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisAddress
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AddressNo", mThisStaff.StaffId);
            DB.Execute("sproc_tblAddress_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@HireDate", mThisStaff.HireDate);
            DB.AddParameter("@WeekendAvailability", mThisStaff.WeekendAvailability);
            DB.AddParameter("@ContactNumber", mThisStaff.ContactNumber);
            DB.AddParameter("@Department", mThisStaff.Department);
            DB.AddParameter("@StaffID", mThisStaff.StaffId);
            DB.AddParameter("@Name", mThisStaff.Name);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_Update");
        }

    }


}
