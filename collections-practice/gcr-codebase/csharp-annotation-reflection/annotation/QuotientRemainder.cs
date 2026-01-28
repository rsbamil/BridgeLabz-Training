using System;
class QuotientRemainder{
    static void Main(){
        int num1=Convert.ToInt32(Console.ReadLine());
        int num2=Convert.ToInt32(Console.ReadLine());
        int quotient=num1/num2;
        int remainder=num1%num2;
        Console.WriteLine("The Quotient is "+quotient+" and Remainder is "+remainder+" of two numbers "+num1+" and "+num2);
    }
}