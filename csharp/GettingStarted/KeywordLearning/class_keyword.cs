using System.Reflection.Metadata;

namespace KeywordLearning
{
    //interface
    public interface IArea
    {
        public double CalculateArea();
    }

    // abstract class
    public abstract class Shape
    {
        public string _name;
        //constructor
        public Shape(string name)
        {
            _name = name;
        }

        // Abstract method to display shape information
        public abstract void DisplayShapeInfo();
    }

    // Circle class inherits from Shape and implements IArea
    public class Circle : Shape, IArea
    {
        private double _radius { get; set; }
        //constructor
        public Circle(double radius) : base("Circle")
        {
            _radius = radius;
        }

        // Implementing CalculateArea() method from IArea
        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }

        public override void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: {_name}, Radius: {_radius}");
        }
    }

    // Triangle class inherits from Shape and implements IArea
    public class Triangle : Shape, IArea
    {
        private double _base { get; set; }
        
        private double _height { get; set; }

        public Triangle(double baseLength, double height) : base("Triangle")
        {
            _base = baseLength;
            _height = height;
        }

        // Implementing CalculateArea() method from IArea
        public double CalculateArea()
        {
            return 0.5 * _base * _height;
        }

        public override void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: {_name}, Base: {_base}, Height: {_height}");
        }
    }

}
