using System;

// GPS Interface
interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

// Abstract Base Class
abstract class Vehicle
{
    public int vehicleId;
    protected string driverName;
    private double ratePerKm;      // encapsulated field

    public Vehicle(int id, string name, double rate)
    {
        vehicleId = id;
        driverName = name;
        ratePerKm = rate;
    }

    // Encapsulation using property
    public double RatePerKm
    {
        get { return ratePerKm; }
        set { ratePerKm = value; }
    }

    public string GetVehicleDetails()
    {
        return "Vehicle ID: " + vehicleId + ", Driver: " + driverName + ", Rate/Km: " + ratePerKm;
    }

    public abstract double CalculateFare(double distance);
}

// Car Subclass
class Car : Vehicle, IGPS
{
    private string location = "Unknown";

    public Car(int id, string name, double rate) : base(id, name, rate) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }

    public string GetCurrentLocation()
    {
        return location;
    }

    public void UpdateLocation(string newLocation)
    {
        location = newLocation;
        Console.WriteLine("Car location updated to: " + newLocation);
    }
}

// Bike Subclass
class Bike : Vehicle, IGPS
{
    private string location = "Unknown";

    public Bike(int id, string name, double rate) : base(id, name, rate) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }

    public string GetCurrentLocation()
    {
        return location;
    }

    public void UpdateLocation(string newLocation)
    {
        location = newLocation;
        Console.WriteLine("Bike location updated to: " + newLocation);
    }
}

// Auto Subclass
class Auto : Vehicle, IGPS
{
    private string location = "Unknown";

    public Auto(int id, string name, double rate) : base(id, name, rate) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }

    public string GetCurrentLocation()
    {
        return location;
    }

    public void UpdateLocation(string newLocation)
    {
        location = newLocation;
        Console.WriteLine("Auto location updated to: " + newLocation);
    }
}

// Polymorphism Demonstration
class RideHailingApp
{
    static void ProcessVehicle(Vehicle v, double distance)
    {
        Console.WriteLine("\n" + v.GetVehicleDetails());
        Console.WriteLine("Fare for Distance " + distance + " km: " + v.CalculateFare(distance));
    }

    static void Main()
    {
        Vehicle[] vehicles = new Vehicle[3];

        vehicles[0] = new Car(1, "Rohit", 15);
        vehicles[1] = new Bike(2, "Amit", 8);
        vehicles[2] = new Auto(3, "Rahul", 10);

        Console.WriteLine("Processing Multiple Vehicle Types Dynamically:");

        foreach (Vehicle v in vehicles)
        {
            ProcessVehicle(v, 5);   // polymorphic fare calculation
        }

        Console.WriteLine("\nTesting GPS Interface:");

        IGPS gpsCar = vehicles[0] as IGPS;
        gpsCar.UpdateLocation("Delhi");
        Console.WriteLine("Current Car Location: " + gpsCar.GetCurrentLocation());

        IGPS gpsBike = vehicles[1] as IGPS;
        gpsBike.UpdateLocation("Noida");
        Console.WriteLine("Current Bike Location: " + gpsBike.GetCurrentLocation());
    }
}
