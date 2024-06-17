using System;

// Abstract class Shape
abstract class Shape
{
    public abstract double GetArea();
}

// Derived class Circle
class Circle : Shape
{
    private double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

// Derived class Rectangle
class Rectangle : Shape
{
    private double Length { get; set; }
    private double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double GetArea()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Console.WriteLine($"Area of Circle: {circle.GetArea()}");

        Rectangle rectangle = new Rectangle(4, 6);
        Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");
    }
}
