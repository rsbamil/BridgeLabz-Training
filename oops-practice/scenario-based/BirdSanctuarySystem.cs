using System;

interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

// Base class containing common attributes
class Bird
{
    protected string name;

    public Bird(string name)
    {
        this.name = name;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Bird Name: " + name);
    }
}

// Derived classes implementing interfaces

class Eagle : Bird, IFlyable
{
    public Eagle(string name) : base(name) { }

    public void Fly()
    {
        Console.WriteLine(name + " can fly.");
    }
}

class Sparrow : Bird, IFlyable
{
    public Sparrow(string name) : base(name) { }

    public void Fly()
    {
        Console.WriteLine(name + " can fly.");
    }
}

class Duck : Bird, ISwimmable
{
    public Duck(string name) : base(name) { }

    public void Swim()
    {
        Console.WriteLine(name + " can swim.");
    }
}

class Penguin : Bird, ISwimmable
{
    public Penguin(string name) : base(name) { }

    public void Swim()
    {
        Console.WriteLine(name + " can swim.");
    }
}

class Seagull : Bird, IFlyable, ISwimmable
{
    public Seagull(string name) : base(name) { }

    public void Fly()
    {
        Console.WriteLine(name + " can fly.");
    }

    public void Swim()
    {
        Console.WriteLine(name + " can also swim.");
    }
}

// Main System class using arrays and interface polymorphism

class BirdSanctuarySystem
{
    static void Main()
    {
        Bird[] birds = new Bird[5];

        birds[0] = new Eagle("Eagle");
        birds[1] = new Sparrow("Sparrow");
        birds[2] = new Duck("Duck");
        birds[3] = new Penguin("Penguin");
        birds[4] = new Seagull("SeaGull");

        Console.WriteLine("Bird Sanctuary Tracking System\n");

        foreach (Bird b in birds)
        {
            b.DisplayInfo();

            if (b is IFlyable)
            {
                IFlyable fb = (IFlyable)b;
                fb.Fly();
            }

            if (b is ISwimmable)
            {
                ISwimmable sb = (ISwimmable)b;
                sb.Swim();
            }

            Console.WriteLine();
        }
    }
}
