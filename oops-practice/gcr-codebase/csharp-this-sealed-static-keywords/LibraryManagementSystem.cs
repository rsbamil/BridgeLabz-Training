using System;
class Book
{
    static string LibraryName="ABC Library";
    string title;
    string author;
    readonly int ISBN;
    public Book(string title, string author, int ISBN)
    {
        this.title = title;
        this.author = author;
        this.ISBN = ISBN;
    }
    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library Name: " + LibraryName);
    }
    public void DisplayBookInfo()
    {
        Console.WriteLine("Title: " + title + ", Author: " + author + ", ISBN: " + ISBN);
    }
}
class LibraryManagementSystem
{
    static void Main()
    {
        Book b1=new Book("The Great Gatsby", "F. Scott Fitzgerald", 123456);
        Book b2=new Book("1984", "George Orwell", 654321);
        if(b1 is Book)
        {
            Console.WriteLine("b1 is an instance of Book");
            b1.DisplayBookInfo();
        }
        if(b2 is Book)
        {
            Console.WriteLine("b2 is an instance of Book");
            b2.DisplayBookInfo();
        }
        Book.DisplayLibraryName();
    }
}