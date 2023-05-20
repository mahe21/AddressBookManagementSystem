using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void DeleteContact(string firstName, string lastName)
        {
            Contact contact = FindContact(firstName, lastName);

            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine("Contact deleted successfully!");
            }
            else
            {
                Console.WriteLine("Contact not found!");
            }
        }

        public void DisplayContacts()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine("First Name: " + contact.FirstName);
                Console.WriteLine("Last Name: " + contact.LastName);
                Console.WriteLine("Address: " + contact.Address);
                Console.WriteLine("City: " + contact.City);
                Console.WriteLine("State: " + contact.State);
                Console.WriteLine("ZIP Code: " + contact.Zip);
                Console.WriteLine("Phone Number: " + contact.PhoneNumber);
                Console.WriteLine("Email: " + contact.Email);
                Console.WriteLine();
            }
        }

        private Contact FindContact(string firstName, string lastName)
        {
            return contacts.Find(c => c.FirstName == firstName && c.LastName == lastName);
        }
    }

}
