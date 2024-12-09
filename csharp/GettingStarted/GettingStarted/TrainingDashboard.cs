/*
Licensed to the Software Freedom Conservancy (SFC) under one
or more contributor license agreements. See the NOTICE file
distributed with this work for additional information
regarding copyright ownership. The SFC licenses this file
to you under the Apache License, Version 2.0 (the
"License"); you may not use this file except in compliance
with the License. You may obtain a copy of the License at
 
  http://www.apache.org/licenses/LICENSE-2.0
 
Unless required by applicable law or agreed to in writing,
software distributed under the License is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the
specific language governing permissions and limitations
under the License.
*/

using System.Reflection.Metadata;
using BrowserAutomation;
using KeywordLearning;
using Newtonsoft.Json;
using PetstoreModel;
using TypeSystemDemo;
namespace GettingStarted
{
    delegate void GettingStartedDelegate();
    delegate int MyIntDelegate(int x);
   /// <summary>
   /// This is a class to represent training reports 
   /// </summary>
    internal class TrainingDashboard
    {
        // Fields
        string _title;
        string _description;
        DateTime _current_date;
        string[] participants;
        Participant[] tr_participants;

        // Operation
        /// <summary>
        /// 
        /// </summary>
        public void Publish() {
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
        public void Populate(string title, string desc, string participants) { }
        static void programs()
        {
            GettingStartedDelegate myref = mymethod;
            Action myactionref = mymethod;
            Action mylambdaaction = () => { Console.WriteLine("This is a lambda method method to demo"); };
            MyIntDelegate myintref = SomeMethod;
            Func<int,int> myfunc = SomeMethod;
            Func<int> mylambdafunc = () => 100;
            //myref();
            mylambdaaction();
            Console.WriteLine(mylambdafunc());
            mylambdafunc();

            int[] numbers = { 1, 2, 3, 4, 5 };
            int added = numbers.Aggregate((x,y)=> x + y);
            int multipled = numbers.Aggregate((x, y) => x * y);
            int adddoubled = numbers.Aggregate((x, y) => (x + y) * 2);
            Console.WriteLine(multipled);
            Console.WriteLine(added);
            Console.WriteLine(adddoubled);
            //numbers.

            ListExample listExample = new ListExample();
            listExample.Demo();

            DictionaryExample dictionaryExample = new DictionaryExample();
            dictionaryExample.Demo();

            QueueExample queueExample = new QueueExample();
            queueExample.Demo();

            StackExample stackExample = new StackExample();
            stackExample.Demo();

            HashSetExample hashSetExample = new HashSetExample();
            hashSetExample.Demo();

            LinkedListExample linkedListExample = new LinkedListExample();
            linkedListExample.Demo();

            PriorityQueueExample priorityQueueExample = new PriorityQueueExample();
            priorityQueueExample.Demo();

            //program1
            Console.WriteLine("\nProgram-1\n");
            Console.WriteLine("\nWelcome to the console Application!");
            var greetingService = new GreetingService();
            string greetingMessage = greetingService.GetGreetingMessage("Athesh");
            Console.WriteLine(greetingMessage);
            Console.WriteLine("What is your favorite programming language?");
            string favoriteLanguage = Console.ReadLine();
            string responseMessage = greetingService.GetLanguageResponse(favoriteLanguage);
            Console.WriteLine(responseMessage);

            //program2
            Console.WriteLine("\nProgram-2\n");
            Curd curd = new Curd();
            // Dictionary CRUD Operations
            Console.WriteLine("Dictionary Operations:");
            curd.DictionaryEx();

            // Stack CRUD Operations
            Console.WriteLine("\nStack Operations:");
            curd.StackEx();

            // Queue CRUD Operations
            Console.WriteLine("\nQueue Operations:");
            curd.QueueEx();

            // HashSet CRUD Operations
            Console.WriteLine("\nHashSet Operations:");
            curd.SetEx();

            // SortedSet CRUD Operations
            Console.WriteLine("\nSortedSet Operations:");
            curd.SortedSetEx();

            //program-3
            Console.WriteLine("\nprogram-3\n");

            Console.WriteLine("Using Custom Delegates:");
            bool customResult = CustomDelegates.CompareValues(10, 20, 15.5f, 25.3f);
            Console.WriteLine($"Custom Delegate Comparison Result: {customResult}");

            string customFormattedString = CustomDelegates.FormatValues(42, 3.14f);
            Console.WriteLine($"Custom Delegate Formatted String: {customFormattedString}");

            // Predefined Func delegate usage
            Console.WriteLine("\nUsing Predefined Func Delegates:");
            bool funcResult = PredefinedDelegates.FuncCompare(50, 30, 12.7f, 18.9f);
            Console.WriteLine($"Func Delegate Comparison Result: {funcResult}");

            string funcFormattedString = PredefinedDelegates.FuncFormat(7, 2.71f);
            Console.WriteLine($"Func Delegate Formatted String: {funcFormattedString}");

            //program-4
            

            var person = new Person
            {
                Name = "John Doe",
                Age = 30,
                Email = "johndoe@example.com"
            };

            Console.WriteLine("\nProgram-4\n");

            // Serialize the object to a JSON string
            string jsonString = JsonConvert.SerializeObject(person, Formatting.Indented);
            Console.WriteLine("Serialized JSON String:\n" + jsonString);

            // Define file path
            string filePath = "person.json";

            // Write JSON string to a file
            FileOperations.WriteToFile(filePath, jsonString);
            Console.WriteLine($"\nJSON string written to file: {filePath}");

            // Read JSON string from the file
            string fileContent = FileOperations.ReadFromFile(filePath);
            Console.WriteLine("\nContent Read from File:\n" + fileContent);

            // Deserialize the JSON string back to an object
            var deserializedPerson = JsonConvert.DeserializeObject<Person>(fileContent);
            Console.WriteLine($"\nDeserialized Object:\nName: {deserializedPerson.Name}, Age: {deserializedPerson.Age}, Email: {deserializedPerson.Email}");

            //program-5
            Console.WriteLine("\nprogram-5\n");
                Console.WriteLine("Running Abstract Classes:");
                Exercises.RunAbstractClassesEx();

                Console.WriteLine("\nRunning Inheritance:");
                Exercises.RunInheritanceEx();

                Console.WriteLine("\nRunning Generics Methods:");
                Exercises.RunGenericsMethodsEx();

                Console.WriteLine("\nRunning Array Sort:");
                Exercises.RunArraySortEx();

                Console.WriteLine("\nRunning Interface:");
                Exercises.RunInterfaceEx();

                Console.WriteLine("\nRunning Extension Methods:");
                Exercises.RunExtensionMethodsEx();

            //program-6
            Console.WriteLine("\nprogram-6\n");
            SystemFeatures.execute();

            //program-7
            Console.WriteLine("\nprogram-7\n");
            Training training = new Training
            {
                TrainingName = "C# Basics / Web Development / Cloud",
                Trainer = "Suresh Nanjan",
                Duration = 16,
                FromDate = new DateTime(2024, 2, 15),
                EndDate = new DateTime(2024, 3, 9),
                Participants = 20,
                Topics = new List<string> { "C#", "Docker", "Jenkins", "WebDriver" },
                ToolsUsed = new List<string> { "MS Teams", "Google Classroom" },
                ParticipantsList = new List<string> { "athesh", "nishant", "Vijay kumar" }
            };
            // Display the training details
            training.DisplayDetails();

            //program-8
            Console.WriteLine("\nprogram-8\n");
            int valNumber = 5;
            Console.WriteLine($"Before squareVal: {valNumber}");
            Program.squareVal(valNumber); // Pass by value
            Console.WriteLine($"After squareVal: {valNumber}");
            // Demonstrate pass by reference
            int refNumber = 5;
            Console.WriteLine($"\nBefore squareRef: {refNumber}");
            Program.squareRef(ref refNumber); // Pass by reference
            Console.WriteLine($"After squareRef: {refNumber}");
            // Demonstrate 'out' keyword
            int x = 4, y = 6, result;
            Program.MultiplyOut(x, y, out result); // Pass using 'out'
            Console.WriteLine($"\nMultiplication using out: {x} * {y} = {result}");
            // Demonstrate 'in' keyword
            int constantValue = 7;
            Console.WriteLine($"\nUsing in keyword:");
            Program.DisplaySquare(constantValue);


            
        }

        static void Main(string[] args)
        {
            //Assignment
            //programs();


            //ExtensionCalls();
            ChromeAutomator chr = new ChromeAutomator();
        }

        private static void SomeOtherMethod() {
            Console.WriteLine("Doing some other complext operation");
        }

        private static int add(int a, int b) {
            return a + b;
        }

        private static void PerformThis(GettingStartedDelegate x) {
            Console.WriteLine("Going to perform the required Operation");
            x();
        }

        private static int SomeMethod(int arh1) {
            Console.WriteLine($"This is inside my Int Method {arh1}");
            return 0; }

        private static void mymethod() {
            Console.WriteLine("This is a Method Returning Void Taking Nothing");
        }

        private static void Interface_Demo()
        {
            // Name + number of arguments + types of arguments
            //dashboard_demo();
            //User suresh = new User();
            Console.WriteLine("Welcome to Programming");
            ClassDemo myclass = new ClassDemo(1, "suresh");
            Console.WriteLine(myclass);
            int[] numbers = { 10, 12, 3, 0, 9, 25 };
            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            ClassDemo[] myTypes = { new ClassDemo(1, "A"), new ClassDemo(5, "Five"), new ClassDemo(2, "two") };
            Array.Sort(myTypes);
            foreach (var item in myTypes)
            {
                Console.WriteLine(item);
            }
        }


        static void Interface_Demo(string arg1) { }
        static void Interface_Demo(int arg1) { }

        //int Interface_Demo(string arg1) { }

        private static void dashboard_demo()
        {
            
            string trainername = "Suresh Nanjan";
            Console.WriteLine("Hello, World!");
            TrainingDashboard automationTraining = new TrainingDashboard("", "", "");
            //automationTraining.Populate()
            //automationTraining.Publish();

            // A collection of Moving Objects
            IMove[] movingobjects = { new Car(), new Bird(), new Bike() };
            MoveObjects(movingobjects);

            int num1 = 10;
            int num2 = 11;
            ClassDemo cl1 = new ClassDemo(1, "one");
            ClassDemo cl2 = new ClassDemo(2, "two");
            DayOfWeek dayofWeek = DayOfWeek.Sunday;


        }

        private static void MoveObjects(IMove[] movingobjects)
        {
            foreach (var item in movingobjects)
            {
                item.Move();
            }
        }

        
        
        }

        
}
