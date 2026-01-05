using System;
interface IRentable
{
    double CalculateRent(int days);
}
class Vehicle
{
    protected string brand;
    protected int pricePerDay;
    public string Brand
    {
        get { return brand; }
    }
    public Vehicle(string brand, int pricePerDay)
    {
        this.brand = brand;
        this.pricePerDay = pricePerDay;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("PricePerDay: " + pricePerDay);
    }
    public double CalculateRent(int days)
    {
        return pricePerDay * days;
    }
}
class Bike : Vehicle
{
    protected bool quickShifters;
    public Bike(string brand, int pricePerDay, bool quickShifters) : base(brand, pricePerDay)
    {
        this.brand = brand;
        this.pricePerDay = pricePerDay;
        this.quickShifters = quickShifters;
    }
}
class Car : Vehicle
{
    protected string fuelType;
    public Car(string brand, int pricePerDay, string fuelType) : base(brand, pricePerDay)
    {
        this.fuelType = fuelType;
    }
}
class Truck : Vehicle
{
    protected int loadCapacity;
    public Truck(string brand, int pricePerDay, int loadCapacity) : base(brand, pricePerDay)
    {
        this.loadCapacity = loadCapacity;
    }
}
class Customer
{
    protected string name;
    protected int age;
    protected string drivingLicenseNumber;
    protected Vehicle rentedVehicle;
    public Customer(string name, int age, string drivingLicenseNumber)
    {
        this.name = name;
        this.age = age;
        this.drivingLicenseNumber = drivingLicenseNumber;
    }
    public void RentVehicle(Vehicle vehicle)
    {
        rentedVehicle = vehicle;
        Console.WriteLine(name + " has rented a " + vehicle.Brand);
    }
    public void ReturnVehicle()
    {
        Console.WriteLine(name + " has returned the " + rentedVehicle.Brand);
        rentedVehicle = null;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Driving License Number: " + drivingLicenseNumber);
        if (rentedVehicle != null)
        {
            Console.WriteLine("Rented Vehicle: " + rentedVehicle.Brand);
        }
        else
        {
            Console.WriteLine("No vehicle rented currently.");
        }
    }

}
class VehicleRentalSystem
{
    static void Main()
    {
        Customer customer = new Customer("Ali Khan", 30, "DL12345");
        Bike bike = new Bike("Yamaha", 1000, true);
        customer.RentVehicle(bike);
        customer.DisplayInfo();
        double rentAmount = bike.CalculateRent(5);
        Console.WriteLine("Total Rent for 5 days: " + rentAmount);
        customer.ReturnVehicle();
        customer.DisplayInfo();
    }
}