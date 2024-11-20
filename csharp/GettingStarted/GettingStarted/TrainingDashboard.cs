
﻿using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using MyExtensionQA;
using TypeSystemDemo;
<<<<<<< HEAD
using BrowserAutomation;
=======
using Assignments_CSharp;
using PetstoreModel;
>>>>>>> 1c55c97 (CSharp Assignments Added)
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
            //this.participants.Aggregate();
            int[] ints = { 1, 2, 3 };
            Console.WriteLine(ints.GetType());
            //ints.
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
            //ExtensionCalls();
            ChromeAutomator chr = new ChromeAutomator();
        }

        private static void DoSomeThing(AbstractClass ins) { }

        private static void ExtensionCalls()
        {
            string name = "Suresh";
            Console.WriteLine(name.Salutations());
            //CodingConventions calculator = new CodingConventions();
            CodingConventions.Subtract(4, 5);
            CodingConventions.Add(9, 11);

            Bike mybike = new Bike();
            mybike.MySpecialBIKE();
<<<<<<< HEAD
=======



            //CSharp Assignment1
            CodingConventions.Subtract(4, 5);
=======
﻿using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using MyExtensionQA;
using TypeSystemDemo;
using Assignments_CSharp;
using PetstoreModel;
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
            //this.participants.Aggregate();
            int[] ints = { 1, 2, 3 };
            Console.WriteLine(ints.GetType());
            //ints.
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
            string name = "Suresh";
            Console.WriteLine(name.Salutations());
            //CodingConventions calculator = new CodingConventions();
            CodingConventions.Subtract(4, 5);
            CodingConventions.Add(9, 11);

            Bike mybike = new Bike();
            mybike.MySpecialBIKE();



            //CSharp Assignment1
            CodingConventions.Subtract(4, 5);
>>>>>>> d8bcecc (CSharp Tasks Added)
            CodingConventions.Add(9, 11);


            //CSharp Assignment2
            //Collections collections = new Collections();

            Collections.DictionaryOperations();
            Collections.StackOperations();
            Collections.QueueOperations();
            Collections.HashSetOperations();
            Collections.SortedSetOperations();
            //CSharp Assignment3
            //Generics and delegates
            // Demonstrating the use of custom delegates and Func delegates
            Console.WriteLine("Demonstrating Delegate and Func Examples:");

            // Calling the DelegateExample method
            GenericsAndDelegates.DelegateExample();

            // Calling the FuncDelegateExample method
            GenericsAndDelegates.FuncDelegateExample();

            // Calling the second FuncDelegateExample method
            GenericsAndDelegates.FuncDelegateExample2();

            //NugetJson
            // Create a new Person object
            var person = new NugetJson.Person("John Doe", 30, "New York");

            // Serialize the Person object to a JSON string
            string jsonString = NugetJson.SerializeObjectToJson(person);
            Console.WriteLine("Serialized JSON String:");
            Console.WriteLine(jsonString);

            // Define the file path where the JSON will be saved
            string filePath = "person.json";

            // Write the JSON string to the file
            NugetJson.WriteJsonToFile(jsonString, filePath);
            Console.WriteLine($"\nJSON written to file: {filePath}");

            // Read the JSON string from the file
            string jsonFromFile = NugetJson.ReadJsonFromFile(filePath);
            Console.WriteLine($"\nRead JSON from file:");
            Console.WriteLine(jsonFromFile);

            // Deserialize the JSON string back to a Person object
            var deserializedPerson = NugetJson.DeserializeJsonToObject(jsonFromFile);
            Console.WriteLine("\nDeserialized Person Object:");
            Console.WriteLine($"Name: {deserializedPerson.Name}");
            Console.WriteLine($"Age: {deserializedPerson.Age}");
            Console.WriteLine($"City: {deserializedPerson.City}");


            //oops
            // 1. Abstract Classes and Methods Example
            Console.WriteLine("1. Animal Example:");
            Animal dog = new Dog("Buddy");
            dog.Speak();  // Calls the overridden Speak method in Dog

            // 2. Inheritance Mechanism Example
            Console.WriteLine("\n2. Shape Example:");
            Shape shape = new Shape();
            shape.Draw();  // Calls base class Draw
            Circle circle = new Circle();
            circle.Draw();  // Calls overridden Draw in Circle

            // 3. Generics Example
            Console.WriteLine("\n3. GenericClass Example:");
            var genericInt = new GenericClass<int>(42);
            Console.WriteLine($"Generic value: {genericInt.GetValue()}");

            var genericString = new GenericClass<string>("Hello Generics");
            Console.WriteLine($"Generic value: {genericString.GetValue()}");

            var simpleClass = new SimpleClass();
            simpleClass.Print("This is a generic print test.");

            // 4. Interface Example
            Console.WriteLine("\n4. Interface Example:");
            Person1 person1 = new Person1 { Name = "Alice", Age = 30 };
            Person1 person2 = new Person1 { Name = "Bob", Age = 25 };

            Console.WriteLine($"Comparison result (Alice vs Bob): {person1.CompareTo(person2)}");

            // IDisposable Example
            Console.WriteLine("\n5. IDisposable Example:");
            ResourceExample resourceExample = new ResourceExample();
            resourceExample.UseResource();  // Uses IDisposable to handle the resource

            // 6. Extension Methods Example
            Console.WriteLine("\n6. Extension Methods Example:");
            string testString = "hello";
            Console.WriteLine(testString.FirstAndLastHypenated());  // Extension method for string

            Console.WriteLine(person1.FirstAndLastHypenated());  // Extensio




<<<<<<< HEAD
>>>>>>> 1c55c97 (CSharp Assignments Added)
        }

        private static void Operators()
        {
            //OperatorsIndexers();
            var c = new Counter();
            c.ThresholdReached += c_ThresholdReached;
            c.ThresholdReached += another_ThresholdReached;
            Console.WriteLine("The Event Mechanism");
            c.FireEvent();

            int? number = null;
            //int another = null;
            float r1 = 1.234f;
            string mystr = "Todays Dates is" + DateTime.Now;
            string mystrinter = $"Todays Dates is {DateTime.Now}";
        }

        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
            Console.WriteLine(e.TimeReached);
            Console.WriteLine(e.Threshold);
        }
        static void another_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold was reached again.");
            Console.WriteLine(e.TimeReached);
            Console.WriteLine(e.Threshold);
        }

        private static void OperatorsIndexers()
        {
            //LambdaDemo();
            FormattedName first = new FormattedName("User1");
            FormattedName sec = new FormattedName("User2");
            FormattedName res = first + sec;

            Console.WriteLine(first);
            Console.WriteLine(sec);
            Console.WriteLine(res);
            DashBoard dashboard = new DashBoard();
            Participants thirdpart = dashboard[2];
            foreach (var item in dashboard)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(thirdpart);
        }

        private static void LambdaDemo()
        {
            GettingStartedDelegate myref = mymethod;
            Action myactionref = mymethod;
            Action mylambdaaction = () => { Console.WriteLine("This is a lambda method method to demo"); };
            MyIntDelegate myintref = SomeMethod;
            Func<int, int> myfunc = SomeMethod;
            Func<int> mylambdafunc = () => 100;
            //myref();
            mylambdaaction();
            Console.WriteLine(mylambdafunc());
            mylambdafunc();

            int[] numbers = { 1, 2, 3, 4, 5 };
            int added = numbers.Aggregate((x, y) => x + y);
            int multipled = numbers.Aggregate((x, y) => x * y);
            int adddoubled = numbers.Aggregate((x, y) => (x + y) * 2);
            Console.WriteLine(multipled);
            Console.WriteLine(added);
            Console.WriteLine(adddoubled);
            //numbers.
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
=======
        }

        private static void Operators()
        {
            //OperatorsIndexers();
            var c = new Counter();
            c.ThresholdReached += c_ThresholdReached;
            c.ThresholdReached += another_ThresholdReached;
            Console.WriteLine("The Event Mechanism");
            c.FireEvent();

            int? number = null;
            //int another = null;
            float r1 = 1.234f;
            string mystr = "Todays Dates is" + DateTime.Now;
            string mystrinter = $"Todays Dates is {DateTime.Now}";
        }

        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
            Console.WriteLine(e.TimeReached);
            Console.WriteLine(e.Threshold);
        }
        static void another_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold was reached again.");
            Console.WriteLine(e.TimeReached);
            Console.WriteLine(e.Threshold);
        }

        private static void OperatorsIndexers()
        {
            //LambdaDemo();
            FormattedName first = new FormattedName("User1");
            FormattedName sec = new FormattedName("User2");
            FormattedName res = first + sec;

            Console.WriteLine(first);
            Console.WriteLine(sec);
            Console.WriteLine(res);
            DashBoard dashboard = new DashBoard();
            Participants thirdpart = dashboard[2];
            foreach (var item in dashboard)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(thirdpart);
        }

        private static void LambdaDemo()
        {
            GettingStartedDelegate myref = mymethod;
            Action myactionref = mymethod;
            Action mylambdaaction = () => { Console.WriteLine("This is a lambda method method to demo"); };
            MyIntDelegate myintref = SomeMethod;
            Func<int, int> myfunc = SomeMethod;
            Func<int> mylambdafunc = () => 100;
            //myref();
            mylambdaaction();
            Console.WriteLine(mylambdafunc());
            mylambdafunc();

            int[] numbers = { 1, 2, 3, 4, 5 };
            int added = numbers.Aggregate((x, y) => x + y);
            int multipled = numbers.Aggregate((x, y) => x * y);
            int adddoubled = numbers.Aggregate((x, y) => (x + y) * 2);
            Console.WriteLine(multipled);
            Console.WriteLine(added);
            Console.WriteLine(adddoubled);
            //numbers.
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

