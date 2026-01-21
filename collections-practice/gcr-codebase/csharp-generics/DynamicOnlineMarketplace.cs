using System;
using System.Collections.Generic;
class BookCategory { }
class ClothingCategory { }
class Product<T> where T : class
{
    public string Name;
    public double Price;
    public T Category;
    public Product(string name, double price, T category)
    {
        Name = name;
        Price = price;
        Category = category;
    }
}
class Discount
{
    public static void ApplyDiscount<T>(T product, double percentage) where T : Product<object>
    {
        product.Price -= product.Price * (percentage / 100);
    }
}
class DynamicOnlineMarketPlace
{
    static void Main()
    {
        Product<BookCategory> book = new Product<BookCategory>("C#", 150.0, new BookCategory());
        Product<ClothingCategory> shirt = new Product<ClothingCategory>("Levi's", 80.0, new ClothingCategory());
        System.Console.WriteLine("Book Name :" + book.Name + ", Book Price :" + book.Price);
        System.Console.WriteLine("Shirt Name :" + shirt.Name + ", Shirt Price :" + shirt.Price);
    }
}