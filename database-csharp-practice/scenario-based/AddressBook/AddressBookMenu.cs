using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBookMenu
    {
        private AddressBookUtility addressBookUtility;

        public AddressBookMenu(AddressBookUtility utility)
        {
            addressBookUtility = utility;
        }
        public void ShowMenu()
        {
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
                Console.WriteLine("14. Save CSV (Thread)");
                Console.WriteLine("15. Load CSV (Thread)");
                Console.WriteLine("16. Save JSON (Thread)");
                Console.WriteLine("17. Load JSON (Thread)");
                Console.WriteLine("18. Save to Database");
                Console.WriteLine("19. Load from Database");


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
                        addressBookUtility.WriteToJson(); //UC-15 Write JSON
                        break;

                    case "13":
                        addressBookUtility.ReadFromJson(); // UC-15 Read JSON
                        break;
                    case "14":
                        addressBookUtility.WriteToCSVThreaded();  // UC-17 Write CSV Threaded
                        break;

                    case "15":
                        addressBookUtility.ReadFromCSVThreaded();   // UC-17 Read CSV Threaded
                        break;

                    case "16":
                        addressBookUtility.WriteToJsonThreaded();   // UC-17 Write JSON Threaded
                        break;

                    case "17":
                        addressBookUtility.ReadFromJsonThreaded();  // UC-17 Read JSON Threaded
                        break;
                    case "18":
                        addressBookUtility.SaveAddressBook();   // UC-18 Save to Database
                        break;
                    case "19":
                        addressBookUtility.LoadAddressBook();  // UC-18 Load from Database
                        addressBookUtility.DisplayContacts();  // Display loaded contacts
                        break;


                    default:
                        Console.WriteLine("\nInvalid option. Please try again.\n");
                        break;
                }
            }
        }
    }
}
