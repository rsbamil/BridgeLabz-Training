using System;
class Chocolates{
    static void Main(){
        int numberOfChocolates =Convert.ToInt32(Console.ReadLine());
        int numberOfChildren =Convert.ToInt32(Console.ReadLine());
        int chocoPerChild=numberOfChocolates/numberOfChildren;
        int chocoLeft=numberOfChocolates%numberOfChildren;
        Console.WriteLine("The number of chocolates each child gets is "+chocoPerChild+" and the number of remaining chocolates is "+chocoLeft);
    }
}