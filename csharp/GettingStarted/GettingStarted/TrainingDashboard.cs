using System;
using KeywordLearning;

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
            // Execute all the 'class_keyword' examples

            // Creating an instance of the 'class_keyword' class
            class_keyword keywordExamples = new class_keyword(10);

            // 1. Demonstrating PublicField and ReadOnlyField
            Console.WriteLine($"Public Field Value: {keywordExamples.PublicField}");
            Console.WriteLine($"ReadOnly Field Value: {keywordExamples.ReadOnlyField}");

            // 2. Demonstrating MethodWithKeywords with ref, out, and params
            int refValue = 10;
            string outValue;
            keywordExamples.MethodWithKeywords(ref refValue, out outValue, 1, 2, 3);
            Console.WriteLine($"Ref Value: {refValue}, Out Value: {outValue}");

            // 3. Adding numbers using AddNumbers method
            int sum = keywordExamples.AddNumbers(5, 10);
            Console.WriteLine($"Sum: {sum}");

            // 4. Demonstrating Exception Handling with ExceptionHandlingExample
            keywordExamples.ExceptionHandlingExample();

            // 5. If-else statement demonstration
            keywordExamples.IfElseExample(5);

            // 6. Demonstrating loops with LoopExamples method
            keywordExamples.LoopExamples();

            // 7. Checking type with IsExample method
            keywordExamples.IsExample("Hello");

            // 8. 'goto' example (though goto is not often used in modern code)
            keywordExamples.GotoExample();

            // 9. Delegate example
            class_keyword.MyDelegate del = keywordExamples.DelegateExampleMethod;
            del("This is a delegate example.");

            // 10. Locking example
            keywordExamples.LockExample();

            // 11. Throw exception example
            try
            {
                keywordExamples.ThrowExample();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Caught exception: {ex.Message}");
            }

            // 12. Using 'this' keyword in method
            keywordExamples.ThisKeywordExample();

            // 13. Demonstrating sizeof and typeof
            keywordExamples.SizeofAndTypeofExample();

            // 14. Enum example for CarType
            Console.WriteLine($"Car Type: {CarType.SUV}");

            // Example for TrainingDashboard
            string[] participants = { "John Doe", "Jane Smith" };
            TrainingDashboard dashboard = new TrainingDashboard("Automation Training", "Learn how to automate processes", participants);
            dashboard.Publish();

            // End of execution

        }
    }
}
