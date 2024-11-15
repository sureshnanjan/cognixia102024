using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaneshOwnProject
{
    // Implementing IComparable in a Person class
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (other == null) return 1;
            return this.Age.CompareTo(other.Age);
        }
    }

}
