using System;

interface IWorker
{
    void PerformDuties();
}

class Person
{
    public string Name;
    public int Id;

    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }
}

class Chef : Person, IWorker
{
    public Chef(string name, int id) : base(name, id) { }

    public void PerformDuties()
    {
        Console.WriteLine("Chef " + Name + " is cooking delicious food.");
    }
}

class Waiter : Person, IWorker
{
    public Waiter(string name, int id) : base(name, id) { }

    public void PerformDuties()
    {
        Console.WriteLine("Waiter " + Name + " is serving customers.");
    }
}

class ResturantSystem
{
    static void Main()
    {
        IWorker w1 = new Chef("Rahul", 101);
        IWorker w2 = new Waiter("Amit", 102);

        w1.PerformDuties();
        w2.PerformDuties();
    }
}
