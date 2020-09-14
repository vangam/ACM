using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ACM.BL
{
     public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Vanga Street";
                address.StreetLine2 = "Vanga";
                address.City = "Ananthapalli";
                address.State = "AP";
                address.Country = "India";
                address.PostalCode = "534111";
            }
            return address;
        }

        public bool Save(Address address)
        {
            return true;
        }
       
    }

    
}
