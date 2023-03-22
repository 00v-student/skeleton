using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstCustomer
    {
         string firstname = "Lauren";
         string lastname = "Jenkins";
         string dateofbirth = DateTime.Now.ToString();
         string phonenumber = "07875847364";
         string emailaddress = "laurenjen43@outlook.com";
         string verifiedaccount = bool.TrueString;
         string gender = "M";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void FirstNameOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestFirstName = "Samantha";
            AnCustomer.FirstName = TestFirstName;
            Assert.AreEqual(AnCustomer.FirstName, TestFirstName);
        }

        [TestMethod]
        public void LastNameOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestLastName = "Jones";
            AnCustomer.LastName = TestLastName;
            Assert.AreEqual(AnCustomer.LastName, TestLastName);
        }
        public void DateOfBirthOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            DateTime TestDateOfBirth = DateTime.Now;
            AnCustomer.DateOfBirth = TestDateOfBirth;
            Assert.AreEqual(AnCustomer.DateOfBirth, TestDateOfBirth);
        }

        [TestMethod]
        public void PhoneNumberOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestPhoneNumber = "07754385754";
            AnCustomer.PhoneNumber = TestPhoneNumber;
            Assert.AreEqual(AnCustomer.PhoneNumber, TestPhoneNumber);
        }

        [TestMethod]
        public void EmailAddressOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestEmail = "samanthajo21@gmail.com";
            AnCustomer.EmailAddress = TestEmail;
            Assert.AreEqual(AnCustomer.EmailAddress, TestEmail);
        }

        [TestMethod]
        public void VerifiedAccountOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            bool TestVerifiedAccount = true;
            AnCustomer.VerifiedAccount = TestVerifiedAccount;
            Assert.AreEqual(AnCustomer.VerifiedAccount, TestVerifiedAccount);
        }

        [TestMethod]
        public void GenderOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestGender = "M";
            AnCustomer.Gender = TestGender;
            Assert.AreEqual(AnCustomer.Gender, TestGender);

        }

        [TestMethod]
        public void ValidOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            Error = AnCustomer.Valid(firstname, lastname, dateofbirth, phonenumber, emailaddress, verifiedaccount, gender);
            Assert.AreEqual(Error, "");

        }
    }
}
