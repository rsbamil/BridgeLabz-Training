using System;
class PrimeNum{
    static void Main(){
        int num=int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (num <= 1){
            isPrime = false;
        }
        else{
            for (int i = 2; i * i <= num; i++){
                if (num % i == 0){
                    isPrime = false;
                    break;
                }
            }
        }
        if(isPrime){
            Console.WriteLine(isPrime);
        }
        else{
            Console.WriteLine(isPrime);
        }
    }
}