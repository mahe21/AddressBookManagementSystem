using System.Diagnostics.Contracts;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            Console.WriteLine("=== Address Book ===");

            while (true)
            {
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Delete Contact");
                Console.WriteLine("3. Display Contacts");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Contact newContact = new Contact();

                        Console.Write("First Name: ");
                        newContact.FirstName = Console.ReadLine();

                        Console.Write("Last Name: ");
                        newContact.LastName = Console.ReadLine();

                        Console.Write("Address: ");
                        newContact.Address = Console.ReadLine();

                        Console.Write("City: ");
                        newContact.City = Console.ReadLine();

                        Console.Write("State: ");
                        newContact.State = Console.ReadLine();

                        Console.Write("ZIP Code: ");
                        newContact.Zip = Console.ReadLine();

                        Console.Write("Phone Number: ");
                        newContact.PhoneNumber = Console.ReadLine();

                        Console.Write("Email: ");
                        newContact.Email = Console.ReadLine();

                        addressBook.AddContact(newContact);

                        Console.WriteLine("Contact added successfully!");
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.Write("Enter the first name of the contact to delete: ");
                        string firstNameToDelete = Console.ReadLine();

                        Console.Write("Enter the last name of the contact to delete: ");
                        string lastNameToDelete = Console.ReadLine();

                        addressBook.DeleteContact(firstNameToDelete, lastNameToDelete);
                        Console.WriteLine();
                        break;

                    case "3":
                        Console.WriteLine("=== Contacts ===");
                        addressBook.DisplayContacts();
                        break;

                    case "4":
                        Console.WriteLine("Exiting...");
                        return;
                }
            }
        }
    }
}