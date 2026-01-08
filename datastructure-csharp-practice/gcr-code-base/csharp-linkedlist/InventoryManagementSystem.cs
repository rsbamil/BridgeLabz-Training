using System;

// Item node
class ItemNode
{
    public string Name;
    public int Quantity;
    public double Price;
    public ItemNode Next;

    public ItemNode(string name, int qty, double price)
    {
        Name = name;
        Quantity = qty;
        Price = price;
        Next = null;
    }
}

class Inventory
{
    private ItemNode head = null;

    // Add item at beginning
    public void AddItem(string name, int qty, double price)
    {
        ItemNode node = new ItemNode(name, qty, price);
        node.Next = head;
        head = node;
    }

    // Calculate total value
    public void CalculateTotal()
    {
        double total = 0;
        ItemNode temp = head;

        while (temp != null)
        {
            total += temp.Price * temp.Quantity;
            temp = temp.Next;
        }

        Console.WriteLine("Total Inventory Value = " + total);
    }
}

class InventoryManagementSystem
{
    static void Main()
    {
        Inventory inv = new Inventory();

        inv.AddItem("Mouse", 10, 500);
        inv.AddItem("Keyboard", 5, 1500);

        inv.CalculateTotal();
    }
}