using System.Diagnostics.Contracts;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact newContact = new Contact();
            newContact.FirstName = "John";
            newContact.LastName = "Doe";
            newContact.Address = "123 Main Street";
            newContact.City = "Anytown";
            newContact.State = "California";
            newContact.Zip = "12345";
            newContact.PhoneNumber = "(555) 123-4567";
            newContact.Email = "johndoe@example.com";
        }
    }
}