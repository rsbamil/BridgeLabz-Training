using System;

// Superclass
public class Vehicle
{
    public int MaxSpeed;
    public string FuelType;

    public Vehicle(int maxSpeed, string fuelType)
    {
        MaxSpeed = maxSpeed;
        FuelType = fuelType;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Max Speed: " + MaxSpeed + " km/h");
        Console.WriteLine("Fuel Type: " + FuelType);
    }
}

// Car subclass
public class Car : Vehicle
{
    public int SeatCapacity;

    public Car(int maxSpeed, string fuelType, int seats)
        : base(maxSpeed, fuelType)
    {
        SeatCapacity = seats;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("\n--- Car ---");
        base.DisplayInfo();
        Console.WriteLine("Seat Capacity: " + SeatCapacity);
    }
}

// Truck subclass
public class Truck : Vehicle
{
    public int PayloadCapacity;

    public Truck(int maxSpeed, string fuelType, int payload)
        : base(maxSpeed, fuelType)
    {
        PayloadCapacity = payload;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("\n--- Truck ---");
        base.DisplayInfo();
        Console.WriteLine("Payload Capacity: " + PayloadCapacity + " kg");
    }
}

// Motorcycle subclass
public class Motorcycle : Vehicle
{
    public bool HasSidecar;

    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
        : base(maxSpeed, fuelType)
    {
        HasSidecar = hasSidecar;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("\n--- Motorcycle ---");
        base.DisplayInfo();
        Console.WriteLine("Has Sidecar: " + HasSidecar);
    }
}

// Main class
class VehicleTransportSystem
{
    static void Main()
    {
        // Polymorphism: array of Vehicle
        Vehicle[] vehicles = new Vehicle[3];

        vehicles[0] = new Car(180, "Petrol", 5);
        vehicles[1] = new Truck(120, "Diesel", 5000);
        vehicles[2] = new Motorcycle(150, "Petrol", false);

        foreach (Vehicle v in vehicles)
        {
            v.DisplayInfo();   // Dynamic method dispatch
        }
    }
}
