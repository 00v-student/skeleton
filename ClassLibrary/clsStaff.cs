using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int16 mStaffId;
        private string mName;
        private string mDepartment;
        private string mContactNumber;
        private bool mWeekendAvailability;
        private DateTime mHireDate;


        public bool WeekendAvailability
        {
            get
            {
                return mWeekendAvailability;
            }
            set
            {
                mWeekendAvailability = value;
            }
        }

        public DateTime HireDate
        {
            get
            {
                return mHireDate;
            }
            set
            {
                mHireDate = value;
            }
        }

        public Int16 StaffId
        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
        }

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }

        public string ContactNumber
        {
            get
            {
                return mContactNumber;
            }
            set
            {
                mContactNumber = value;
            }
        }



        public bool Find(Int16 StaffId)
        {
            //clsStaffDBConnection DB = new clsStaffDBConnection();  //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();  //create an instance of the data connection
            DB.AddParameter("@StaffId", StaffId); //add the parameter for the address no to search for
            DB.Execute("sproc_tblStaff_FilterByStaffId");  //execute the stored procedure
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffId = Convert.ToInt16(DB.DataTable.Rows[0]["StaffId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                mContactNumber = Convert.ToString(DB.DataTable.Rows[0]["ContactNumber"]);
                mHireDate = Convert.ToDateTime(DB.DataTable.Rows[0]["HireDate"]);
                mWeekendAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["WeekendAvailability"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string name, string department, string contactNumber, string hireDate)
        {
            string Error = "";
            DateTime HireDateTemp;
            

           
            if (name.Length == 0)
            {
                Error = Error + "You have not typed any Name : ";
            } 
            if (name.Length > 50)
            {
                Error = Error + "Your name is too large : ";
            }
            try
            {

                HireDateTemp = Convert.ToDateTime(hireDate);

                if (HireDateTemp < DateTime.Now.Date.AddYears(-40))
                {
                    Error = Error + "Your hiring date cannot be over 40 years past today.";
                }
                if (HireDateTemp > DateTime.Now.Date.AddYears(5))
                {
                    Error = Error + "Your hiring date cannot be over 5 years in the future.";
                }
            } catch
            {
                Error = Error + "You have not entered a valid date.";
            }
            if (contactNumber.Length < 3)
            {
                Error += "Your contact number is too short";
            }
            if (contactNumber.Length > 50)
            {
                Error += "Whoa! Your contact number is way too large.";
            }
            return Error;
        }

       

    }
}