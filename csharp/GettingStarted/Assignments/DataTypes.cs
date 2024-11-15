using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class TrainingDetails
    {
        public string TrainingName { get; set; }
        public DateTime Date { get; set; }
        public string Trainer { get; set; }
        public int Duration { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Participants { get; set; }
        public List<string> Topics { get; set; }
        public List<string> ToolsUsed { get; set; }
        public List<string> ParticipantsList { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("=== Training Details ===");
            Console.WriteLine($"Training Name: {TrainingName}");
            Console.WriteLine($"Date: {Date:dd.MM.yyyy}");
            Console.WriteLine($"Trainer: {Trainer}");
            Console.WriteLine($"Duration: {Duration} hours");
            Console.WriteLine($"From Date: {FromDate:dd-MMM}");
            Console.WriteLine($"End Date: {EndDate:dd'th' MMM}");
            Console.WriteLine($"Participants: {Participants}");

            Console.WriteLine("\nTopics:");
            foreach (var topic in Topics)
            {
                Console.WriteLine($" - {topic}");
            }

            Console.WriteLine("\nTools Used:");
            foreach (var tool in ToolsUsed)
            {
                Console.WriteLine($" - {tool}");
            }

            Console.WriteLine("\nParticipants List:");
            foreach (var participant in ParticipantsList)
            {
                Console.WriteLine($" - {participant}");
            }
        }
        public static void Display()
        {
            TrainingDetails training = new TrainingDetails
            {
                TrainingName = "C# Basics / Web Development / Cloud",
                Date = DateTime.Now,
                Trainer = "Suresh Nanjan",
                Duration = 16,
                FromDate = new DateTime(2024, 2, 15),
                EndDate = new DateTime(2024, 3, 9),
                Participants = 25,
                Topics = new List<string> { "C#", "Docker", "Jenkins", "WebDriver" },
                ToolsUsed = new List<string> { "MS Teams", "Google Classroom" },
                ParticipantsList = new List<string> { "Name1", "Name2", "Name3" }
            };

            // Display the details
            training.DisplayDetails();
        }
    }
}