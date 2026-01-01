using System;
class Product
{
    string productName;
    int price;
    static int totalProducts;
    public Product(string productName, int price)
    {
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }
    public void DisplayProductDetails()
    {
        Console.WriteLine("Product Name: " + productName + ", Price: $" + price);
    }
    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products: " + totalProducts);
    }
}
class ProductInventory
{
    static void Main()
    {
        Product p1 = new Product("Laptop", 800);
        Product p2 = new Product("Smartphone", 500);
        p1.DisplayProductDetails();
        p2.DisplayProductDetails();
        Product.DisplayTotalProducts();
    }
}