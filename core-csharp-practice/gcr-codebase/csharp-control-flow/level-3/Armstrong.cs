using System;
class Armstrong{
    static void Main(){
        int number=int.Parse(Console.ReadLine());
        int sum=0;
        int original=number;
        while(number>0){
            int digit=number%10;
            sum+=digit*digit*digit;
            number/=10;
        }
        if(sum==original){
            Console.WriteLine("Armstrong Number");
        }
        else{
            Console.WriteLine("Not an Armstrong Number");
        }
    }
}