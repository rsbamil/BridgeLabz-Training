using System;

// Interface for reservation behavior
interface IReservable
{
    void ReserveItem(string name);
    bool CheckAvailability();
}

// Abstract Base Class
abstract class LibraryItem
{
    public int itemId;
    protected string title;
    protected string author;

    private string borrowerName;     // secured personal data
    private bool isAvailable = true;

    public LibraryItem(int id, string t, string a)
    {
        itemId = id;
        title = t;
        author = a;
    }

    public string GetItemDetails()
    {
        return "ID: " + itemId + ", Title: " + title + ", Author: " + author;
    }

    public void IssueItem(string name)
    {
        if (isAvailable)
        {
            borrowerName = name;
            isAvailable = false;
            Console.WriteLine("Item Issued to: " + name);
        }
        else
        {
            Console.WriteLine("Item not available");
        }
    }

    public void ReturnItem()
    {
        borrowerName = null;
        isAvailable = true;
        Console.WriteLine("Item Returned");
    }

    protected bool GetAvailabilityStatus()
    {
        return isAvailable;
    }

    public abstract int GetLoanDuration();
}

// Book Subclass
class Book : LibraryItem, IReservable
{
    public Book(int id, string t, string a) : base(id, t, a) { }

    public override int GetLoanDuration()
    {
        return 14;   // 14 days
    }

    public void ReserveItem(string name)
    {
        Console.WriteLine("Book Reserved by: " + name);
    }

    public bool CheckAvailability()
    {
        return GetAvailabilityStatus();
    }
}

// Magazine Subclass
class Magazine : LibraryItem, IReservable
{
    public Magazine(int id, string t, string a) : base(id, t, a) { }

    public override int GetLoanDuration()
    {
        return 7;   // 7 days
    }

    public void ReserveItem(string name)
    {
        Console.WriteLine("Magazine Reserved by: " + name);
    }

    public bool CheckAvailability()
    {
        return GetAvailabilityStatus();
    }
}

// DVD Subclass
class DVD : LibraryItem, IReservable
{
    public DVD(int id, string t, string a) : base(id, t, a) { }

    public override int GetLoanDuration()
    {
        return 5;   // 5 days
    }

    public void ReserveItem(string name)
    {
        Console.WriteLine("DVD Reserved by: " + name);
    }

    public bool CheckAvailability()
    {
        return GetAvailabilityStatus();
    }
}

// Polymorphism Demonstration
class LibraryManagementSystem
{
    static void ManageItem(LibraryItem item)
    {
        Console.WriteLine("\n" + item.GetItemDetails());
        Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");
    }

    static void Main()
    {
        LibraryItem[] items = new LibraryItem[3];

        items[0] = new Book(1, "C# Programming", "Rohit");
        items[1] = new Magazine(2, "Tech Monthly", "Amit");
        items[2] = new DVD(3, "Inception", "Nolan");

        foreach (LibraryItem item in items)
        {
            ManageItem(item);   // polymorphic call
        }

        Console.WriteLine("\nTesting Transactions:");

        items[0].IssueItem("Raj");
        items[0].ReturnItem();

        IReservable r = items[1] as IReservable;

        if (r.CheckAvailability())
            r.ReserveItem("Ravi");
    }
}
