using System.Diagnostics.Contracts;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBookManagement addressBookManagement = new AddressBookManagement();
            while (true)
            {
                Console.WriteLine("Enter O to open an AddressBook\nEnter C to create an AddressBook");
                char input = Console.ReadLine().ToUpper()[0];
                switch (input)
                {
                    case 'O':
                        addressBookManagement.OpenAddressBook();
                        break;
                    case 'C':
                        addressBookManagement.CreateAddressBook();
                        break;
                    default:
                        Console.WriteLine("Invalid Entry try again");
                        break;
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}