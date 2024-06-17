using System;

// Define an interface IMovable
interface IMovable
{
    void Move();
}

// Class Car implements IMovable
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Class Bicycle implements IMovable
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.Move();

        Bicycle bicycle = new Bicycle();
        bicycle.Move();
    }
}
