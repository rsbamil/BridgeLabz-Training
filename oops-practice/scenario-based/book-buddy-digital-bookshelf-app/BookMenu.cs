using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBuddy
{
    internal class BookMenu
    {
        private IBook shelf;
        public BookMenu(IBook shelf)
        {
            this.shelf = shelf;
        }
        public void ShowMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n====== BOOK BUDDY MENU ======");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Display All Books");
                Console.WriteLine("3. Sort Books Alphabetically");
                Console.WriteLine("4. Search by Author");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Book Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Book Author: ");
                        string author = Console.ReadLine();
                        shelf.AddBook(title, author);
                        break;
                    case 2:
                        shelf.DisplayAllBooks();
                        break;
                    case 3:
                        shelf.SortBooksAlphabetically();
                        break;
                    case 4:
                        Console.Write("Enter Author Name to Search: ");
                        string searchAuthor = Console.ReadLine();
                        shelf.SearchByAuthor(searchAuthor);
                        break;
                    case 5:
                        Console.WriteLine("Exiting Book Buddy. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            while (choice != 5);
        }
    }
}
