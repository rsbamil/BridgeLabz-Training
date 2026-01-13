namespace BookBuddy
{
    internal class BookBuddyMain
    {
        static void Main(string[] args)
        {
            IBook shelf = new BookBuddyUtilityImpl();
            BookMenu menu=new BookMenu(shelf);
            menu.ShowMenu();
        }
    }
}
