using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class Dog:IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("This is Make Sound method");
        }

        // Providing implementation for Move method
        public void Move()
        {
            Console.WriteLine("The dog runs. (in Move Method)");
        }
    }
}
