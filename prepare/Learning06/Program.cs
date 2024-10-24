using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("red", 20);
        Rectangle rec = new Rectangle("blue", 20, 10);
        Circle cir = new Circle("yellow", 5);

        shapes.Add(square);
        shapes.Add(rec);
        shapes.Add(cir);



        foreach (Shape i in shapes)
        {
            Console.WriteLine($"Color is {i.GetColor()} and its area is {i.GetArea()}");
        }
    }
}