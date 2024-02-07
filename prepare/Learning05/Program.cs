using System;
using System.Collections.Generic; // Needed for List<T>

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("Red", 3);
        shapes.Add(square1);

        Rectangle square2 = new Rectangle("Blue", 4, 5);
        shapes.Add(square2);

        Circle square3 = new Circle("Green", 6);
        shapes.Add(square3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}
