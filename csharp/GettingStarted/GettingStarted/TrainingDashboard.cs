
using static KeywordLearning.class_keyword;
using Newtonsoft.Json;
using System;
using System.IO;
using My_CSharp;
namespace GettingStarted
{
    delegate void GettingStartedDelegate();
    delegate int MyIntDelegate(int x);
    /// <summary>
    /// This is a class to represent training reports 
    /// </summary>
    /// 
    public class TrainingDashboard
    {
        // Fields
        string _title;
        string _description;
        // DateTime _current_date;
        string[] _participants;
        // Participant[] tr_participants;

        // Operation
        /// <summary>
        /// 
        /// </summary>
        public void Publish()
        {
            Console.WriteLine("This is the Data for Dashboard");
        }

        public TrainingDashboard(string title, string desc, string participants)
        {
            this._title = title;
            this._description = desc;
            _participants = participants.Split(',');



            //foreach (var item in participants.Split(","))
            //{
            //    //this.participants.Append(item);
            //}

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="desc"></param>
        /// <param name="participants"></param>
        //public void Populate(string title, string desc, string participants) { }
        // static void Main(string[] args)
        // {
        //    GettingStartedDelegate myref = mymethod;
        //    Action myactionref = mymethod;
        //    Action mylambdaaction = () => { Console.WriteLine("This is a lambda method method to demo"); };
        //    MyIntDelegate myintref = SomeMethod;
        //    Func<int,int> myfunc = SomeMethod;
        //    Func<int> mylambdafunc = () => 100;
        //    //myref();
        //    mylambdaaction();
        //    Console.WriteLine(mylambdafunc());
        //    mylambdafunc();

        //    int[] numbers = { 1, 2, 3, 4, 5 };
        //    int added = numbers.Aggregate((x,y)=> x + y);
        //    int multipled = numbers.Aggregate((x, y) => x * y);
        //    int adddoubled = numbers.Aggregate((x, y) => (x + y) * 2);
        //    Console.WriteLine(multipled);
        //    Console.WriteLine(added);
        //    Console.WriteLine(adddoubled);
        //    numbers.
        // }
        public static void Main(string[] args)
        {


            //ClassKeyword demo = new ClassKeyword();

            GenericClass g = new GenericClass();
            g.run();
            Delegates delegates = new Delegates();
            Func<int, int, float, float, bool> compareDelegate = Delegates.CompareValues;

            // Delegate for (int, float) -> string
            Func<int, float, string> formatDelegate = Delegates.FormatResult;

            // Invoke the first delegate
            bool result = compareDelegate(3, 4, 5.5f, 1.5f);
            Console.WriteLine($"Comparison result: {result}");  // Output: Comparison result: True

            // Invoke the second delegate
            string formattedString = formatDelegate(42, 3.14159f);
            Console.WriteLine($"Formatted result: {formattedString}");

            Person person = new Person
            {
                Name = "John Doe",
                Age = 30,
                City = "New York"
            };
            string jsonString = JsonConvert.SerializeObject(person, Formatting.Indented);

            Console.WriteLine("Serialized JSON String: ");
            Console.WriteLine(jsonString);

            // Define the file path
            string filePath = "person.json";

            // Write the JSON string to a file
            File.WriteAllText(filePath, jsonString);

            Console.WriteLine($"JSON data written to file: {filePath}");

            // Read the file contents
            string readJsonString = File.ReadAllText(filePath);

            Console.WriteLine("Data read from file: ");
            Console.WriteLine(readJsonString);

            // Deserialize the JSON string back to an object
            Person deserializedPerson = JsonConvert.DeserializeObject<Person>(readJsonString);
            Console.WriteLine("Deserialized Object: ");
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}, City: {deserializedPerson.City}");

            //Training Details
          
            string trainingName = "C# Basics"; // Training name
            DateTime trainingDate = new DateTime(2024, 2, 15); // Date of the training
            string trainerName = "Suresh Nanjan"; // Trainer's name
            int duration = 16; // Duration in days
            DateTime fromDate = new DateTime(2024, 2, 15); // Start date
            DateTime endDate = new DateTime(2024, 3, 9); // End date
            int participantsCount = 3; // Number of participants
            List<string> topics = new List<string> { "C#", "Docker", "Jenkins", "WebDriver" }; // List of topics
            List<string> toolsUsed = new List<string> { "MS Teams", "Google Classroom" }; // List of tools used
            List<string> participants = new List<string> { "Name1", "Name2", "Name3" }; // List of participants

            // Call method to display all training details
            TrainingDetails.DisplayTrainingDetails(trainingName, trainingDate, trainerName, duration, fromDate, endDate, participantsCount);

            // Call method to display topics
            TrainingDetails.DisplayTopics(topics);

            // Call method to display tools used
            TrainingDetails.DisplayTools(toolsUsed);

            // Call method to display participants
            TrainingDetails.DisplayParticipants(participants);

            //Method Calling
            int num1 = 5;
            int num2 = 5;

            // Pass-by-value (squareVal)
            Console.WriteLine("Before squareVal: " + num1);
            MethodCalling.squareVal(num1); // Passing by value, so the original num1 will remain unchanged
            Console.WriteLine("After squareVal: " + num1); // num1 remains unchanged

            // Pass-by-reference (squareRef)
            Console.WriteLine("Before squareRef: " + num2);
            MethodCalling.squareRef(ref num2); // Passing by reference, num2 will be modified inside the method
            Console.WriteLine("After squareRef: " + num2);

            Console.WriteLine("----------------");
            int refValue = 10;
            Console.WriteLine("Before ref: " + refValue);
            MethodCalling.ModifyWithRef(ref refValue); 
            Console.WriteLine("After ref: " + refValue); 

            // Demonstrating 'out'
            int outValue;
            MethodCalling.InitializeWithOut(out outValue); 
            Console.WriteLine("After out: " + outValue); 

            // Demonstrating 'in'
            int inValue = 50;
            MethodCalling.ReadOnlyWithIn(in inValue); 
            Console.WriteLine("After in: " + inValue);
            SystemInfo.SystemDisplayInfo();

            SystemInfo.FileOperations();

            SystemInfo.DisplayEnvironment();

            SystemInfo.ParameterConventions();

            SystemInfo.Overload();
            Console.WriteLine("Welcome to the System Information Application!");

            // Display system information
            Console.WriteLine("Welcome to the Documentation Demo Application!");

            // Create an instance of the EnhancedCalculator class
            var calculator = new EnhancedCalculator();

            // Perform basic operations using the calculator
            int addResult = calculator.Add(5, 10);
            Console.WriteLine($"5 + 10 = {addResult}");

            int subtractResult = calculator.Subtract(15, 5);
            Console.WriteLine($"15 - 5 = {subtractResult}");

            int multiplyResult = calculator.Multiply(4, 6);
            Console.WriteLine($"4 * 6 = {multiplyResult}");

            double divideResult = calculator.Divide(10, 2);
            Console.WriteLine($"10 / 2 = {divideResult}");

            Oops.Derive();
        }



    }


}
