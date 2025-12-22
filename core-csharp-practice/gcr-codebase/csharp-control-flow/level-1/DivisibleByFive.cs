using System;
class DivisibleByFive{
    static void Main(){
        int number=int.Parse(Console.ReadLine());
        Console.WriteLine("Is the number "+number+" divisible by 5? "+(number%5==0));
        }
    }
