using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Assignment7
    {
        public void Output(string[] args)
        {
            // Training Details
            string trainingName = "C# Basics / Web Development / Cloud";
            string trainer = "Suresh Nanjan";
            int duration = 16; // Duration in days
            DateTime fromDate = new DateTime(2024, 2, 15); // From Date: 15th Feb 2024
            DateTime endDate = new DateTime(2024, 3, 9); // End Date: 9th March 2024
            int participantsCount = 20; // Number of participants

            // Topics (List of Topics)
            List<string> topics = new List<string> { "C#", "Docker", "Jenkins", "WebDriver" };

            // Tools Used (List of Tools)
            List<string> toolsUsed = new List<string> { "MS Teams", "Google Classroom" };

            // Participants List (List of Participants)
            List<string> participantsList = new List<string> { "John Doe", "Jane Smith", "Robert Brown" };

            // Display the Details
            Console.WriteLine("Training Name: " + trainingName);
            Console.WriteLine("Trainer: " + trainer);
            Console.WriteLine("Duration: " + duration + " days");
            Console.WriteLine("From Date: " + fromDate.ToString("dd - MMM yyyy")); // Custom Date Format
            Console.WriteLine("End Date: " + endDate.ToString("d MMMM yyyy")); // Custom Date Format
            Console.WriteLine("Participants: " + participantsCount);

            // Display Topics (Using string.Join to print collection elements in a formatted way)
            Console.WriteLine("Topics: " + string.Join(", ", topics));

            // Display Tools Used
            Console.WriteLine("Tools Used: " + string.Join(", ", toolsUsed));

            // Display Participants List
            Console.WriteLine("Participants List: {" + string.Join(", ", participantsList) + "}");
        }
    }
}
