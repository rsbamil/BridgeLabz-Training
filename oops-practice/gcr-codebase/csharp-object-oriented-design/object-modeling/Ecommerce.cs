using System;

public class Product
{
    public string Name;
    public double Price;

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public void Display()
    {
        Console.WriteLine("      Product: " + Name + " | Price: ₹" + Price);
    }
}

public class Order
{
    public int OrderId;
    public Product[] Products;
    int pCount = 0;

    public Order(int id, int size)
    {
        OrderId = id;
        Products = new Product[size];   // Aggregation (Order HAS Products)
    }

    public void AddProduct(Product p)
    {
        Products[pCount++] = p;
    }

    public void ShowOrder()
    {
        Console.WriteLine("\n   Order ID: " + OrderId);
        for (int i = 0; i < pCount; i++)
        {
            Products[i].Display();
        }
    }
}

public class Customer
{
    public string Name;
    public Order[] Orders = new Order[5];
    int oCount = 0;

    public Customer(string name)
    {
        Name = name;
    }

    // Communication between Customer & Order
    public void PlaceOrder(Order o)
    {
        Orders[oCount++] = o;
        Console.WriteLine(Name + " placed Order ID " + o.OrderId);
    }

    public void ShowOrders()
    {
        Console.WriteLine("\nCustomer: " + Name + " Orders:");
        for (int i = 0; i < oCount; i++)
        {
            Orders[i].ShowOrder();
        }
    }
}

class Ecommerce
{
    static void Main()
    {
        Product p1 = new Product("Mobile", 15000);
        Product p2 = new Product("Headphones", 2000);
        Product p3 = new Product("Power Bank", 1200);

        Customer c1 = new Customer("Rohit");

        Order o1 = new Order(101, 5);
        o1.AddProduct(p1);
        o1.AddProduct(p2);

        Order o2 = new Order(102, 5);
        o2.AddProduct(p3);

        c1.PlaceOrder(o1);
        c1.PlaceOrder(o2);

        c1.ShowOrders();
    }
}
