using System;
class Factorial2{
    static void Main(){
        int num=int.Parse(Console.ReadLine());
        int fact=1;
        for(int i=num;i>=1;i--){
            fact*=i;
        }
        Console.WriteLine("Factorial: "+fact);
    }
}