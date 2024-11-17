using System.Reflection.Metadata;
using PetstoreModel;
using TypeSystemDemo;
using KeywordLearning;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace GettingStarted
{
    delegate void GettingStartedDelegate();
    delegate int MyIntDelegate(int x);
    /// <summary>
    /// This is a class to represent training reports 
    /// </summary>
    internal class TrainingDashboard
    {
        //   Fields
        string _title;
        string _description;
        DateTime _current_date;
        string[] participants;
        Participant[] tr_participants;

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
            foreach (var item in participants.Split(","))
            {
                //this.participants.Append(item);
            }


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="desc"></param>
        /// <param name="participants"></param>
        //public void Populate(string title, string desc, string participants) { }
        //static void Main(string[] args)
        //{
        //    GettingStartedDelegate myref = mymethod;
        //    Action myactionref = mymethod;
        //    Action mylambdaaction = () => { Console.WriteLine("This is a lambda method method to demo"); };
        //    MyIntDelegate myintref = SomeMethod;
        //    Func<int, int> myfunc = SomeMethod;
        //    Func<int> mylambdafunc = () => 100;
        //    //myref();
        //    mylambdaaction();
        //    Console.WriteLine(mylambdafunc());
        //    mylambdafunc();

        //    int[] numbers = { 1, 2, 3, 4, 5 };
        //    int added = numbers.Aggregate((x, y) => x + y);
        //    int multipled = numbers.Aggregate((x, y) => x * y);
        //    int adddoubled = numbers.Aggregate((x, y) => (x + y) * 2);
        //    Console.WriteLine(multipled);
        //    Console.WriteLine(added);
        //    Console.WriteLine(value: adddoubled);
        //    numbers.
        //}

        //private static void SomeOtherMethod()
        //{
        //    Console.WriteLine("Doing some other complext operation");
        //}

        //private static int add(int a, int b)
        //{
        //    return a + b;
        //}

        //private static void PerformThis(GettingStartedDelegate x)
        //{
        //    Console.WriteLine("Going to perform the required Operation");
        //    x();
        //}

        //private static int SomeMethod(int arh1)
        //{
        //    Console.WriteLine($"This is inside my Int Method {arh1}");
        //    return 0;
        //}

        //private static void mymethod()
        //{
        //    Console.WriteLine("This is a Method Returning Void Taking Nothing");
        //}

        //private static void Interface_Demo()
        //{
        //    // Name + number of arguments + types of arguments
        //    //dashboard_demo();
        //    //User suresh = new User();
        //    Console.WriteLine("Welcome to Programming");
        //    ClassDemo myclass = new ClassDemo(1, "suresh");
        //    Console.WriteLine(myclass);
        //    int[] numbers = { 10, 12, 3, 0, 9, 25 };
        //    Array.Sort(numbers);
        //    foreach (var item in numbers)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    ClassDemo[] myTypes = { new ClassDemo(1, "A"), new ClassDemo(5, "Five"), new ClassDemo(2, "two") };
        //    Array.Sort(myTypes);
        //    foreach (var item in myTypes)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}


        //static void Interface_Demo(string arg1) { }
        //static void Interface_Demo(int arg1) { }

        ////int Interface_Demo(string arg1) { }

        //private static void dashboard_demo()
        //{

        //    string trainername = "Suresh Nanjan";
        //    Console.WriteLine("Hello, World!");
        //    TrainingDashboard automationTraining = new TrainingDashboard("", "", "");
        //    //automationTraining.Populate()
        //    //automationTraining.Publish();

        //    // A collection of Moving Objects
        //    IMove[] movingobjects = { new Car(), new Bird(), new Bike() };
        //    MoveObjects(movingobjects);

        //    int num1 = 10;
        //    int num2 = 11;
        //    ClassDemo cl1 = new ClassDemo(1, "one");
        //    ClassDemo cl2 = new ClassDemo(2, "two");
        //    DayOfWeek dayofWeek = DayOfWeek.Sunday;


        //}

        //private static void MoveObjects(IMove[] movingobjects)
        //{
        //    foreach (var item in movingobjects)
        //    {
        //        item.Move();
        //    }
        //}




        public static void Main(string[] args)
        {
            //Generic gener = new Generic();
            //bool exit = false;
            //gener.AddToCollections();

            //gener.DisplayCollections();

            //gener.ModifyCollections();


            //gener.DeleteFromCollections();

            ////while (!exit)
            ////{
            ////    Console.Clear();
            ////    Console.WriteLine("--- Collection Menu ---");
            ////    Console.WriteLine("1. Initialize Collections");
            ////    Console.WriteLine("2. Display Collections");
            ////    Console.WriteLine("3. Modify Collections");
            ////    Console.WriteLine("4. Delete Elements from Collections");
            ////    Console.WriteLine("5. Exit");
            ////    Console.Write("Please select an option (1-5): ");



            ////    gener.AddToCollections();

            ////    gener.DisplayCollections();

            ////    gener.ModifyCollections();


            ////    gener.DeleteFromCollections();




            ////}
            ///
            Func<int, int, float, float, bool> delegate1 = Program.CompareSum;
            Func<int, float, string> delegate2 = Program.SumAsString;

            // Invoking delegate1 (CompareSum)
            bool result1 = delegate1(5, 3, 2.5f, 1.5f);
            Console.WriteLine($"Result of delegate1: {result1}");  // Output: True (5+3 > 2.5+1.5)

            // Invoking delegate2 (SumAsString)
            string result2 = delegate2(5, 2.5f);
            Console.WriteLine($"Result of delegate2: {result2}");  // Output: The result is: 7.5
            //}
            Person person = new Person
            {
                Name = "John Doe",
                Age = 30,
                City = "New York"
            };

            // Step 2: Serialize the object to JSON string
            string jsonString = JsonConvert.SerializeObject(person, Formatting.Indented);

            // Step 3: Write the serialized string to a file
            string filePath = "person.json";
            File.WriteAllText(filePath, jsonString);

            Console.WriteLine($"Serialized JSON written to {filePath}");

            // Step 4: Read the JSON string from the file
            string readJsonString = File.ReadAllText(filePath);

            // Step 5: Deserialize the JSON string back into an object
            Person deserializedPerson = JsonConvert.DeserializeObject<Person>(readJsonString);

            // Step 6: Output the deserialized object
            Console.WriteLine("\nDeserialized Object:");
            Console.WriteLine($"Name: {deserializedPerson.Name}");
            Console.WriteLine($"Age: {deserializedPerson.Age}");
            Console.WriteLine($"City: {deserializedPerson.City}");
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
            Console.WriteLine("----------------------");

            int value = 5;
            int refValue = 5;

            Console.WriteLine($"Before squareVal: {value}");
            CallByValue.squareVal(value);
            Console.WriteLine($"After squareVal: {value}"); // Output will be same as before: 5

            // Pass by reference (refValue will be modified outside the method)
            Console.WriteLine($"Before squareRef: {refValue}");
            CallByValue.squareRef(ref refValue);
            Console.WriteLine($"After squareRef: {refValue}"); // Output will be modified: 25
            Console.WriteLine("----------------------");
            int inValue = 4;
            int outValue;
             refValue = 3;

            // Call squareIn (inParameter is read-only inside the method)
            CallByRef.squareIn(inValue);

            // Call squareOut (outParameter is modified inside the method)
            CallByRef.squareOut(out outValue);
            Console.WriteLine($"After squareOut, outValue is: {outValue}"); // Output: 100

            // Call squareRef (refParameter is modified inside the method)
            Console.WriteLine($"Before squareRef: {refValue}");
            CallByRef.squareRef(ref refValue);
            Console.WriteLine($"After squareRef: {refValue}"); // Output: 9
            Oops.Derive();
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            Console.WriteLine("=== System Information ===");
            SystemInfo.SystemDisplayInfo();

            // File operations example
            Console.WriteLine("\n=== File Operations Example ===");
            SystemInfo.FileOperations();

            // Display environment information
            Console.WriteLine("\n=== Environment Information ===");
            SystemInfo.DisplayEnvironment();

            // Parameter conventions example
            Console.WriteLine("\n=== Parameter Conventions Example ===");
            SystemInfo.ParameterConventions();

            // Overloaded methods example
            SystemInfo.Overload();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            EnhancedCalculator calculator = new EnhancedCalculator();

            // Perform some calculations
            int num1 = 10;
            int num2 = 5;

            Console.WriteLine("=== Simple Calculator Demo ===");

            // Addition
            int additionResult = calculator.Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {additionResult}");

            // Subtraction
            int subtractionResult = calculator.Subtract(num1, num2);
            Console.WriteLine($"{num1} - {num2} = {subtractionResult}");

            // Multiplication
            int multiplicationResult = calculator.Multiply(num1, num2);
            Console.WriteLine($"{num1} * {num2} = {multiplicationResult}");

            // Division
            try
            {
                double divisionResult = calculator.Divide(num1, num2);
                Console.WriteLine($"{num1} / {num2} = {divisionResult}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

}
    






    
        
    





