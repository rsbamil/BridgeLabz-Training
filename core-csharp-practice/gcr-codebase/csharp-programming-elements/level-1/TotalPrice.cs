using System;
class TotalPrice{
    static void Main(){
        double unitPrice=Convert.ToDouble(Console.ReadLine());
        int quantity=Convert.ToInt32(Console.ReadLine());
        double totalPrice=unitPrice*quantity;
        Console.WriteLine("The total purchase price is INR "+totalPrice+" if the quantity "+quantity+" and unit price is INR "+unitPrice);
    }
}