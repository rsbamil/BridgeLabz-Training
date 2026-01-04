using System;

public class Book
{
    public string Title;
    public string Author;

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void Display()
    {
        Console.WriteLine("Book: " + Title + " | Author: " + Author);
    }
}

public class Library
{
    public string LibraryName;
    public Book[] Books;   // Aggregation using array
    int count = 0;

    public Library(string name, int size)
    {
        LibraryName = name;
        Books = new Book[size];
    }

    public void AddBook(Book b)
    {
        if (count < Books.Length)
        {
            Books[count] = b;
            count++;
        }
        else
        {
            Console.WriteLine("Library is full!");
        }
    }

    public void ShowBooks()
    {
        Console.WriteLine("\n" + LibraryName + " Library Books:");
        for (int i = 0; i < count; i++)
        {
            Books[i].Display();
        }
    }
}

class LibraryBooks
{
    static void Main()
    {
        Book b1 = new Book("Atomic Habits", "James Clear");
        Book b2 = new Book("Rich Dad Poor Dad", "Robert Kiyosaki");
        Book b3 = new Book("Think and Grow Rich", "Napoleon Hill");

        Library lib1 = new Library("City", 5);
        Library lib2 = new Library("College", 5);

        lib1.AddBook(b1);
        lib1.AddBook(b2);

        lib2.AddBook(b2);   // Same book shared → Aggregation
        lib2.AddBook(b3);

        lib1.ShowBooks();
        lib2.ShowBooks();
    }
}
