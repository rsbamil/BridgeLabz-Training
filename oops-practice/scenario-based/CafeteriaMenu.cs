using System;
class CafeteriaMenu
{
    static int[] selectedItems = new int[10];
    static string[] foodItems = { "1. Pizza", "2. Burger", "3. Biryani", "4. Pasta", "5. Sandwich", "6. Dosa", "7. Noodles", "8. Fried Rice", "9. Ice Cream", "10. Cake" };
    static void Main()
    {
        CafeteriaMenu menu = new CafeteriaMenu();
        Console.WriteLine("\nWELCOME TO THE CANTEEN.");
        menu.DisplayMenu();
    }
    void DisplayMenu()
    {
        int choice;
        while (true)
        {
            Console.WriteLine("\nCHOOSE YOUR FOOD ITEMS BY ENTERING THE NUMBER:");
            Console.WriteLine("\nCHOOSE 11 TO EXIT.");
            Console.WriteLine("\nTODAY'S MENU:");
            foreach (string item in foodItems)
            {
                Console.WriteLine(item);
            }
            choice = int.Parse(Console.ReadLine());

            if (choice >= 1 && choice <= 10)
            {
                GetItemByIndex(choice - 1);

            }
            else if (choice == 11)
            {
                Console.WriteLine("EXITING...");
                Console.WriteLine("\nYOUR FINAL ORDER:");
                DisplayAllOrders();
                break;
            }
            else
            {
                Console.WriteLine("INVALID CHOICE. PLEASE TRY AGAIN.");
                continue;
            }
        }
    }
    void GetItemByIndex(int index)
    {
        selectedItems[index]++;
        Console.WriteLine("YOU SELECTED: " + foodItems[index]);
        DisplayAllOrders();
    }
    void DisplayAllOrders()
    {
        for (int i = 0; i < selectedItems.Length; i++)
        {
            if (selectedItems[i] > 0)
            {
                Console.WriteLine(foodItems[i] + " - Quantity: " + selectedItems[i]);
            }
        }
    }

}