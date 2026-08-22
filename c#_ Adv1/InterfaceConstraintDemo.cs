using System;

namespace AdvancedCSharp
{
    // Q10: An interface constraint requires T to implement a specific
    // interface, so the generic code can safely call members of that
    // interface on any T that is passed in.
    public interface IShape
    {
        double GetArea();
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
    }

    public class ShapePrinter<T> where T : IShape
    {
        public void PrintArea(T shape)
        {
            Console.WriteLine($"Area: {shape.GetArea():F2}");
        }
    }
}
