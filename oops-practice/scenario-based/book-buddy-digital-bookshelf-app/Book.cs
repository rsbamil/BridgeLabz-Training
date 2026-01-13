using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBuddy
{
    internal class Book
    {
        private string Title;
        private string Author;
        
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public string GetTitle()
        {
            return Title;
        }
        public string GetAuthor()
        {
            return Author;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}";
        }
    }
}
