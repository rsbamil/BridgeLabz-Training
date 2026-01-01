using System;
class Book
{
    string title;
    string author;
    int price;
    string availability;
    public Book(string title, string author, int price, string availability)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.availability = availability;
    }
    public void BorrowBook()
    {
        if (availability == "Available")
        {
            Console.WriteLine("You have successfully borrowed the book: " + title);
            availability = "Not Available";
        }
        else
        {
            Console.WriteLine("Sorry, the book: " + title + " is currently not available.");
        }
    }
}
class LibrarySystem
{
    static void Main()
    {
        Book b1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 10, "Available");
        b1.BorrowBook();
    }
}