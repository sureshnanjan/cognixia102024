using System;

namespace TypeSystemDemo
{
    
    public abstract class Animal
    {
        public abstract void Sound(); 
    }

    
    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Meow");
        }
    }

    
    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Baw Baw");
        }
    }
}
