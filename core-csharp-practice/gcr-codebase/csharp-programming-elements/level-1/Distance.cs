using System;
class Distance{
    static void Main(){
        double distInFeet=Convert.ToDouble(Console.ReadLine());
        double distInYards=distInFeet/3;
        double distInMiles=distInFeet/5280;
        Console.WriteLine("Distance in yards "+distInYards+" and distance in miles "+distInMiles);
    }
}