using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ClassLibrary;

namespace TestingStaff
{
    [TestClass]
    public class TstStaffCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff testStaff = new clsStaff();
            testStaff.StaffId = 3;
            testStaff.Department = "HR";
            testStaff.ContactNumber = "+966 28928 7131";
            testStaff.WeekendAvailability = true;
            testStaff.HireDate = DateTime.Now.AddYears(-5);
            testStaff.Name = "Cheese Cake";
            TestList.Add(testStaff);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff testStaff = new clsStaff();
            testStaff.StaffId = 3;
            testStaff.Department = "HR";
            testStaff.ContactNumber = "+966 28928 7131";
            testStaff.WeekendAvailability = true;
            testStaff.HireDate = DateTime.Now.AddYears(-5);
            testStaff.Name = "Cheese Cake";
            AllStaff.ThisStaff = testStaff;
            Assert.AreEqual(AllStaff.ThisStaff, testStaff);
        }


        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff testStaff = new clsStaff();
            testStaff.StaffId = 3;
            testStaff.Department = "HR";
            testStaff.ContactNumber = "+966 28928 7131";
            testStaff.WeekendAvailability = true;
            testStaff.HireDate = DateTime.Now.AddYears(-5);
            testStaff.Name = "Cheese Cake";
            TestList.Add(testStaff);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }



    }

    
}
