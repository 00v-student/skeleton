using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstCustomer
    {
         string CustomerID = "2";
         string FirstName = "Lauren";
         string LastName = "Jenkins";
         string DateOfBirth = DateTime.Now.ToString();
         string PhoneNumber = "07875847364";
         string EmailAddress = "laurenjen43@outlook.com";
         string VerifiedAccount = bool.TrueString;
         string Gender = "M";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestCustomerID = "2";
            AnCustomer.CustomerID = TestCustomerID;
            Assert.AreEqual(AnCustomer.CustomerID, TestCustomerID);
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
            Error = AnCustomer.Valid(CustomerID, FirstName, LastName, DateOfBirth, PhoneNumber, EmailAddress, VerifiedAccount, Gender);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMinMinusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string FirstName = ""; //FirstName minus one is 0 char 
            Error = AnCustomer.Valid(CustomerID, FirstName, LastName, DateOfBirth, PhoneNumber, EmailAddress, VerifiedAccount, Gender);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string FirstName = "S";
            Error = AnCustomer.Valid(CustomerID, FirstName, LastName, DateOfBirth, PhoneNumber, EmailAddress, VerifiedAccount, Gender);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string FirstName = "Sh";
            Error = AnCustomer.Valid(CustomerID, FirstName, LastName, DateOfBirth, PhoneNumber, EmailAddress, VerifiedAccount, Gender);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMaxMinusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string FirstName = "8765434567876567656767689098765456321234567876579";
            Error = AnCustomer.Valid(CustomerID, FirstName, LastName, DateOfBirth, PhoneNumber, EmailAddress, VerifiedAccount, Gender);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string FirstName = "87654345678765676567676890987654563212345678765792";
            Error = AnCustomer.Valid(CustomerID, FirstName, LastName, DateOfBirth, PhoneNumber, EmailAddress, VerifiedAccount, Gender);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string FirstName = "876543456787656765676768909876545632123456787657921";
            Error = AnCustomer.Valid(CustomerID, FirstName, LastName, DateOfBirth, PhoneNumber, EmailAddress, VerifiedAccount, Gender);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string FirstName = "7658765437898765456765453";
            Error = AnCustomer.Valid(CustomerID, FirstName, LastName, DateOfBirth, PhoneNumber, EmailAddress, VerifiedAccount, Gender);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(1000, 'S');
            Error = AnCustomer.Valid(CustomerID, FirstName, LastName, DateOfBirth, PhoneNumber, EmailAddress, VerifiedAccount, Gender);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNumberMinMinusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PhoneNumber = ""; //PhoneNumber minus one is 0 char 
            Error = AnCustomer.Valid(CustomerID, FirstName, LastName, DateOfBirth, PhoneNumber, EmailAddress, VerifiedAccount, Gender);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PhoneNumber = "365";
            Error = AnCustomer.Valid(CustomerID, FirstName, LastName, DateOfBirth, PhoneNumber, EmailAddress, VerifiedAccount, Gender);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PhoneNumber = "3656";
            Error = AnCustomer.Valid(CustomerID, FirstName, LastName, DateOfBirth, PhoneNumber, EmailAddress, VerifiedAccount, Gender);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void PhoneNumberMaxMinusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PhoneNumber = "0785766354";
            Error = AnCustomer.Valid(CustomerID, FirstName, LastName, DateOfBirth, PhoneNumber, EmailAddress, VerifiedAccount, Gender);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PhoneNumber = "07857663546";
            Error = AnCustomer.Valid(CustomerID, FirstName, LastName, DateOfBirth, PhoneNumber, EmailAddress, VerifiedAccount, Gender);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PhoneNumber = "078576635468";
            Error = AnCustomer.Valid(CustomerID, FirstName, LastName, DateOfBirth, PhoneNumber, EmailAddress, VerifiedAccount, Gender);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PhoneNumber = "07857";
            Error = AnCustomer.Valid(CustomerID, FirstName, LastName, DateOfBirth, PhoneNumber, EmailAddress, VerifiedAccount, Gender);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(1000, '3');
            Error = AnCustomer.Valid(CustomerID, FirstName, LastName, DateOfBirth, PhoneNumber, EmailAddress, VerifiedAccount, Gender);
            Assert.AreNotEqual(Error, "");
        }

    }
}
