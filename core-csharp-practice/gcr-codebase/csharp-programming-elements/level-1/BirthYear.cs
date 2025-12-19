using System;
class BirthYear{
    static void Main(){
        int year=Convert.ToInt32(Console.ReadLine());
        if(year<2024){
            int age=2024-year;
        Console.WriteLine("Harry's age in 2024 is "+age);
        }
        else{
            Console.WriteLine("Invalid Birth Year");
        }
    }
}