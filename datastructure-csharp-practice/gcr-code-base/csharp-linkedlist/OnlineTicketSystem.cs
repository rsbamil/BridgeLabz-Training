using System;

// Each node represents one ticket
class TicketNode
{
    public int TicketId;
    public string CustomerName;
    public TicketNode Next;

    public TicketNode(int id, string name)
    {
        TicketId = id;
        CustomerName = name;
        Next = null;
    }
}

// Ticket reservation system
class TicketSystem
{
    private TicketNode head = null;

    // Book ticket at the end
    public void BookTicket(int id, string name)
    {
        TicketNode node = new TicketNode(id, name);

        // If no ticket exists
        if (head == null)
        {
            head = node;
            node.Next = head; // circular link
            return;
        }

        // Go to last ticket
        TicketNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = node;
        node.Next = head;
    }

    // Display all booked tickets
    public void DisplayTickets()
    {
        if (head == null) return;

        TicketNode temp = head;
        do
        {
            Console.WriteLine("Ticket ID: " + temp.TicketId + ", Customer: " + temp.CustomerName);
            temp = temp.Next;
        }
        while (temp != head);
    }

    // Count total tickets
    public void CountTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked");
            return;
        }

        int count = 0;
        TicketNode temp = head;
        do
        {
            count++;
            temp = temp.Next;
        }
        while (temp != head);

        Console.WriteLine("Total Tickets Booked: " + count);
    }
}

// Main class
class OnlineTicketSystem
{
    static void Main()
    {
        TicketSystem system = new TicketSystem();

        system.BookTicket(101, "Arjun");
        system.BookTicket(102, "Ravi");
        system.BookTicket(103, "Neha");

        system.DisplayTickets();
        system.CountTickets();
    }
}