using System;

// Book node
class BookNode
{
    public string Title;
    public BookNode Prev;
    public BookNode Next;

    public BookNode(string title)
    {
        Title = title;
    }
}

class Library
{
    private BookNode head = null;

    // Add book at beginning
    public void AddBook(string title)
    {
        BookNode node = new BookNode(title);
        node.Next = head;

        if (head != null)
            head.Prev = node;

        head = node;
    }

    // Display books
    public void DisplayBooks()
    {
        BookNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.Title);
            temp = temp.Next;
        }
    }
}

class LibraryManagementSystem
{
    static void Main()
    {
        Library lib = new Library();

        lib.AddBook("C# Basics");
        lib.AddBook("Data Structures");

        lib.DisplayBooks();
    }
}