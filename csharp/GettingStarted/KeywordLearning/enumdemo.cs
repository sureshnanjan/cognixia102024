using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning;
// Enum defined outside the classes
public enum Status
{
    Unknown,
    Active,
    Inactive,
    Suspended
}

// Class Person that uses the Status enum
public class enumdemo
{
    public string Name { get; set; }
    public Status CurrentStatus { get; set; }

    // Constructor to initialize Name and Status
    public enumdemo(string name, Status status)
    {
        Name = name;
        CurrentStatus = status;
    }

    // Method to display person's information
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Status: {CurrentStatus}");
    }
}





