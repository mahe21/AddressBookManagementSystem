using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contact
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public long Pincode;
        public long PhoneNumber;
        public string Email;

        public override string ToString()
        {
            return @$"
             Name: {FirstName} {LastName}\n
            Email: {this.Email}\n
            PhoneNumber: {this.PhoneNumber}\n
            City: {this.City}\n
            State: {this.State}\n
            Pincode: {this.Pincode}\n
            Address: {this.Address}\n
            ------------------------------------
            ";
        }
    }
}
