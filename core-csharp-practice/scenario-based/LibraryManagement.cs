using System;
class LibraryManagement
{
    string[,] issueHistory = new string[0,3];
    static void Main()
    {
        LibraryManagement lm = new LibraryManagement();
        string[,] books = lm.Input();
        Console.WriteLine("\nLOGIN AS:");
        Console.WriteLine("1. LIBRARIAN");
        Console.WriteLine("2. STUDENT");
        // Read user role
        int role = int.Parse(Console.ReadLine());

        if (role == 1)
            lm.LibrarianMenu(books);
        else if (role == 2)
            lm.StudentMenu(books);
        else
            Console.WriteLine("INVALID ROLE");
    }
    void LibrarianMenu(string[,] books)
    {
        Console.WriteLine("\nMENU:");
        Console.WriteLine("1. SEARCH FOR A BOOK");
        Console.WriteLine("2. DISPLAY ALL BOOKS");
        Console.WriteLine("3. UPDATE BOOK STATUS");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Searching(books);
                break;
            case 2:
                Display(books);
                break;
            case 3:
                UpdatingBookStatus(books);
                break;
            default:
                Console.WriteLine("INVALID CHOICE");
                break;
        }
    }
    void StudentMenu(string[,] books)
    {
        Console.WriteLine("\nMENU:");
        Console.WriteLine("1. SEARCH FOR A BOOK");
        Console.WriteLine("2. DISPLAY ALL BOOKS");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Searching(books);
                break;
            case 2:
                Display(books);
                break;
            default:
                Console.WriteLine("INVALID CHOICE");
                break;
        }
    }
    string[,] Input()
    {
        // Read the total number of books
        Console.WriteLine("ENTER THE NUMBER OF BOOKS:");
        int totalBooks = int.Parse(Console.ReadLine());
        string[,] books = new string[totalBooks, 3];
        // Read book details
        for (int i = 0; i < totalBooks; i++)
        {
            Console.WriteLine("ENTER THE DETAILS OF BOOK {0}:", i + 1);
            Console.Write("ENTER THE NAME OF THE BOOK: ");
            books[i, 0] = Console.ReadLine();
            Console.Write("ENTER THE AUTHOR OF THE BOOK: ");
            books[i, 1] = Console.ReadLine();
            Console.Write("ENTER THE STATUS OF THE BOOK: ");
            books[i, 2] = Console.ReadLine();
        }
        return books;
    }
    void Searching(string[,] books)
    {
        // Search for a book by title
        Console.WriteLine("\nENTER THE TITLE TO BE SEARCHED:");
        // Read the title to be searched
        string searchTitle = Console.ReadLine();
        bool found = false;
        for (int i = 0; i < books.GetLength(0); i++)
        {
            // Check if the book title matches the search title (case-insensitive)
            if (books[i, 0].IndexOf(searchTitle, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine("\nBOOK FOUND:");
                Console.WriteLine("NAME: {0}, AUTHOR: {1}, STATUS: {2}", books[i, 0], books[i, 1], books[i, 2]);
                found = true;
                break;
            }
        }
        // If no book is found, display message
        if (!found)
        {
            Console.WriteLine("BOOK NOT FOUND");
        }
    }
    void Display(string[,] books)
    {
        // Display all book details
        Console.WriteLine("\nDETAILS OF ALL BOOKS:");
        for (int i = 0; i < books.GetLength(0); i++)
        {
            Console.WriteLine("BOOK {0}: NAME: {1}, AUTHOR: {2}, STATUS: {3}", i + 1, books[i, 0], books[i, 1], books[i, 2]);
        }
    }
    void UpdatingBookStatus(string[,] books)
    {
        // Update the status of a book
        Console.WriteLine("\nENTER THE TITLE OF THE BOOK TO UPDATE STATUS:");
        string updateTitle = Console.ReadLine();
        bool found = false;
        for (int i = 0; i < books.GetLength(0); i++)
        {
            // Check if the book title matches the update title (case-insensitive)
            if (books[i, 0].Equals(updateTitle, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("CURRENT STATUS: {0}", books[i, 2]);
                Console.Write("ENTER THE NEW STATUS (Checked Out / Available): ");
                books[i, 2] = Console.ReadLine();
                Console.WriteLine("STATUS UPDATED SUCCESSFULLY");
                found = true;
                break;
            }
        }
        // If no book is found, display message
        if (!found)
        {
            Console.WriteLine("BOOK NOT FOUND");
        }
    }
}