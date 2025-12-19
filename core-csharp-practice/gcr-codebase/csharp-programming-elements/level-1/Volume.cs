using System;
class Volume{
    static void Main(){
        double volInKm=(4.0/3.0)*3.14*6378 *6378 *6378;
        double volInMiles=volInKm*0.621371*0.621371*0.621371;
        Console.WriteLine(" The volume of earth in cubic kilometers is "+volInKm+" and cubic miles is "+volInMiles);

    }
}