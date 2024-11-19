using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_CSharp
{
    public class TrainingDetails
    {
        public static void DisplayTrainingDetails(string trainingName, DateTime trainingDate, string trainerName, int duration, DateTime fromDate, DateTime endDate, int participantsCount)
        {
            Console.WriteLine("Training Details:");
            Console.WriteLine($"Training Name: {trainingName}");
            Console.WriteLine($"Date: {trainingDate:dd/MM/yyyy}");
            Console.WriteLine($"Trainer: {trainerName}");
            Console.WriteLine($"Duration: {duration} days");
            Console.WriteLine($"From Date: {fromDate:dd-MMMM}");
            Console.WriteLine($"End Date: {endDate:dd-MMMM}");
            Console.WriteLine($"Participants: {participantsCount}");
        }

        // Method to display topics
        public static void DisplayTopics(List<string> topics)
        {
            Console.WriteLine($"Topics: {string.Join(", ", topics)}");
        }

        // Method to display tools used
        public static void DisplayTools(List<string> toolsUsed)
        {
            Console.WriteLine($"Tools Used: {string.Join(", ", toolsUsed)}");
        }

        // Method to display participants list
        public static void DisplayParticipants(List<string> participants)
        {
            Console.WriteLine($"Participants List: {string.Join(", ", participants)}");
        }

    }
}
