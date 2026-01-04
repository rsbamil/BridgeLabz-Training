using System;

interface IRefuelable
{
    void Refuel();
}

class Vehicle
{
    public string Model;
    public int MaxSpeed;

    public Vehicle(string model, int maxSpeed)
    {
        Model = model;
        MaxSpeed = maxSpeed;
    }
}

class ElectricVehicle : Vehicle
{
    public ElectricVehicle(string model, int maxSpeed) : base(model, maxSpeed) { }

    public void Charge()
    {
        Console.WriteLine(Model + " is charging its battery.");
    }
}

class PetrolVehicle : Vehicle, IRefuelable
{
    public PetrolVehicle(string model, int maxSpeed) : base(model, maxSpeed) { }

    public void Refuel()
    {
        Console.WriteLine(Model + " is refueling with petrol.");
    }
}

class VehicleManagement
{
    static void Main()
    {
        ElectricVehicle ev = new ElectricVehicle("Tesla Model 3", 220);
        PetrolVehicle pv = new PetrolVehicle("Honda City", 190);

        ev.Charge();
        pv.Refuel();
    }
}
