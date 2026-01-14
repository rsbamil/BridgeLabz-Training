using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBookUtility : IAddressbook
    {
        private AddressBook[] addressBooks = new AddressBook[10];
        private int count = 0;
        
        public void AddContact()  // UC-2 Method to Add Contact Details
        {
            if(count==addressBooks.Length)
            {
                Console.WriteLine("Address Book is full. Cannot add more contacts.");
                return;
            }
            AddressBook contact = new AddressBook();
            Console.Write("Enter First Name: ");
            contact.firstName=Console.ReadLine();
            Console.Write("Enter Last Name: ");
            contact.lastName=Console.ReadLine();
            Console.Write("Enter Address: ");
            contact.address=Console.ReadLine();
            Console.Write("Enter City: ");
            contact.city=Console.ReadLine();
            Console.Write("Enter State: ");
            contact.state=Console.ReadLine();
            Console.Write("Enter Zip: ");
            contact.zip=Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            contact.phoneNumber=Console.ReadLine();
            Console.Write("Enter Email: ");
            contact.email=Console.ReadLine();
            addressBooks[count++] = contact;
            Console.WriteLine("Contact added successfully.");
        }
    }
}
