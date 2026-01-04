using System;

// Superclass
public class Book
{
    public string Title;
    public int PublicationYear;

    public Book(string title, int year)
    {
        Title = title;
        PublicationYear = year;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Book Title: " + Title);
        Console.WriteLine("Publication Year: " + PublicationYear);
    }
}

// Subclass (Single Inheritance)
public class Author : Book
{
    public string Name;
    public string Bio;

    public Author(string title, int year, string name, string bio)
        : base(title, year)
    {
        Name = name;
        Bio = bio;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("\n--- Book & Author Details ---");
        base.DisplayInfo();
        Console.WriteLine("Author Name: " + Name);
        Console.WriteLine("Author Bio: " + Bio);
    }
}

class LibraryManagement
{
    static void Main()
    {
        Author a1 = new Author(
            "Atomic Habits",
            2018,
            "James Clear",
            "Self improvement writer"
        );

        a1.DisplayInfo();
    }
}
