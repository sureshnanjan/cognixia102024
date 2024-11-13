using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning;

public interface Interface1
{
    void MakeSound();  // Method signature (no implementation)
    void Move();       // Another method signature


    // Implement the interface in a class
    public class MyDog : Interface1
    {
        // Implementing the MakeSound method
        public void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }

        // Implementing the Move method
        public void Move()
        {
            Console.WriteLine("The dog runs.");
        }
    }

    public class Cat : Interface1
    {
        // Implementing the MakeSound method
        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        // Implementing the Move method
        public void Move()
        {
            Console.WriteLine("The cat walks gracefully.");
        }
    }

}

