using System;
class Vehicle
{
    string ownerName;
    string vehicleType;
    static int registrationFee = 100;
    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Vehicle Registered: " + ownerName + ", Type: " + vehicleType + ", Fee: $" + registrationFee);
    }
    public static void UpdateRegistrationFee(int newFee)
    {
        registrationFee = newFee;
    }
}
class VehicleRegistration
{
    static void Main()
    {
        Vehicle v1 = new Vehicle("RK", "Car");
        Vehicle v2 = new Vehicle("Dev", "Bike");
        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();
        Vehicle.UpdateRegistrationFee(150);
        Vehicle v3 = new Vehicle("Devi", "Truck");
        v3.DisplayVehicleDetails();
    }
}