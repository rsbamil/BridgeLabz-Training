using System;
class Digits{
    static void Main(){
        int number=int.Parse(Console.ReadLine());
        int count=0;
        while(number>0){
            number/=10;
            count++;
        }
        Console.WriteLine("No. of digits: "+count);
    }
}