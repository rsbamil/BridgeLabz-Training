using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBookUtility : IAddressbook
    {
        private AddressBook[] addressBooks = new AddressBook[10]; // UC-5 Added Ability to add multiple person to Address Book
        private int count = 0;

        public void AddContact()  // UC-2 Method to Add Contact Details
        {
            if (count == addressBooks.Length)
            {
                Console.WriteLine("Address Book is full. Cannot add more contacts.");
                return;
            }

            AddressBook contact = new AddressBook();

            Console.Write("Enter First Name: ");
            contact.firstName = Console.ReadLine();
            foreach (AddressBook existingContact in addressBooks) // UC-6 There Should be unique name 
            {
                if (existingContact != null && existingContact.firstName.Equals(contact.firstName, StringComparison.OrdinalIgnoreCase)) // UC-7 Ability to ensure no duplicate entry of same person
                {
                    Console.WriteLine("A contact with this first name already exists. Duplicate entries are not allowed.");
                    return;
                }
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
            addressBooks[count++] = contact;

            Console.WriteLine("\nContact added successfully.\n");
            Console.WriteLine("------------------ Added Contact Details ------------------------");

            Console.WriteLine(contact);
        }
        public void EditContact() // UC-3 Method to Edit Contact Details
        {
            Console.WriteLine("ENTER THE NAME OF THE PERSON TO EDIT CONTACT DETAILS:");
            string person = Console.ReadLine();
            foreach (AddressBook contact in addressBooks)
            {
                if (contact != null && contact.firstName.Equals(person, StringComparison.OrdinalIgnoreCase))
                {
                    while (true)
                    {
                        Console.WriteLine("WHAT YOU WANT TO UPDATE :");
                        Console.WriteLine("1. First Name");
                        Console.WriteLine("2. LastName");
                        Console.WriteLine("3. Address");
                        Console.WriteLine("4. City");
                        Console.WriteLine("5. State");
                        Console.WriteLine("6. Zip");
                        Console.WriteLine("7. Phone Number");
                        Console.WriteLine("8. Email");
                        Console.WriteLine("Enter '0' to exit.");
                        Console.WriteLine("Enter your choice: ");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 0:
                                Console.WriteLine("\nUpdated Contact");
                                Console.WriteLine(contact);
                                return;
                            case 1:
                                Console.WriteLine("\nEnter new first name");
                                string first = Console.ReadLine();
                                contact.firstName = first;
                                break;
                            case 2:
                                Console.WriteLine("\nEnter new last name");
                                string last = Console.ReadLine();
                                contact.lastName = last;
                                break;
                            case 3:
                                Console.WriteLine("\nEnter new address");
                                string address = Console.ReadLine();
                                contact.address = address;
                                break;
                            case 4:
                                Console.WriteLine("\nEnter new city");
                                string city = Console.ReadLine();
                                contact.city = city;
                                break;
                            case 5:
                                Console.WriteLine("\nEnter new state");
                                string state = Console.ReadLine();
                                contact.state = state;
                                break;
                            case 6:
                                Console.WriteLine("\nEnter new zip");
                                string zip = Console.ReadLine();
                                contact.zip = zip;
                                break;
                            case 7:
                                Console.WriteLine("\nEnter new phone number");
                                string phone = Console.ReadLine();
                                contact.phoneNumber = phone;
                                break;
                            case 8:
                                Console.WriteLine("\nEnter new email");
                                string email = Console.ReadLine();
                                contact.email = email;
                                break;
                            default:
                                Console.WriteLine("\nInvalid Choice.");
                                break;
                        }
                    }
                }
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter the name of the person to delete the contact");
            string person = Console.ReadLine();
            for (int i = 0; i < count; i++)
            {
                if (addressBooks[i] != null && addressBooks[i].firstName.Equals(person, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = i; j < count; j++)
                    {
                        addressBooks[j] = addressBooks[j + 1];
                    }
                    addressBooks[count - 1] = null;
                    break;
                }
            }
        }
        public void DisplayContacts()
        {
            foreach (AddressBook contact in addressBooks)
            {
                if (contact == null)
                {
                    continue;
                }
                Console.WriteLine("-----------------------------");
                Console.WriteLine(contact);
            }
        }
        public void SearchPersonByCityOrState() // UC-8 Ability to search person by city or state
        {
            Console.WriteLine("Enter City or State to search:");
            string location = Console.ReadLine();

            bool found = false;
            int countContacts = 0;  // UC-10 To count contacts in the specified city or state
            foreach (AddressBook contact in addressBooks)
            {
                if (contact != null && (contact.city.Equals(location, StringComparison.OrdinalIgnoreCase) || contact.state.Equals(location, StringComparison.OrdinalIgnoreCase))) // UC-9 Ability to view person by city or state
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine(contact);
                    found = true;
                    countContacts++; // UC-10 Ability to get count of contact persons by city or state
                }
            }
            if (!found)
            {
                Console.WriteLine("No contacts found in the specified city or state.");

            }
            Console.WriteLine($"\nTotal contacts found in {location}: {countContacts}"); // UC-10
        }
        public void SortEntriesByName() // UC-11 Ability to sort entries alphabetically by Person's name
        {
            Array.Sort(addressBooks, (x, y) =>
            {
                if (x == null && y == null) return 0;
                if (x == null) return 1;
                if (y == null) return -1;
                return string.Compare(x.firstName, y.firstName, StringComparison.OrdinalIgnoreCase);
            });
            Console.WriteLine("\nContacts sorted by name:");
        }
    }
}
