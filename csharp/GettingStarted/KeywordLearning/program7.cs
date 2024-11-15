using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class Training
    {
        public string TrainingName { get; set; }
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
            Console.WriteLine("Training Details:");
            Console.WriteLine($"Training Name: {TrainingName}");
            Console.WriteLine($"Trainer: {Trainer}");
            Console.WriteLine($"Duration: {Duration} hours");
            Console.WriteLine($"From Date: {FromDate:dd - MMM}");
            Console.WriteLine($"End Date: {EndDate:dd'th' MMM}");
            Console.WriteLine($"Participants: {Participants}");
            Console.WriteLine($"Topics: {string.Join(", ", Topics)}");
            Console.WriteLine($"Tools Used: {string.Join(", ", ToolsUsed)}");
            Console.WriteLine($"Participants List: {string.Join(", ", ParticipantsList)}");
        }
    }
}