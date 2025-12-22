using System;
class Zero{
    static void Main(){
        double total=0.0;
        double value=double.Parse(Console.ReadLine());
        while(value!=0){
            total+=value;
            value=double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Total: "+total);
    }
}