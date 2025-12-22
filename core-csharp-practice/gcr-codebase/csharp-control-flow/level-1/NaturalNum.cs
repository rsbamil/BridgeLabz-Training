using System;
class NaturalNum{
    static void Main(){
        int num=int.Parse(Console.ReadLine());
        if(num>0){
            Console.WriteLine("The sum of "+num+" natural numbers is "+(num*(num+1)/2));
        }
        else{
            Console.WriteLine("The number "+num+" is not a natural number");
        }
    }
}