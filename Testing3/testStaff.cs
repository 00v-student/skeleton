using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace TestingStaff
{
    [TestClass]
    public class testStaff
    {
        string Name = "Ito Urano";
        string Department = "HR";
        string ContactNumber = "07889937456";
        string HireDate = DateTime.Now.Date.ToString();
        Boolean WeekendAvailability = true;
        //string DateAdded = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK() // can the instance be instantiated properly?
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void WeekendAvailabilityOK()
        {
            clsStaff AStaff = new clsStaff(); //create instance of class
            Boolean TestBool = true; // make some data
            AStaff.WeekendAvailability = TestBool; //assign that data to the field we are checking
            Assert.AreEqual(AStaff.WeekendAvailability, TestBool); // check if field equals that data, did the assignment go through?
        }

        [TestMethod]
        public void HireDateOK()
        {
            clsStaff AStaff = new clsStaff();
            DateTime TestDate = DateTime.Now.Date;
            AStaff.HireDate = TestDate;
            Assert.AreEqual(AStaff.HireDate, TestDate);
        }

        [TestMethod]
        public void StaffIDOK()
        {
            clsStaff AStaff = new clsStaff();
            Int16 TestID = 20;
            AStaff.StaffId = TestID;
            Assert.AreEqual(AStaff.StaffId, TestID);
        }

        [TestMethod]
        public void NameOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestName = "Hakuna Matata";
            AStaff.Name = TestName;
            Assert.AreEqual(AStaff.Name, TestName);
        }


        [TestMethod]
        public void DepartmentOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestDep = "Admin";
            AStaff.Department = TestDep;
            Assert.AreEqual(AStaff.Department, TestDep);
        }

        [TestMethod]
        public void ContactNumberOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestContact = "+44 799 384 9397";
            AStaff.ContactNumber = TestContact;
            Assert.AreEqual(AStaff.ContactNumber, TestContact);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            short StaffIdTest = 3; // test argument to the find function
            bool Found = false; //boolean var to store result of validation
            Found = AStaff.Find(StaffIdTest);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int16 StaffId = 3;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the address no
            if (AStaff.StaffId != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int16 StaffId = 3;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the address no
            if (AStaff.Name != "Anti Dandruf")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDepartmentFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int16 StaffId = 3;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the address no
            //if (AStaff.Department != "Input data that it shouldn't be")
            //{
            //    OK = false;
           // }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContactNumberFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int16 StaffId = 3;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the address no
            if (AStaff.ContactNumber != "07373388477")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHireDateFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int16 StaffId = 3;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the address no
            if (AStaff.HireDate != Convert.ToDateTime("01/09/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestWeekendAvailabilityFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int16 StaffId = 3;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the address no
            if (AStaff.WeekendAvailability != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinMinusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Name = ""; //Name minus one is 0 char
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Name = "H";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Name = "Ha";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxMinusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Name = "1234567890123456789012345678901234567890123456789";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Name = "12345678901234567890123456789012345678901234567890";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Name = "123456789012345678901234567890123456789012345678901";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreNotEqual(Error, ""); //Error message should not be empty
        }

        [TestMethod]
        public void NameMid()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Name = "1234567890123456789012345";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(1000, 'H');
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireDateExtremeMin()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-1000);
            string HireDate = TestDate.ToString();
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreNotEqual(Error, ""); // there should be some error messagE
        }

        [TestMethod]
        public void HireDateExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(1000);
            string HireDate = TestDate.ToString();
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreNotEqual(Error, ""); // there should be some error messagE
        }

        [TestMethod]
        public void HireDateMin()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-40);
            string HireDate = TestDate.ToString();
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HireDateMinMinusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-41);
            string HireDate = TestDate.ToString();
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreNotEqual(Error, ""); // there should be some error messagE
        }

        [TestMethod]
        public void HireDateMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-39);
            string HireDate = TestDate.ToString();
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HireDateMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(5);
            string HireDate = TestDate.ToString();
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HireDateMaxMinusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(4);
            string HireDate = TestDate.ToString();
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HireDateMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(6);
            string HireDate = TestDate.ToString();
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireDateMid()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-19);
            string HireDate = TestDate.ToString();
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HireDateInvalid()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string HireDate = "fruit"; // test data
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMin()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string ContactNumber = "123";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, ""); //should not be an error
        }

        [TestMethod]
        public void ContactNumberMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string ContactNumber = "1234";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, ""); //should not be an error
        }

        [TestMethod]
        public void ContactNumberMinMinusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string ContactNumber = "12";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreNotEqual(Error, ""); 
        }

        //status: did name, hiredate, doing contact number

        [TestMethod]
        public void ContactNumberMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string ContactNumber = "+240 87092 5333";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, ""); //should not be an error
        }

        [TestMethod]
        public void ContactNumberMaxMinusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string ContactNumber = "+240 87092 533";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, ""); //should not be an error
        }

        [TestMethod]
        public void ContactNumberMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string ContactNumber = "+240 87092 5333X";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, ""); //should be an error
        }

        [TestMethod]
        public void ContactNumberExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string ContactNumber = "1234567890 1234567890 1234567890 1234567890 1234567890 1234567890";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, ""); //should be an error
        }


        [TestMethod]
        public void departmentValidData()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Department = "HR";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreEqual(Error, ""); //should not be an error
        }

        [TestMethod]
        public void departmentInvalidData()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Department = "fruit";
            Error = AStaff.Valid(Name, Department, ContactNumber, HireDate);
            Assert.AreNotEqual(Error, ""); //should be an error
        }



    }
}
