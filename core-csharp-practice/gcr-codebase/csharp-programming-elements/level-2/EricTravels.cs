using System;

class EricTravels {
   public static void Main(string[] args) {

      string name = Console.ReadLine();
      
      string fromCity = Console.ReadLine();
      string viaCity = Console.ReadLine();
      string toCity = Console.ReadLine();

      double fromToVia  = Convert.ToDouble(Console.ReadLine());
      int timeFromToVia = 4 * 60 + 4; 
      double viaToFinalCity   = Convert.ToDouble(Console.ReadLine());
      int timeViaToFinalCity = 4 * 60 + 25; 

      double totalDistance = fromToVia + viaToFinalCity;
      int totalTime = timeFromToVia + timeViaToFinalCity;

      Console.WriteLine("The results of the trip are: "+totalDistance+" and "+totalTime);
   }
}
