using System;
class Factorial{
    static void Main(){
        int num=int.Parse(Console.ReadLine());
        int fact=1;
        while(num>=1){
            fact*=num;
            num--;
        }
        Console.WriteLine("Factorial: "+fact);
    }
}