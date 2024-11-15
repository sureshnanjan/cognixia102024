using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PROJECT
{
    public class Set_
    {
        public void display()
        {
            // Create (Add)
            HashSet<string> set = new HashSet<string>();
            set.Add("Ajay");
            set.Add("Samson");

            // Read
            Console.WriteLine("Read from Set:");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            // Update (Set does not allow direct updates, so we remove and add)
            set.Remove("Ajay");
            set.Add("Ganesh");

            Console.WriteLine("\nAfter Update:");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            // Delete
            set.Remove("Alice");

            Console.WriteLine("\nAfter Delete:");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }

    }
}

