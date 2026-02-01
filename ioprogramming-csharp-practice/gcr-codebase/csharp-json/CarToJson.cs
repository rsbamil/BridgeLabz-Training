using Newtonsoft.Json;
using System;

class Car
{
    public string Brand { get; set; }
    public int Year { get; set; }
}

class CarToJson
{
    static void Main()
    {
        Car car = new Car { Brand = "BMW", Year = 2023 };
        Console.WriteLine(JsonConvert.SerializeObject(car, Formatting.Indented));
    }
}
