using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 14));
        shapes.Add(new Rectangle("Yellow", 7, 7));
        shapes.Add(new Circle("Blue", 7));


        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}
