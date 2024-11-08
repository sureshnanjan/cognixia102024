/// <summary>
/// This class represents a training reports
/// </summary>
namespace GettingStarted
{
    internal class TrainingDashboard
    {
        // Fields
        private string _title;
        private string _description;
        private DateTime _currentDate;
        private Participant[] _trParticipants;

        // Constructor that accepts a list of participant names and maps them to Participant objects
        public TrainingDashboard(string title, string desc, string[] participants)
        {
            _title = title;
            _description = desc;
            // Convert string array to Participant array
            _trParticipants = CreateParticipants(participants);
        }

        // Method to convert string array to an array of Participant objects
        private Participant[] CreateParticipants(string[] participants)
        {
            // Placeholder employee code generation, just for this example
            var participantList = new List<Participant>();
            int id = 1;
            foreach (var participant in participants)
            {
                var nameParts = participant.Split(' ');
                // Assuming participant name is "FirstName LastName"
                participantList.Add(new Participant($"E{id++}", nameParts[0], nameParts[1]));
            }
            return participantList.ToArray();
        }

        // Method to publish the dashboard
        public void Publish()
        {
            Console.WriteLine("This is the Data for Dashboard");
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Description: {_description}");
            Console.WriteLine("Participants:");
            foreach (var participant in _trParticipants)
            {
                Console.WriteLine($"- {participant.FirstName} {participant.LastName} (Code: {participant.EmployeeCode})");
            }
        }

        static void Main(string[] args)
        {
            string trainerName = "Suresh Nanjan";
            Console.WriteLine(trainerName);
            Console.WriteLine("Hello, World!");

            // Example participants array (just names in this case)
            string[] participants = { "John Doe", "Jane Smith" };

            // Create an instance of TrainingDashboard with the participants
            TrainingDashboard automationTraining = new TrainingDashboard(
                "Automation Training",
                "Learn how to automate processes",
                participants
            );

            // Publish the training dashboard
            automationTraining.Publish();
        }
    }
}


