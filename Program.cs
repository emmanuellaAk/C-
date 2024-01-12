using System;
class Car
{
    public string color = "blue";
    public string type = "toyota";
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car();
        Car car2 = new Car();
        Console.WriteLine(car1.color);
        Console.WriteLine(car1.type);
        Console.WriteLine(car2.type);
    }
}

