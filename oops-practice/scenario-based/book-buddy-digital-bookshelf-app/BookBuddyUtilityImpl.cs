using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBuddy
{
    internal class BookBuddyUtilityImpl : IBook
    {
        private Book[] Books=new Book[10];
        private int count = 0;
        public void AddBook(string title, string author)
        {
            if(count==Books.Length)
            {
                Console.WriteLine("Book list is full");
                return;
            }
            Books[count++] = new Book(title, author);
            Console.WriteLine("Book added successfully");
        }

        public void SearchByAuthor(string author)
        {
            bool found = false;
            for(int i = 0; i < count; i++)
            {
                string bookAuthor = Books[i].GetAuthor();
                if (bookAuthor.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(Books[i]);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No Books Found For This Author");
            }
        }
        public void DisplayAllBooks()
        {
            if (count == 0)
            {
                Console.WriteLine("No Books Available");
                return;
            }
            Console.WriteLine("----------All Books------------");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(Books[i]);
            }
        }
        public void SortBooksAlphabetically()
        {
            for(int i = 0; i < count-1; i++)
            {
                for(int j = i + 1; j < count; j++)
                {
                    if (string.Compare(Books[i].GetTitle(), Books[j].GetTitle(), StringComparison.OrdinalIgnoreCase)
                        > 0) {
                        Book temp = Books[i];
                        Books[i] = Books[j];
                        Books[j] = temp;
                    }
                }
            }
            Console.WriteLine("Books Sorted Successfully");
        }
    }
}
