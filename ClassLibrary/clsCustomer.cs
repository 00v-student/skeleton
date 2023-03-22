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

        public string Valid(string firstname, string lastname, string dateofbirth, string phonenumber, string emailaddress, string verifiedaccount, string gender)
        {
            return "";
        }
    }
}