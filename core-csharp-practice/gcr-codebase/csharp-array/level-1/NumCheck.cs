using System;
class NumCheck{
    static void Main(){
        int [] numbers=new int[5];
        for(int i=0;i<numbers.Length;i++){
            numbers[i]=int.Parse(Console.ReadLine());
        }
        for(int i=0;i<numbers.Length;i++){
            if(numbers[i]>0){
                if(numbers[i]%2==0){
                    Console.WriteLine("The number "+numbers[i]+" is a positive even number.");
                }
                else{
                    Console.WriteLine("The number "+numbers[i]+" is a positive odd number.");
                }
            }
            else if(numbers[i]<0){
                Console.WriteLine("Negative number.");
            }
            else{
                Console.WriteLine("The number is zero.");
            }
        }
        if(numbers[0]==numbers[numbers.Length-1]){
            Console.WriteLine("The first and last numbers are equal.");
        }
        else if(numbers[0]>numbers[numbers.Length-1]){
            Console.WriteLine("The first number is greater than the last number.");
        }
        else{
            Console.WriteLine("The first number is smaller than the last number.");
        }
    }
}