using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 5.0);
        Console.WriteLine($"Square Color: {square.GetColor()}");
        Console.WriteLine($"Square Area: {square.GetArea()}");

        Circle circle = new Circle("Blue", 3.0);
        Console.WriteLine($"Circle Color: {circle.GetColor()}");
        Console.WriteLine($"Circle Area: {circle.GetArea()}");

        Rectangle rectangle = new Rectangle("Green", 4.0, 6.0);
        Console.WriteLine($"Rectangle Color: {rectangle.GetColor()}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

        List<Shape> shapes = new List<Shape> { square, circle, rectangle };
        Console.WriteLine("\nAll Shapes:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}