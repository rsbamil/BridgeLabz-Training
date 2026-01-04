using System;

// Superclass
public class Device
{
    public int DeviceId;
    public string Status;

    public Device(int id, string status)
    {
        DeviceId = id;
        Status = status;
    }

    public virtual void DisplayStatus()
    {
        Console.WriteLine("Device ID: " + DeviceId);
        Console.WriteLine("Status: " + Status);
    }
}

// Subclass
public class Thermostat : Device
{
    public int TemperatureSetting;

    public Thermostat(int id, string status, int temp)
        : base(id, status)
    {
        TemperatureSetting = temp;
    }

    public override void DisplayStatus()
    {
        Console.WriteLine("\n--- Thermostat Status ---");
        base.DisplayStatus();
        Console.WriteLine("Temperature Setting: " + TemperatureSetting + "°C");
    }
}

// Main Class
class SmartHome
{
    static void Main()
    {
        Thermostat t1 = new Thermostat(101, "ON", 24);
        Thermostat t2 = new Thermostat(102, "OFF", 0);

        t1.DisplayStatus();
        t2.DisplayStatus();
    }
}
