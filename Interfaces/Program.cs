// See https://aka.ms/new-console-template for more information
// Program.cs
using System;

public interface IShape
{
    double GetArea();
    double GetPerimeter();
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }

    public double GetPerimeter()
    {
        return 2 * (Width + Height);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape circle = new Circle(5);
        IShape rectangle = new Rectangle(4, 6);

        Console.WriteLine($"Circle Area: {circle.GetArea()}, Perimeter: {circle.GetPerimeter()}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}, Perimeter: {rectangle.GetPerimeter()}");
    }
}
