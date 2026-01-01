using System;
class HotelBooking
{
    string guestName;
    string roomType;
    int nights;
    // default constructor
    public HotelBooking()
    {
        guestName = "John Doe";
        roomType = "Standard";
        nights = 1;
        Console.WriteLine("Guest Name: " + guestName + ", Room Type: " + roomType + ", Nights: " + nights);
        Console.WriteLine("\nHotel booking created using default constructor.");
    }
    // parameterized constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }
    // copy constructor
    public HotelBooking(HotelBooking hb)
    {
        guestName = hb.guestName;
        roomType = hb.roomType;
        nights = hb.nights;
    }
    public void Display()
    {
        System.Console.WriteLine("\n");
        Console.WriteLine("Guest Name: " + guestName + ", Room Type: " + roomType + ", Nights: " + nights);
        Console.WriteLine("\nHotel booking created using copy constructor and parameterized constructor.");
    }
}
class HotelBookingSystem
{
    static void Main()
    {
        HotelBooking hb1 = new HotelBooking();
        HotelBooking hb2 = new HotelBooking("Dev", "Deluxe", 3);
        HotelBooking hb3 = new HotelBooking(hb2);
        hb3.Display();
    }
}