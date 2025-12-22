using System;
class Counter{
    static void Main(){
        int counter=int.Parse(Console.ReadLine());
        while(counter>=1){
            Console.WriteLine("Counter: "+counter);
            counter--;
        }
    }
}