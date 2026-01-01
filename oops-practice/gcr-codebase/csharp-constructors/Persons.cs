using System;
class Person
{
    string name;
    int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    // copy constructor
    public Person(Person p)
    {
        name = p.name;
        age = p.age;
    }
    public void Display()
    {
        Console.WriteLine("Name: " + name + ", Age: " + age);
    }
}
class Persons
{
    static void Main()
    {
        Person p1 = new Person("Rohit", 20);
        Person p2 = new Person(p1); // calling copy constructor
        p2.Display();
    }
}