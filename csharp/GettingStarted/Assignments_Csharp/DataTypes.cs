using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Csharp
{
    /// <summary>
    /// The DataTypes class represents the details of a training session, 
    /// including training name, trainer, duration, dates, participants, 
    /// topics covered, tools used, and participants list.
    /// </summary>
    public class DataTypes
    {
        public string TrainingName { get; set; }
        public DateTime TrainingDate { get; set; }
        public string Trainer { get; set; }
        public int Duration { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Participants { get; set; }
        public List<string> Topics { get; set; }
        public List<string> ToolsUsed { get; set; }
        public List<string> ParticipantsList { get; set; }

        // Constructor to initialize the properties
        public DataTypes(string trainingName, DateTime trainingDate, string trainer, int duration, DateTime fromDate, DateTime endDate, int participants, List<string> topics, List<string> toolsUsed, List<string> participantsList)
        {
            TrainingName = trainingName;
            TrainingDate = trainingDate;
            Trainer = trainer;
            Duration = duration;
            FromDate = fromDate;
            EndDate = endDate;
            Participants = participants;
            Topics = topics;
            ToolsUsed = toolsUsed;
            ParticipantsList = participantsList;
        }

        /// <summary>
        /// Displays the details of the training session
        /// </summary>
        public void DisplayTrainingDetails()
        {
            Console.WriteLine($"Training Name: {TrainingName}");
            Console.WriteLine($"Date: {TrainingDate:dd/MM/yyyy}");
            Console.WriteLine($"Trainer: {Trainer}");
            Console.WriteLine($"Duration: {Duration} days");
            Console.WriteLine($"From Date: {FromDate:dd - MMM}");
            Console.WriteLine($"End Date: {EndDate:dd - MMMMM}");
            Console.WriteLine($"Participants: {Participants}");
            Console.WriteLine($"Topics: {string.Join(", ", Topics)}");
            Console.WriteLine($"Tools Used: {string.Join(", ", ToolsUsed)}");
            Console.WriteLine($"Participants List: {string.Join(", ", ParticipantsList)}");
        }

        /// <summary>
        /// A static method that creates a DataTypes object with sample training details 
        /// and displays the details using the DisplayTrainingDetails method.
        /// </summary>
        public static void DataTypeCall()
        {
            // Create training details
            var topics = new List<string> { "C#", "Docker", "Jenkins", "WebDriver" };
            var toolsUsed = new List<string> { "MS Teams", "Google Classroom" };
            var participantsList = new List<string> { "John", "Jane", "Smith" };
            var training = new DataTypes(
                "C# Basics / Web Development / Cloud",
                new DateTime(2024, 2, 15),
                "Suresh Nanjan",
                16,
                new DateTime(2024, 2, 15),
                new DateTime(2024, 3, 9),
                17,
                topics,
                toolsUsed,
                participantsList
            );
            training.DisplayTrainingDetails();
        }
    }
}
