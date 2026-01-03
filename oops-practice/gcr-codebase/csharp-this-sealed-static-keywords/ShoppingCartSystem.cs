using System;
class Product
{
    static int discount = 10;
    string productName;
    int price;
    int quantity;
    public Product(string productName, int price, int quantity)
    {
        this.productName = productName;
        this.price = price;
        this.quantity = quantity;
    }
    public static void UpdateDiscount(int newDiscount)
    {
        discount = newDiscount;
    }
    public void DisplayProductInfo()
    {
        Console.WriteLine("Product Name: " + productName + ", Price: " + price + ", Quantity: " + quantity + ", Discount: " + discount + "%");
    }
}
class ShoppingCartSystem
{
    static void Main()
    {
        Product p1 = new Product("Laptop", 1000, 2);
        Product p2 = new Product("Smartphone", 500, 5);
        if (p1 is Product)
        {
            Console.WriteLine("p1 is an instance of Product");
            p1.DisplayProductInfo();
        }
        if (p2 is Product)
        {
            Console.WriteLine("p2 is an instance of Product");
            p2.DisplayProductInfo();
        }
        Product.UpdateDiscount(15);
        Console.WriteLine("After updating discount:");
        p1.DisplayProductInfo();
        p2.DisplayProductInfo();
    }
}