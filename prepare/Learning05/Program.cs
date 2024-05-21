using System;

class Program
{
    static void Main(string[] args)
    {
        Square square= new Square("White", 3);
        Rectangle rectangle = new Rectangle("Purple", 4, 9);
        Circle circle = new Circle("Teal", 6);

        List<Shape> shapes= new List<Shape>();
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);
        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Shape:{shape} Color:{color} Area:{area}");
        }
        
    }
}