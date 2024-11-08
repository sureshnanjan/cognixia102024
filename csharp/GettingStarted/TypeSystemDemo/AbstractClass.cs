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

    public abstract class Animal
    {
        public abstract void sound();
    }

    public class cat : Animal
    {
        public override void sound()
        {
            Console.WriteLine("meow");
        }
    }


    public class dog : Animal
    {
        public override void sound()
        {
            Console.WriteLine("baw baw");
        }
    }



}
