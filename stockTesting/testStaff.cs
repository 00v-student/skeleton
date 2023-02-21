using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class testStaff
    {
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
            Int32 TestID = 20;
            AStaff.StaffID = TestID;
            Assert.AreEqual(AStaff.StaffID, TestID);
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

      
    }
}
