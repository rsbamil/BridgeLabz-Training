using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBuddy
{
    internal interface IBook
    {
        void AddBook(string title, string author);
        void SortBooksAlphabetically();
        void SearchByAuthor(string author);
        void DisplayAllBooks();
    }
}
