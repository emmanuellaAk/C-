using System;
class Car
{
    public string name;
    public string color;

    public Car(string name1, string color1)
    {
        name = name1;
        color = color1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car Ford = new Car("Ford", "blue");

        Car Toyota = new Car("Toyota", "green");

        Console.WriteLine(Ford.name + " " + Ford.color);
        Console.WriteLine(Toyota.color);

    }
}

