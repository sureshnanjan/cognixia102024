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


using System;
using System.Reflection.Metadata;
using KeywordLearning;
using KeywordLearning.Assignment;
using Microsoft.VisualBasic;
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
        static void Main(string[] args)
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

            //collections
            //CollectionDemo collection = new CollectionDemo();
            CollectionDemo.Demo();

            //prgram-1
            Console.WriteLine("-----Program1-----");
            GreetingService greetingService = new GreetingService();
            // Get a greeting message.
            string message = greetingService.GetGreetingMessage("Vijay");
            Console.WriteLine(message);

            //program-2
            Console.WriteLine("-----Program2-----");
            var collectionOps = new CollectionOperations();
            // Perform CRUD operations on Dictionary
            Console.WriteLine("Dictionary CRUD Operations:");
            collectionOps.DictionaryCRUD();
            Console.WriteLine();
            // Perform CRUD operations on Stack
            Console.WriteLine("Stack CRUD Operations:");
            collectionOps.StackCRUD();
            Console.WriteLine();
            // Perform CRUD operations on Queue
            Console.WriteLine("Queue CRUD Operations:");
            collectionOps.QueueCRUD();
            Console.WriteLine();
            // Perform CRUD operations on Set
            Console.WriteLine("Set CRUD Operations:");
            collectionOps.SetCRUD();
            Console.WriteLine();
            // Perform CRUD operations on SortedSet
            Console.WriteLine("SortedSet CRUD Operations:");
            collectionOps.SortedSetCRUD();

            //program-3
            Console.WriteLine("-----Program3-----");
            DelegateMethods methods = new DelegateMethods();
            // Assigning a method that matches MyFirstDelegate (returns bool)
            DelegateMethods.MyFirstDelegate firstDelegate = methods.CompareSums;
            bool result1 = firstDelegate(5, 10, 2.5f, 3.5f);  // Should return true or false
            Console.WriteLine("Result of firstDelegate: " + result1);
            // Assigning a method that matches MySecondDelegate (returns string)
            DelegateMethods.MySecondDelegate secondDelegate = methods.FormatResult;
            string result2 = secondDelegate(5, 2.5f);  // Should return a formatted string
            Console.WriteLine("Result of secondDelegate: " + result2);
            // Example using Action and Func delegates
            Action<int, int, float, float> actionDelegate = methods.CompareSumsAction;
            Func<int, float, string> funcDelegate = methods.FormatResultFunc;
            // Invoke Action and Func delegates
            actionDelegate(5, 10, 2.5f, 3.5f);
            Console.WriteLine(funcDelegate(5, 2.5f));

            //program-4
            Console.WriteLine("-----Program4-----");
            var person = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30
            };
            // Serialize the object to a JSON string
            string jsonString = JsonConvert.SerializeObject(person, Formatting.Indented);
            Console.WriteLine("Serialized JSON:\n"+jsonString);
            // Write the JSON string to a file
            string filePath = "person.json";
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine($"\nJSON data written to file: {filePath}");
            // Read the JSON string from the file
            string jsonFromFile = File.ReadAllText(filePath);
            Console.WriteLine($"\nJSON data read from file:\n{jsonFromFile}");
            // Deserialize the JSON string back into a Person object
            var deserializedPerson = JsonConvert.DeserializeObject<Person>(jsonFromFile);
            Console.WriteLine($"\nDeserialized Object:\n{deserializedPerson.FirstName} {deserializedPerson.LastName}, Age: {deserializedPerson.Age}");


            //program-5
            Console.WriteLine("-----Program5-----");
            try
            {
                // Abstract Class Example
                Shape circle = new Circle(5);
                circle.Display();
                Console.WriteLine("Area of Circle: " + circle.CalculateArea());
                Shape rectangle = new Rectangle(4, 7);
                rectangle.Display();
                Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());
                // Base, Virtual, and Override Keywords Example
                Animal animal = new Dog();
                animal.MakeSound();
                // Using IDisposable
                using (var fileHandler = new FileHandler("example.txt"))
                {
                    fileHandler.WriteData("This is a sample text.");
                }
                // Array.Sort Example
                int[] myNumbers = { 3, 6, 1, 8, 4 };
                Array.Sort(myNumbers, CompareDescending);
                Console.WriteLine("Sorted Array in Descending: " + string.Join(", ", myNumbers));
                // IComparable and Custom Interface
                var employees = new List<Employee>
                {
                    new Employee { Name = "John", Salary = 50000 },
                    new Employee { Name = "Jane", Salary = 60000 },
                    new Employee { Name = "Alice", Salary = 45000 }
                };
                employees.Sort();
                Console.WriteLine("Sorted Employees by Salary:");
                foreach (var employee in employees)
                {
                    Console.WriteLine($"{employee.Name} - ${employee.Salary}");
                }
                // Extension Methods
                string word = "Programming";
                Console.WriteLine(word.FirstAndLastHyphenated());
                Employee emp = new Employee { Name = "Sarah", Salary = 70000 };
                Console.WriteLine(emp.FirstAndLastHyphenated());
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            //program-6
            Console.WriteLine("-----Program6-----");
            SysFeatures.execute();

            //program-7
            Console.WriteLine("-----Program7-----");
            // Create a Training instance
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
                ParticipantsList = new List<string> { "vijay", "vj", "Vijay kumar" }
            };
            // Display the training details
            training.DisplayDetails();

            //program-8
            Console.WriteLine("-----Program8-----");
            // Demonstrate pass by value
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
            Program.DisplaySquare(constantValue); // Pass using 'in'



        }

        static int CompareDescending(int x, int y)
        {
            return y.CompareTo(x);

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
