using System;
class FizzBuzz2{
    static void Main(){
        int num=int.Parse(Console.ReadLine());
        int i=0;
        if(num>0){
            while(i<=num){
                if(i%3==0 && i%5==0){
                    Console.WriteLine("FizzBuzz");
                }
                else if(i%3==0){
                    Console.WriteLine("Fizz");
                }
                else if(i%5==0){
                    Console.WriteLine("Buzz");
                }
                else{
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}