using System;
public class Book
{
    string title="The Great Gatsby";
    string author="F. Scott Fitzgerald";
    int price=400;
    public void Display()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }

}
class BookDetails
{
    static void Main()
    {
        Book b=new Book();
        b.Display();
    }
}