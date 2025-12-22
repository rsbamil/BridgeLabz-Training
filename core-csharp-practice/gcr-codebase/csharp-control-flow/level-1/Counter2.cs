using System;
class Counter2{
    static void Main(){
        int counter=int.Parse(Console.ReadLine());
        for(int i=counter;i>=1;i--){
            Console.WriteLine("Counter: "+i);
        }
    }
}