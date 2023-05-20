using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookManagement
    {
        List<AddressBook> _addresses;
        public AddressBookManagement()
        {
            _addresses = new List<AddressBook>();
        }
        public void OpenAddressBook()
        {
            Console.WriteLine("Enter AddressBook Name:");
            string bookName = Console.ReadLine();
            AddressBook addressBook = null;
            foreach (var addr in _addresses)
            {
                if (addr.AddressBookName.Equals(bookName))
                {
                    addressBook = addr;
                    SimulateAddressBook(addressBook);
                    return;
                }
            }
            Console.WriteLine("there is no addressBook with entered name");
        }
        public void CreateAddressBook()
        {
            Console.WriteLine("Enter AddressBook Name:");
            string name = Console.ReadLine();
            _addresses.Add(new AddressBook(name));
            return;
        }
        public void SimulateAddressBook(AddressBook addressBook)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter A to Add new contact\nEnter E to edit a contact\nEnter D to Delete a Contact\nEnter P to print the contacts");
                char ch = Console.ReadLine().ToUpper()[0];
                switch (ch)
                {
                    case 'A':
                        addressBook.AddContact();
                        break;
                    case 'E':
                        addressBook.EditContact();
                        break;
                    case 'D':
                        addressBook.DeleteContact();
                        break;
                    case 'P':
                        addressBook.DislpayContacts();
                        break;
                    default:
                        break;
                }
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Enter 'Back' to go back to AddressBookManagement  or 'No' to stay in current addressBook :");
                string input = Console.ReadLine().ToUpper();
                if (input.Equals("BACK"))
                {
                    flag = false;
                }
            }
        }
        public override string ToString()
        {
            var listOfAddressBooks = "";
            foreach (AddressBook addressBook in _addresses)
            {
                listOfAddressBooks += addressBook.ToString();
            }
            return listOfAddressBooks;
        }
    }
}
