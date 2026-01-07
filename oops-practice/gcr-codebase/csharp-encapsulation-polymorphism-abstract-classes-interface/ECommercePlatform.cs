using System;
interface ITaxable
{
    int CalculateTax();
    void GetTaxDetails();
}
abstract class Product
{
    int productId;
    string productName;
    int price;
    public int ProductId
    {
        get { return productId; }
        set { productId = value; }
    }
    public string ProductName
    {
        get { return productName; }
        set { productName = value; }
    }
    public int Price
    {
        get { return price; }
        set { price = value; }
    }
    abstract public double CalculateDiscount();
    public void DisplayDetails()
    {
        Console.WriteLine("Product ID: " + productId);
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Discounted Price: " + (price - CalculateDiscount()));
    }
}
class Electronics : Product, ITaxable
{
    public Electronics(int productId, string productName, int price)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
    }
    public override double CalculateDiscount()
    {
        return Price * 0.1; // 10% discount for electronics
    }
    public int CalculateTax()
    {
        return (int)(Price * 0.15); // 15% tax for electronics
    }
    public void GetTaxDetails()
    {
        Console.WriteLine("Tax for " + ProductName + " is: " + CalculateTax());
    }
}
class Clothing : Product, ITaxable
{
    public Clothing(int productId, string productName, int price)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
    }
    public override double CalculateDiscount()
    {
        return Price * 0.1; // 10% discount for electronics
    }
    public int CalculateTax()
    {
        return (int)(Price * 0.05); // 5% tax for electronics
    }
    public void GetTaxDetails()
    {
        Console.WriteLine("Tax for " + ProductName + " is: " + CalculateTax());
    }
}
class Groceries : Product, ITaxable
{
    public Groceries(int productId, string productName, int price)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
    }
    public override double CalculateDiscount()
    {
        return Price * 0.1; // 10% discount for electronics
    }
    public int CalculateTax()
    {
        return (int)(Price * 0.20); // 20% tax for electronics
    }
    public void GetTaxDetails()
    {
        Console.WriteLine("Tax for " + ProductName + " is: " + CalculateTax());
    }
}
class ECommercePlatform
{
    static void Main()
    {
        ITaxable[] products = new ITaxable[3];
        products[0] = new Electronics(101, "Smartphone", 50000);
        products[1] = new Clothing(102, "Jeans", 2000);
        products[2] = new Groceries(103, "Rice", 1500);

        foreach (var product in products)
        {
            Product p = (Product)product;
            p.DisplayDetails();
            product.GetTaxDetails();
            Console.WriteLine();
        }
    }
}