using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter Employee ID: ");
        string employeeId = Console.ReadLine();
        
        Console.Write("Enter Designation: ");
        string designation = Console.ReadLine();
        
        Console.Write("Enter Gender: ");
        string gender = Console.ReadLine();
        
        Console.Write("Enter Place: ");
        string place = Console.ReadLine();
       
        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Designation: " + designation);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Place: " + place);
    }
}
