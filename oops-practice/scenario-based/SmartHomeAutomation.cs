using System;
interface IControllable
{
    void TurnOn();
    void TurnOff();
}
class Appliance : IControllable
{
    public string Name { get; set; }
    public Appliance(string name)
    {
        Name = name;
    }
    public virtual void TurnOn()
    {
        Console.WriteLine(Name + "is turned ON.");
    }
    public virtual void TurnOff()
    {
        Console.WriteLine(Name + "is turned OFF.");
    }
}
class Light : Appliance
{
    public Light(string name) : base(name) { }

    public override void TurnOn()
    {
        Console.WriteLine(Name + " light is turned ON with soft brightness.");
    }

    public override void TurnOff()
    {
        Console.WriteLine(Name + " light is turned OFF.");
    }
}
class Fan : Appliance
{
    public Fan(string name) : base(name) { }

    public override void TurnOn()
    {
        Console.WriteLine(Name + " fan is spinning at medium speed.");
    }

    public override void TurnOff()
    {
        Console.WriteLine(Name + " fan is stopped.");
    }
}
class AC : Appliance
{
    public AC(string name) : base(name) { }

    public override void TurnOn()
    {
        Console.WriteLine(Name + " AC is cooling the room to 22°C.");
    }

    public override void TurnOff()
    {
        Console.WriteLine(Name + " AC is turned OFF.");
    }
}
class SmartHomeAutomation
{
    static void Main()
    {
        IControllable[] appliances =
        {
            new Light("Bedroom"),
            new Fan("Living Room"),
            new AC("Office")
        };

        foreach (IControllable appliance in appliances)
        {
            appliance.TurnOn();
            appliance.TurnOff();
            Console.WriteLine();
        }
    }
}
