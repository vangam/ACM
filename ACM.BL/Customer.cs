using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
        private string _lastName;

        public Customer(): this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerID = customerId;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public static int InstantCount { get; set; }



 
        
        public bool Validate()
        {
            var isvalid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isvalid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isvalid = false;

            return isvalid;
        }
    }
}
