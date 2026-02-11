namespace AddressBook
{
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {
            // Connection string for the database
            string connString ="Server=localhost\\SQLEXPRESS;Database=AddressBookDB;Trusted_Connection=True;TrustServerCertificate=True";

            IDataSource dbSource = new DatabaseDataSource(connString);  // Create an instance of the database data source

            AddressBookUtility utility = new AddressBookUtility(dbSource);  // Pass the database data source to the utility class

            AddressBookMenu menu = new AddressBookMenu(utility);  // Pass the utility class to the menu
            menu.ShowMenu();
        }
    }
}
