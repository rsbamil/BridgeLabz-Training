using System;
class Book
{
    string title;
    string author;
    int price;
    public Book()
    {
        Console.WriteLine("Book is created Called by Default Constructor");

    }
    // parameterized constructor 
    public Book(string title, string author, int price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }
    public void Display()
    {
        Console.WriteLine("TITLE :" + title + "\nAUTHOR :" + author + "\nPRICE :" + price);
    }
}
class Books
{
    static void Main()
    {
        Book b1 = new Book();
        Book b2 = new Book("C#", "Rahul", 50);
        b2.Display();
    }
}