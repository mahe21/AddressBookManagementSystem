using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        public string AddressBookName;
        List<Contact> contacts;
        public AddressBook(string addressBookName)
        {
            contacts = new List<Contact>();
            AddressBookName = addressBookName;
        }
        public void AddContact()
        {
            Contact contact = TakeInputsForContact();
            this.contacts.Add(contact);
            Console.WriteLine("Contact added Sucesfully...!");
        }
        public Contact TakeInputsForContact()
        {
            Console.Write("Enter FirstName: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter lastName: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter phoneNumber: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter city: ");
            string city = Console.ReadLine();
            Console.Write("Enter state: ");
            string state = Console.ReadLine();
            Console.Write("Enter zip: ");
            string pincode = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            Console.Write("Enter Email Adress: ");
            string email = Console.ReadLine();
            Contact contact = new Contact()
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = long.Parse(phoneNumber),
                City = city,
                State = state,
                Pincode = long.Parse(pincode),
                Address = address,
                Email = email
            };
            return contact;
        }
        public void EditContact()
        {
            Console.WriteLine("Enter the FistName of the contact to edit that contact");
            string fName = Console.ReadLine();
            Contact contact = null;
            foreach (var con in contacts)
            {
                if (con.FirstName.Equals(fName))
                {
                    contact = con; break;
                }
            }
            if (contact == null)
            {
                Console.WriteLine("there is no contact with given FirstName...!");
                return;
            }
            contact = TakeInputsForContact();
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].FirstName.Equals(fName))
                {
                    contacts[i] = contact; break;
                }
            }
            Console.WriteLine("Contact Edited successfully");
            return;
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter the FirstName of the contact to Delete");
            string fname = Console.ReadLine();
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].FirstName.Equals(fname))
                {
                    contacts.RemoveAt(i);
                    Console.WriteLine("Contact deleted Successfully");
                    return;
                }
            }
            Console.WriteLine("there is not contact with given FirstName");
            return;
        }
        public override string ToString()
        {
            var listofContacts = "";
            foreach (var contact in contacts)
            {
                listofContacts += contact.ToString();
            }
            return @$"AddressBookName: {this.AddressBookName}\n
            {listofContacts}";
        }
        public void DislpayContacts()
        {
            Console.WriteLine("Enter P for particular Contact or F for full list of contacts");
            char ch = Console.ReadLine().ToUpper()[0];
            switch (ch)
            {
                case 'P':
                    Console.WriteLine("Enter the Fname to print the contact:");
                    string fname = Console.ReadLine();
                    foreach (var contact in contacts)
                    {
                        if (contact.FirstName.Equals(fname))
                        {
                            Console.WriteLine(contact.ToString());
                        }
                    }
                    Thread.Sleep(10000);
                    return;
                case 'F':
                    var listContacts = "";
                    foreach (var contact in contacts)
                    {
                        listContacts += contact.ToString();
                    }
                    Console.WriteLine(listContacts + "\n\nPress any key to exit");
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }

    }
}
