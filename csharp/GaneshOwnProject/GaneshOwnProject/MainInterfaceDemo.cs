using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GaneshOwnProject.Class1;

namespace GaneshOwnProject
{
    public class MainInterfaceDemo
    {
            static void Main(string[] args)
            {
                ICar myCar = new Car();
                myCar.StartEngine();
                myCar.StopEngine();

                IBike myBike = new Bike();
                myBike.Pedal();
                myBike.Brake();

            //This is the main function for IComparable interface
            var people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 },
            new Person { Name = "Charlie", Age = 35 }
        };

            people.Sort();  // This uses CompareTo method
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }



            //This is the main funtion for Ienmerable Interface
       
            
                var collection = new IenumerableDemo();
                foreach (var number in collection)
                {
                    Console.WriteLine(number);
                }
           //This is the main code for Environment Console
           EnvironmentConsole enc=new EnvironmentConsole();
            enc.display();
        

    }
}

    }

