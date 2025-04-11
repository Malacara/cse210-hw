using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("white", 3));
        shapes.Add(new Rectangle("black", 4, 5));
        shapes.Add(new Circle("blue", 6));

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Color: {color} | Area: {area}");
        }
    }
}