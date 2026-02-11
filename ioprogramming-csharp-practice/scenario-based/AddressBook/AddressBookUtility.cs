using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace AddressBook
{
    internal class AddressBookUtility : IAddressbook
    {
        private List<AddressBook> addressBooks = new List<AddressBook>();        // UC-5 Added Ability to add multiple person to Address Book
        private int count = 0;
        private const string filePath = "D:\\csharp\\AddressBook\\\\AddressBook\\AddressBook.txt"; // UC-13 File IO
        private const string csvPath = "D:\\csharp\\AddressBook\\AddressBook\\AddressBook.csv"; // UC-14 CSV File IO
        private const string jsonPath ="D:\\csharp\\AddressBook\\AddressBook\\AddressBook.json";
        public void AddContact() // UC-2 Method to Add Contact Details
        {
            AddressBook contact = new AddressBook();

            Console.Write("Enter First Name: ");
            contact.firstName = Console.ReadLine();

            // UC-6 & UC-7: Unique First Name
            if (addressBooks.Any(x =>
                x.firstName.Equals(contact.firstName, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Duplicate contact not allowed.");
                return;
            }

            Console.Write("Enter Last Name: ");
            contact.lastName = Console.ReadLine();
            Console.Write("Enter Address: ");
            contact.address = Console.ReadLine();
            Console.Write("Enter City: ");
            contact.city = Console.ReadLine();
            Console.Write("Enter State: ");
            contact.state = Console.ReadLine();
            Console.Write("Enter Zip: ");
            contact.zip = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            contact.phoneNumber = Console.ReadLine();
            Console.Write("Enter Email: ");
            contact.email = Console.ReadLine();

            addressBooks.Add(contact);

            Console.WriteLine("\nContact added successfully.\n");
            Console.WriteLine(contact);
        }

        public void EditContact() // UC-3 Method to Edit Contact Details
        {
            Console.WriteLine("Enter First Name to edit:");
            string person = Console.ReadLine();

            AddressBook contact = addressBooks
                .FirstOrDefault(x => x.firstName.Equals(person, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            while (true)
            {
                Console.WriteLine("\n1.First Name 2.Last Name 3.Address 4.City 5.State 6.Zip 7.Phone 8.Email 0.Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0: return;
                    case 1: contact.firstName = Console.ReadLine(); break;
                    case 2: contact.lastName = Console.ReadLine(); break;
                    case 3: contact.address = Console.ReadLine(); break;
                    case 4: contact.city = Console.ReadLine(); break;
                    case 5: contact.state = Console.ReadLine(); break;
                    case 6: contact.zip = Console.ReadLine(); break;
                    case 7: contact.phoneNumber = Console.ReadLine(); break;
                    case 8: contact.email = Console.ReadLine(); break;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }
        }

        public void DeleteContact() // UC-4 Method to Delete Contact Details
        {
            Console.WriteLine("Enter First Name to delete:");
            string person = Console.ReadLine();

            AddressBook contact = addressBooks
                .FirstOrDefault(x => x.firstName.Equals(person, StringComparison.OrdinalIgnoreCase));

            if (contact != null)
            {
                addressBooks.Remove(contact);
                Console.WriteLine("Contact deleted successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        public void DisplayContacts()
        {
            if (!addressBooks.Any())
            {
                Console.WriteLine("Address Book is empty.");
                return;
            }

            foreach (var contact in addressBooks)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine(contact);
            }
        }

        public void SearchPersonByCityOrState() // UC-8 Ability to search person by city or state
        {
            Console.WriteLine("Enter City or State:");
            string location = Console.ReadLine();

            var results = addressBooks
                .Where(x => x.city.Equals(location, StringComparison.OrdinalIgnoreCase) ||
                            x.state.Equals(location, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (!results.Any())
            {
                Console.WriteLine("No contacts found.");
                return;
            }

            foreach (var contact in results)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine(contact);
            }

            Console.WriteLine($"Total contacts found: {results.Count}");
        }

        public void SortEntriesByName() // UC-11 Ability to sort entries alphabetically by Person's name
        {
            addressBooks = addressBooks
                .OrderBy(x => x.firstName)
                .ToList();

            Console.WriteLine("Contacts sorted by name.");
        }

        public void SortEntriesByCityStateOrZip() // UC-12 Ability to sort entries by City, State or Zip
        {
            Console.WriteLine("1.City 2.State 3.Zip");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    addressBooks = addressBooks.OrderBy(x => x.city).ToList();
                    break;
                case 2:
                    addressBooks = addressBooks.OrderBy(x => x.state).ToList();
                    break;
                case 3:
                    addressBooks = addressBooks.OrderBy(x => x.zip).ToList();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            Console.WriteLine("Contacts sorted successfully.");
        }

        public void WriteToFile() // UC-13 File IO
        {
            File.WriteAllLines("AddressBook.txt",
                addressBooks.Select(x =>
                    $"{x.firstName},{x.lastName},{x.address},{x.city},{x.state},{x.zip},{x.phoneNumber},{x.email}"
                )
            );
            Console.WriteLine("Saved to file.");
        }

        public void ReadFromFile() // UC-13 File IO
        {
            if (!File.Exists("AddressBook.txt"))
            {
                Console.WriteLine("File not found.");
                return;
            }

            addressBooks.Clear();

            foreach (string line in File.ReadAllLines("AddressBook.txt"))
            {
                string[] data = line.Split(',');

                addressBooks.Add(new AddressBook
                {
                    firstName = data[0],
                    lastName = data[1],
                    address = data[2],
                    city = data[3],
                    state = data[4],
                    zip = data[5],
                    phoneNumber = data[6],
                    email = data[7]
                });
            }

            Console.WriteLine("Loaded from file.");
        }
        public void WriteToCSV() // UC-14 (CSV)
        {
            try
            {
                string directory = Path.GetDirectoryName(csvPath);
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                using (StreamWriter writer = new StreamWriter(csvPath))
                {
                    // CSV Header
                    writer.WriteLine("FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email");

                    foreach (var c in addressBooks)
                    {
                        writer.WriteLine(
                            $"{c.firstName},{c.lastName},{c.address},{c.city},{c.state},{c.zip},{c.phoneNumber},{c.email}"
                        );
                    }
                }

                Console.WriteLine("Address Book saved as CSV successfully.");
                Console.WriteLine(csvPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("CSV Write Error: " + ex.Message);
            }
        }
        public void ReadFromCSV() // UC-14 (CSV)
        {
            try
            {
                if (!File.Exists(csvPath))
                {
                    Console.WriteLine("CSV file not found.");
                    return;
                }

                addressBooks.Clear();

                using (StreamReader reader = new StreamReader(csvPath))
                {
                    string line;
                    bool isHeader = true;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (isHeader)
                        {
                            isHeader = false;
                            continue; // skip header
                        }

                        string[] data = line.Split(',');

                        addressBooks.Add(new AddressBook
                        {
                            firstName = data[0],
                            lastName = data[1],
                            address = data[2],
                            city = data[3],
                            state = data[4],
                            zip = data[5],
                            phoneNumber = data[6],
                            email = data[7]
                        });
                    }
                }

                Console.WriteLine("Address Book loaded from CSV successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("CSV Read Error: " + ex.Message);
            }
        }
        public void WriteToJson()
        {
            try
            {
                // Ensure directory exists
                string directory = Path.GetDirectoryName(jsonPath);
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true   // pretty format
                };

                string json = JsonSerializer.Serialize(addressBooks, options);
                File.WriteAllText(jsonPath, json);

                Console.WriteLine("Address Book saved as JSON successfully.");
                Console.WriteLine(jsonPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("JSON Write Error: " + ex.Message);
            }
        }
        public void ReadFromJson()
        {
            try
            {
                if (!File.Exists(jsonPath))
                {
                    Console.WriteLine("JSON file not found.");
                    return;
                }

                string json = File.ReadAllText(jsonPath);

                addressBooks = JsonSerializer.Deserialize<List<AddressBook>>(json);

                Console.WriteLine("Address Book loaded from JSON successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("JSON Read Error: " + ex.Message);
            }
        }


    }
}
