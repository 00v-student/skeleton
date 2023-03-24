using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool VerifiedAccount { get; set; }
        public string Gender { get; set; }
        public string CustomerID { get; set; }

        public string Valid(string CustomerID, string FirstName, string LastName, string DateOfbirth, string PhoneNumber, string EmailAddress, string VerifiedAccount, string Gender)
        {
            string Error = "";

            if (FirstName.Length == 0)
            {
                Error =  "First Name cannot be blank";
            }
            else if(FirstName.Length < 1)
            {
                Error = "First Name must be at least 1 characters";
            }
            else if(FirstName.Length > 50)
            {
                Error = "First Name must be less than or equal to 50 characters";
            }
            if(PhoneNumber.Length < 3)
            {
                Error += "Phone Number must be at least 3 characters";
            }
            if (PhoneNumber.Length > 11)
            {
                Error += "Phone number must be at most 11 characters";
            }

            return Error;
           
        }

        public string Valid(string customerID, string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string emailAddress, string verifiedAccount, string gender)
        {
            string Error = "";


            DateTime DateOfBirthMin = DateTime.Today.AddYears(-100);
            DateTime DateOfBirthMax = DateTime.Today.AddYears(-18);

            if (dateOfBirth < DateOfBirthMin)
            {
                Error = "The date of birth cannot be more than 100 years ago.";
            }
            else if (dateOfBirth > DateOfBirthMax)
            {
                Error = "The customer must be 18 or older to register.";
            }
            
            return Error;

        }
    }
}
