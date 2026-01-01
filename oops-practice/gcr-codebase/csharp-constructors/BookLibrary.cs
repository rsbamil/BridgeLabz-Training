using System;
class Book
{
    public int ISBN;
    protected string title;
    private string author;
    public Book(int ISBN, string title, string author)
    {
        this.ISBN = ISBN;
        this.title = title;
        this.author = author;
    }
    public void GetAuthor()
    {
        Console.WriteLine("Author: " + author);
    }
    public void SetAuthor(string author)
    {
        this.author = author;
    }
    public void Display()
    {
        Console.WriteLine("ISBN: " + ISBN + ", Title: " + title + ", Author: " + author);
    }
}
class Ebook : Book
{
    public Ebook(int ISBN, string title, string author) : base(ISBN, title, author)
    {

    }
    public void DisplayEBook()
    {
        // Accessing public and protected members
        Console.WriteLine("ISBN (Public): " + ISBN);
        Console.WriteLine("Title (Protected): " + title);
    }
}
class BookLibrary
{
    static void Main()
    {
        Book book1 = new Book(12345, "1984", "George Orwell");
        book1.Display();
        book1.GetAuthor();
        book1.SetAuthor("Orwell G.");
        book1.Display();
        book1.GetAuthor();

        Ebook ebook1 = new Ebook(67890, "Brave New World", "Aldous Huxley");
        ebook1.DisplayEBook();
        ebook1.GetAuthor();
    }
}