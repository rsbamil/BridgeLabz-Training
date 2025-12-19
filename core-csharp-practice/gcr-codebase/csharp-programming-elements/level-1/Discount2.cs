using System;
class Discount2{
    static void Main(){
        int fee=Convert.ToInt32(Console.ReadLine());
        int discountPercent =Convert.ToInt32(Console.ReadLine());
        int discount =(fee*discountPercent)/100;
        int finalFee=fee-discount;
        Console.WriteLine("The discount amount is INR "+ discount +" and final discounted fee is INR "+finalFee);
    }
}