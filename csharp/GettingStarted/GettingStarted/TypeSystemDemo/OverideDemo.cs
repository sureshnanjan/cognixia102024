using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemo
{

    // Base class
    public class Shape
    {
        // Virtual method that can be overridden in derived classes
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    // Derived class: Circle
    public class Circle : Shape
    {
        // Overriding the Draw method in the Circle class
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    // Derived class: Rectangle
    public class Rectangle : Shape
    {
        // Overriding the Draw method in the Rectangle class
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }
    
}
