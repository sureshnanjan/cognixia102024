using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemo
{
    public class Employee
    {
        public virtual void DisplayRole()
        {
            Console.WriteLine("Displaying employee role.");
        }
    }

    public class Manager : Employee
    {
        public override void DisplayRole()
        {
            Console.WriteLine("Displaying Manager role.");
        }
    }

    public class Developer : Employee
    {
        public override void DisplayRole()
        {
            Console.WriteLine("Displaying Developer role.");
        }
    }

}
