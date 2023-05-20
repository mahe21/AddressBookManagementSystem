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

        public void EditContact(string firstName, string lastName)
        {
            Contact contact = FindContact(firstName, lastName);

            if (contact != null)
            {
                Console.WriteLine("Enter the updated details for the contact:");

                Console.Write("First Name: ");
                contact.FirstName = Console.ReadLine();

                Console.Write("Last Name: ");
                contact.LastName = Console.ReadLine();

                Console.Write("Address: ");
                contact.Address = Console.ReadLine();

                Console.Write("City: ");
                contact.City = Console.ReadLine();

                Console.Write("State: ");
                contact.State = Console.ReadLine();

                Console.Write("ZIP Code: ");
                contact.Zip = Console.ReadLine();

                Console.Write("Phone Number: ");
                contact.PhoneNumber = Console.ReadLine();

                Console.Write("Email: ");
                contact.Email = Console.ReadLine();

                Console.WriteLine("Contact updated successfully!");
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
