using System;
interface IMenu
{
    void DisplayMenu();
    string GetItemByIndex(int index);
}
class MenuBaseImpl : IMenu
{
    string[] items;

    public MenuBaseImpl()
    {
        items = new string[10]
        {
            "1. Veg Sandwich",
            "2. Chicken Burger",
            "3. French Fries",
            "4. Pasta",
            "5.Pizza",
            "6. Idli",
            "7. Dosa",
            "8. Fried Rice",
            "9. Noodles",
            "10. Coffee"
        };
    }
    public void DisplayMenu()
    {
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i] + " ");
        }
    }
    public string GetItemByIndex(int index)
    {
        if (index >= 0 && index < items.Length)
        {
            return items[index];
        }
        return "Invalid Choice";
    }
}
class CafeteriaMenu : MenuBaseImpl
{
    string[] orders = new string[10];
    int orderCount = 0;
    public void Order()
    {
        while (true)
        {
            Console.Write("\nENTER ITEM NUMBER : ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 0)
                break;

            string item = GetItemByIndex(choice - 1);

            if (item != null && orderCount < orders.Length)
            {
                orders[orderCount] = item;
                orderCount++;
                Console.WriteLine(item + " added to order.");
            }
            else
            {
                Console.WriteLine("Invalid choice or order limit reached.");
            }
        }
    }
    public void DisplayOrders()
    {
        Console.WriteLine("YOUR ORDERS");

        if (orderCount == 0)
        {
            Console.WriteLine("No items ordered.");
            return;
        }

        for (int i = 0; i < orderCount; i++)
        {
            Console.WriteLine((i + 1) + ". " + orders[i]);
        }
    }
}
class Cafeteria
{
    static void Main()
    {
        CafeteriaMenu menu = new CafeteriaMenu();
        menu.DisplayMenu();
        menu.Order();
        menu.DisplayOrders();
    }
}

