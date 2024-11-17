using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted
{
    public  class TrainingDetails
    {
        public string TrainingName { get; set; }
        public string Trainer { get; set; }
        public int Duration { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ParticipantsCount { get; set; }
        public List<string> Topics { get; set; }
        public List<string> ToolsUsed { get; set; }
        public List<string> ParticipantsList { get; set; }
        public string TrainingLink { get; set; }

        public static void DisplayTrainingDetails(TrainingDetails details)
        {
            // Display the training details in the specified format
            Console.WriteLine($"Training Name: {details.TrainingName} {DateTime.Now:dd/MM/yyyy}");
            Console.WriteLine($"Date: {DateTime.Now:dd/MM/yyyy}");
            Console.WriteLine($"Trainer: {details.Trainer} {GenerateRandomString(5)}");
            Console.WriteLine($"Duration: {details.Duration} hours");
            Console.WriteLine($"From Date: {details.FromDate:dd - MMM}");
            Console.WriteLine($"End Date: {details.EndDate:dd MMMM}");
            Console.WriteLine($"Participants: {details.ParticipantsCount}");
            Console.WriteLine($"Topics: {string.Join(", ", details.Topics)}");
            Console.WriteLine($"Tools Used: {string.Join(", ", details.ToolsUsed)}");
            Console.WriteLine($"Participants List: {string.Join(", ", details.ParticipantsList)}");
            
        }

        static string GenerateRandomString(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            char[] randomChars = new char[length];
            for (int i = 0; i < length; i++)
            {
                randomChars[i] = chars[random.Next(chars.Length)];
            }
            return new string(randomChars);
        }



    }
}
