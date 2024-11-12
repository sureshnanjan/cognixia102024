using System;
using System;

namespace KeywordLearning
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public abstract decimal CalculateSalary();

        public virtual void Display()
        {
            Console.WriteLine($"Employee Name: {Name}");
        }
    }

    public class FullTimeEmployee : Employee
    {
        private readonly decimal salary;
        public FullTimeEmployee(string name, decimal salary)
        {
            Name = name;
            this.salary = salary;
        }

        public override decimal CalculateSalary() => salary;

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Full-Time Salary: {salary}");
        }
    }

    public class PartTimeEmployee : Employee
    {
        private readonly decimal hourlyRate;
        private readonly int hoursWorked;
        public PartTimeEmployee(string name, decimal rate, int hours)
        {
            Name = name;
            hourlyRate = rate;
            hoursWorked = hours;
        }

        public override decimal CalculateSalary() => hourlyRate * hoursWorked;
    }

    public delegate void EmployeeDelegate();


}

