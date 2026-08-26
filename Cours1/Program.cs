using System;

namespace RefactorPractice
{
    public class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();

        public void PrintInfo()
        {
            Console.WriteLine($"{GetType().Name} -> Area: {GetArea()}, Perimeter: {GetPerimeter()}");
        }
    }

    public class ShapeCalculator
    {
        public double GetArea(Shape shape)
        {
            if (shape.Type == "rectangle")
            {
                return shape.Width * shape.Height;
            }
            else if (shape.Type == "circle")
            {
                return 3.14159 * shape.Radius * shape.Radius;
            }
            else if (shape.Type == "triangle")
            {
                return 0.5 * shape.Width * shape.Height;
            }
            else
            {
                throw new Exception("Unknown shape type: " + shape.Type);
            }
        }

        public double GetPerimeter(Shape shape)
        {
            if (shape.Type == "rectangle")
            {
                return 2 * (shape.Width + shape.Height);
            }
            else if (shape.Type == "circle")
            {
                return 2 * 3.14159 * shape.Radius;
            }
            else if (shape.Type == "triangle")
            {
                return shape.Width * 3; // assumes equilateral
            }
            else
            {
                throw new Exception("Unknown shape type: " + shape.Type);
            }
        }

        public void PrintShapeInfo(Shape shape)
        {
            Console.WriteLine(shape.Type + " -> Area: " + GetArea(shape) + ", Perimeter: " + GetPerimeter(shape));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new ShapeCalculator();
            var shapes = new Shape[]
            {
                new Shape { Type = "rectangle", Width = 4, Height = 5 },
                new Shape { Type = "circle", Radius = 3 },
                new Shape { Type = "triangle", Width = 6, Height = 4 }
            };

            foreach (var shape in shapes)
            {
                calculator.PrintShapeInfo(shape);
            }
        }
    }
}
