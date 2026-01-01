using System;
class CarRental
{
    string customerName;
    string carModel;
    int rentalDays;
    public CarRental(string customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
    }
    public void DisplayRentalInfo()
    {
        Console.WriteLine("Customer Name: " + customerName + ", Car Model: " + carModel + ", Rental Days: " + rentalDays);
        int totalCost = rentalDays * 50; // Assuming a flat rate of $50 per day
        Console.WriteLine("Total Rental Cost: $" + totalCost);
    }
}
class CarRentalSystem
{
    static void Main()
    {
        CarRental cr = new CarRental("Rohit", "Toyota", 5);
        cr.DisplayRentalInfo();
    }
}