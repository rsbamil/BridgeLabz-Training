using System;
class Vehicle
{
    static int RegistrationFee = 500;
    string ownerName;
    string vehicleType;
    readonly string RegistrationNumber;
    public Vehicle(string ownerName, string vehicleType, string RegistrationNumber)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
        this.RegistrationNumber = RegistrationNumber;
    }
    public static void UpdateRegistrationFee(int newFee)
    {
        RegistrationFee = newFee;
    }
    public void DisplayVehicleInfo()
    {
        Console.WriteLine("Owner Name: " + ownerName + ", Vehicle Type: " + vehicleType + ", Registration Number: " + RegistrationNumber + ", Registration Fee: " + RegistrationFee);
    }
}
class VehicleRegistrationSystem
{
    static void Main()
    {
        Vehicle v1 = new Vehicle("Rohit", "Car", "REG123");
        Vehicle v2 = new Vehicle("Dev", "Bike", "REG456");
        if (v1 is Vehicle)
        {
            Console.WriteLine("v1 is an instance of Vehicle");
            v1.DisplayVehicleInfo();
        }
        if (v2 is Vehicle)
        {
            Console.WriteLine("v2 is an instance of Vehicle");
            v2.DisplayVehicleInfo();
        }
        Vehicle.UpdateRegistrationFee(600);
        Console.WriteLine("After updating registration fee:");
        v1.DisplayVehicleInfo();
        v2.DisplayVehicleInfo();
    }
}