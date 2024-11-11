using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemo
{
    //public abstract class AbstractClass
    //{
    //    public abstract string Name { get; }
    //    public void Method() { }

    //    public abstract void Method2(); 
    //}

    public abstract class Fruits
    {
        public abstract void Shape();
    }

    public class Orange : Fruits
    {
        public override void Shape()
        {
            Console.WriteLine("Round");
        }
    }


    public class PineApple : Fruits
    {
        public override void Shape()
        {
            Console.WriteLine("Oval");
        }
    }
}