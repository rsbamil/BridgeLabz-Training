using System;
class LargestNum{
    static void Main(){
        int num1=int.Parse(Console.ReadLine());
        int num2=int.Parse(Console.ReadLine());
        int num3=int.Parse(Console.ReadLine());
        Console.WriteLine("Is the first number the largest? "+(num1>num2 && num1>num3));
        Console.WriteLine("Is the second number the largest? "+(num2>num1 && num2>num3));
        Console.WriteLine("Is the third number the largest? "+(num3>num1 && num3>num2));
    }
}