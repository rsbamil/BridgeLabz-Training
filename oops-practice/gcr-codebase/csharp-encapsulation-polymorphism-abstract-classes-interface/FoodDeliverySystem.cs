using System;

// Discount Interface
interface IDiscountable
{
    double ApplyDiscount();
    string GetDiscountDetails();
}

// Abstract Base Class
abstract class FoodItem
{
    public string itemName;
    protected double price;
    protected int quantity;

    public FoodItem(string name, double p, int q)
    {
        itemName = name;
        price = p;
        quantity = q;
    }

    public string GetItemDetails()
    {
        return "Item: " + itemName + ", Price: " + price + ", Quantity: " + quantity;
    }

    public abstract double CalculateTotalPrice();
}

// Veg Item Class
class VegItem : FoodItem, IDiscountable
{
    public VegItem(string name, double p, int q) : base(name, p, q) { }

    public override double CalculateTotalPrice()
    {
        return price * quantity;   // no extra charge
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.10;  // 10% discount
    }

    public string GetDiscountDetails()
    {
        return "Veg Item Discount: 10%";
    }
}

// Non-Veg Item Class
class NonVegItem : FoodItem, IDiscountable
{
    public NonVegItem(string name, double p, int q) : base(name, p, q) { }

    public override double CalculateTotalPrice()
    {
        double extraCharge = 50;        // fixed delivery charge
        return (price * quantity) + extraCharge;
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.05;  // 5% discount
    }

    public string GetDiscountDetails()
    {
        return "Non-Veg Item Discount: 5%";
    }
}

// Polymorphism Demonstration
class FoodDeliverySystem
{
    static void ProcessFood(FoodItem item)
    {
        Console.WriteLine("\n" + item.GetItemDetails());

        double total = item.CalculateTotalPrice();
        Console.WriteLine("Total Price: " + total);

        IDiscountable d = item as IDiscountable;
        Console.WriteLine(d.GetDiscountDetails());
        Console.WriteLine("Discount Amount: " + d.ApplyDiscount());
    }

    static void Main()
    {
        FoodItem[] order = new FoodItem[2];

        order[0] = new VegItem("Paneer Burger", 120, 2);
        order[1] = new NonVegItem("Chicken Roll", 150, 3);

        Console.WriteLine("Processing Food Items Dynamically:");

        foreach (FoodItem item in order)
        {
            ProcessFood(item);   // polymorphic call
        }
    }
}
