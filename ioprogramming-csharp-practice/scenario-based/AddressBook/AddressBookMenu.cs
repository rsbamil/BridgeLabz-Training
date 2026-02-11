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
                Console.WriteLine("\n---------------Address Book Menu --------------------");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Search a contact by city or state");
                Console.WriteLine("5. Sort entries by name");
                Console.WriteLine("6. Sort entries by city , state or zip");
                Console.WriteLine("7. Display All Contact");
                Console.WriteLine("8. Save Address Book to File");
                Console.WriteLine("9. Load Address Book from File");
                Console.WriteLine("10. Save Address Book as CSV");
                Console.WriteLine("11. Load Address Book from CSV");
                Console.WriteLine("12. Save Address Book as JSON");
                Console.WriteLine("13. Load Address Book from JSON");




                Console.Write("\nSelect an option\n");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        return;
                    case "1":
                        addressBookUtility.AddContact(); // UC-2 Adding Contact Details
                        break;
                    case "2":
                        addressBookUtility.EditContact(); // UC-3 Edit Contact Details
                        break;
                    case "3":
                        addressBookUtility.DeleteContact(); // UC-4 Delete Contact Details
                        break;
                    case "4":
                        addressBookUtility.SearchPersonByCityOrState(); // UC-8 Search Person By City or State
                        break;
                    case "5":
                        addressBookUtility.SortEntriesByName(); // UC-11 Sort Entries By Name
                        break;
                    case "6":
                        addressBookUtility.SortEntriesByCityStateOrZip(); // UC-12 Sort Entries By City , State or Zip
                        break;
                    case "7":
                        addressBookUtility.DisplayContacts();
                        break;
                    case "8":
                        addressBookUtility.WriteToFile(); // UC-13 Write
                        break;

                    case "9":
                        addressBookUtility.ReadFromFile(); // UC-13 Read
                        break;
                    case "10":
                        addressBookUtility.WriteToCSV(); // UC-14 Write CSV
                        break;

                    case "11":
                        addressBookUtility.ReadFromCSV(); // UC-14 Read CSV
                        break;
                    case "12":
                        addressBookUtility.WriteToJson();
                        break;

                    case "13":
                        addressBookUtility.ReadFromJson();
                        break;


                    default:
                        Console.WriteLine("\nInvalid option. Please try again.\n");
                        break;
                }
            }
        }
    }
}
