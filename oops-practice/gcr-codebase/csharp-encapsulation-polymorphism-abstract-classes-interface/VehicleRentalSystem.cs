using System;
interface IInsurable
{
    double CalculateInsurance();
    void GetInsuranceDetails();
    void DisplayDetails();
}
abstract class Vehicle : IInsurable
{
    int vehicleNumber;
    string type;
    int rentalRate;
    public int VehicleNumber
    {
        get { return vehicleNumber; }
        set { vehicleNumber = value; }
    }
    public string Type
    {
        get { return type; }
        set { type = value; }
    }
    public int RentalRate
    {
        get { return rentalRate; }
        set { rentalRate = value; }
    }
    abstract public double CalculateRentalCost(int days);
    public double CalculateInsurance()
    {
        return RentalRate * 0.1;
    }

    public void GetInsuranceDetails()
    {
        Console.WriteLine("Insurance is active for vehicle type: " + Type);
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Vehicle Number: " + vehicleNumber);
        Console.WriteLine("Type: " + type);
        Console.WriteLine("Rental Rate: " + rentalRate);
        Console.WriteLine("Insurance Cost: " + CalculateInsurance());
        GetInsuranceDetails();
    }
}
class Car : Vehicle
{
    int days;
    public Car(int vehicleNumber, string type, int rentalRate, int days)
    {
        VehicleNumber = vehicleNumber;
        Type = type;
        RentalRate = rentalRate;
        this.days = days;
    }
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }
}
class Bike : Vehicle
{
    int days;
    public Bike(int vehicleNumber, string type, int rentalRate, int days)
    {
        VehicleNumber = vehicleNumber;
        Type = type;
        RentalRate = rentalRate;
        this.days = days;
    }
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }
}
class Truck : Vehicle
{
    int days;
    public Truck(int vehicleNumber, string type, int rentalRate, int days)
    {
        VehicleNumber = vehicleNumber;
        Type = type;
        RentalRate = rentalRate;
        this.days = days;
    }
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }
}
class VehicleRentalSystem
{
    static void Main()
    {
        Vehicle[] vehicles = new Vehicle[3];
        vehicles[0] = new Car(101, "Sedan", 2000, 5);
        vehicles[1] = new Bike(102, "Sports", 500, 3);
        vehicles[2] = new Truck(103, "Cargo", 3000, 7);
        foreach (Vehicle v in vehicles)
        {
            v.DisplayDetails();
        }
    }
}