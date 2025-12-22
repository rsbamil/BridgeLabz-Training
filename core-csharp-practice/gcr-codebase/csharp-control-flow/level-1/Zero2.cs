using System;
class Zero2{
    static void Main(){
        double total=0.0;
        double value=double.Parse(Console.ReadLine());
        while(value!=0 || value>=1){
            total+=value;
            value=double.Parse(Console.ReadLine());
            if(value<0){
                break;
            }
        }
        Console.WriteLine("Total: "+total);
    }
}