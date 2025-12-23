using System;
class Youngest{
    static void Main(){
        int amarAge=int.Parse(Console.ReadLine());
        int akbarAge=int.Parse(Console.ReadLine());
        int anthonyAge=int.Parse(Console.ReadLine());
        int amarHeight=int.Parse(Console.ReadLine());
        int akbarHeight=int.Parse(Console.ReadLine());
        int anthonyHeight=int.Parse(Console.ReadLine());
        if(amarAge<akbarAge && amarAge<anthonyAge){
            Console.WriteLine("Amar");
        }
        else if(akbarAge<amarAge && akbarAge<anthonyAge){
            Console.WriteLine("Akbar");
        }
        else{
            Console.WriteLine("Anthony");
        }
        if(amarHeight<akbarHeight && amarHeight<anthonyHeight){
            Console.WriteLine("Amar");
        }
        else if(akbarHeight<amarHeight && akbarHeight<anthonyHeight){
            Console.WriteLine("Akbar");
        }
        else{
            Console.WriteLine("Anthony");
        }
    }
}