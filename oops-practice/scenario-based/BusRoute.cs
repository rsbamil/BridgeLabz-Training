using System;

class BusRoute
{
    static void Main()
    {
        Console.WriteLine("🚌 BUS ROUTE DISTANCE TRACKER 🚌");

        TrackJourney();
    }

    // Controls entire journey
    static void TrackJourney()
    {
        int totalDistance = 0;
        bool continueJourney = true;

        while (continueJourney)
        {
            int distance = GetDistanceFromStop();
            totalDistance = AddDistance(totalDistance, distance);

            continueJourney = AskPassenger();
        }

        DisplayTotalDistance(totalDistance);
    }

    // Takes distance of current stop
    static int GetDistanceFromStop()
    {
        Console.Write("\nEnter distance covered to this stop (in KM): ");
        int distance = Convert.ToInt32(Console.ReadLine());
        return distance;
    }

    // Adds distance to total
    static int AddDistance(int total, int current)
    {
        return total + current;
    }

    // Ask passenger if they want to get off
    static bool AskPassenger()
    {
        Console.Write("Do you want to get off here? (yes/no): ");
        string choice = Console.ReadLine().ToLower();

        if (choice == "yes")
        {
            return false; // Stop journey
        }
        else
        {
            return true; // Continue journey
        }
    }

    // Displays final distance
    static void DisplayTotalDistance(int total)
    {
        Console.WriteLine("\nPassenger got off!");
        Console.WriteLine("Total Distance Travelled = " + total + " KM");
    }
}
