using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBookMenu
    {
        public void ShowMenu()
        {
            IAddressbook addressBookUtility = new AddressBookUtility();
            while (true)
            {
                Console.WriteLine("Address Book Menu:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        addressBookUtility.AddContact(); // UC-2 Adding Contact Details
                        break;
                    case "2":
                        addressBookUtility.EditContact(); // UC-3 Edit Contact Details
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
