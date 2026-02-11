using System.Collections.Generic;

namespace AddressBook
{
    public interface IDataSource
    {
        void Save(List<AddressBook> contacts);
        List<AddressBook> Load();
    }
}
