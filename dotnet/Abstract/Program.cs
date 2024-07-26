// See https://aka.ms/new-console-template for more information
using System;

public abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();
    
    public void Display()
    {
        Console.WriteLine($"Area: {GetArea()}");
        Console.WriteLine($"Perimeter: {GetPerimeter()}");
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }
    
    public Circle(double radius)
    {
        Radius = radius;
    }
    
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
    
    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }
    
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }
    
    public override double GetArea()
    {
        return Length * Width;
    }
    
    public override double GetPerimeter()
    {
        return 2 * (Length + Width);
    }
}

// Example usage
public class Program
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        circle.Display();
        
        Rectangle rectangle = new Rectangle(4, 6);
        rectangle.Display();
    }
}

