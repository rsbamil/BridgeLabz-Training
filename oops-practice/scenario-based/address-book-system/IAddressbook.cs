using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal interface IAddressbook
    {
        void AddContact(); // UC-2 Method to Add Contact Details
        void EditContact(); // UC-3 Method to Edit Contact Details
        void DeleteContact(); // UC-4 Method to Delete Contact Details
        void SearchPersonByCityOrState(); // UC-8 Ability to search person by city or state
        void DisplayContacts();
        
    }
}
