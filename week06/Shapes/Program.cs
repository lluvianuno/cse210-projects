using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 5));
        shapes.Add(new Rectangle("blue", 12, 4));
        shapes.Add(new Circle("yellow", 2.4));

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            Console.WriteLine(color);
            double area = shape.GetArea();
            Console.WriteLine(area);
        }
    }
}