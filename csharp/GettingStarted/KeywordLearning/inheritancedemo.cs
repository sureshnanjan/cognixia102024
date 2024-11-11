using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class inheritancedemo
    {
        // Fields
        protected string name;

        // Constructor
        public inheritancedemo(string name)
        {
            this.name = name;
        }

        // Virtual method (can be overridden by derived classes)
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }

        // Method to display the name
        public void DisplayInfo()
        {
            Console.WriteLine($"This animal's name is {name}.");
        }
    }

    // Derived class
    public class Dog : inheritancedemo
    {
        // Constructor (calls base class constructor)
        public Dog(string name) : base(name)
        {
        }

        // Overriding the virtual method
        public override void MakeSound()
        {
            Console.WriteLine($"{name} barks!");
        }

        // Additional method specific to Dog
        public void Fetch()
        {
            Console.WriteLine($"{name} is fetching the ball!");
        }
    }




}