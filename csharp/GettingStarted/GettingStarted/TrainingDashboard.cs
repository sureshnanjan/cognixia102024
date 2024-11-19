using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using KeywordLearning;
using PetstoreModel;
using TypeSystemDemo;
using Assignments_Csharp;
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
        public void Publish()
        {
            Console.WriteLine("This is the Data for Dashboard");
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

            //keyword task main method
            Circle circle = new Circle(5);
            Triangle triangle = new Triangle(4, 8);
            circle.DisplayShapeInfo();
            Console.WriteLine("Area: " + circle.CalculateArea());
            triangle.DisplayShapeInfo();
            Console.WriteLine("Area: " + triangle.CalculateArea());

            // Create a list to store integers (or any other type)
            List<int> numbers = new List<int>();

            // CRUD Operations
            Console.WriteLine("Initial list state:");
            ListCollection.ReadList(numbers); // Initially empty

            // 1. Create - Add elements to the list
            Console.WriteLine("\nAdding elements to the list...");
            ListCollection.Create(numbers, 10);
            ListCollection.Create(numbers, 20);
            ListCollection.Create(numbers, 30);
            ListCollection.Create(numbers, 40);
            ListCollection.ReadList(numbers); // Display list

            // 2. Read - Display the current list
            Console.WriteLine("\nReading list elements...");
            ListCollection.ReadList(numbers);

            // 3. Update - Modify an element at a specified index
            Console.WriteLine("\nUpdating element at index 2...");
            ListCollection.Update(numbers, 2, 25); // Update element at index 2
            ListCollection.ReadList(numbers);

            // 4. Delete - Remove an element by value or index
            Console.WriteLine("\nDeleting element with value 20...");
            ListCollection.Delete(numbers, 20); // Delete by value
            ListCollection.ReadList(numbers);
            Console.WriteLine("\nDeleting element at index 0...");
            ListCollection.DeleteAt(numbers, 0); // Delete by index
            ListCollection.ReadList(numbers);

            // Create a dictionary to store integer keys and string values
            Dictionary<int, string> students = new Dictionary<int, string>();

            // CRUD Operations
            Console.WriteLine("Initial dictionary state:");
            DictionaryCollection.ReadDictionary(students); // Initially empty

            // 1. Create - Add elements to the dictionary
            Console.WriteLine("\nAdding elements to the dictionary...");
            DictionaryCollection.Create(students, 1, "Alice");
            DictionaryCollection.Create(students, 2, "Bob");
            DictionaryCollection.Create(students, 3, "Charlie");
            DictionaryCollection.ReadDictionary(students); // Display dictionary

            // 2. Read - Display the current dictionary
            Console.WriteLine("\nReading dictionary elements...");
            DictionaryCollection.ReadDictionary(students);

            // 3. Update - Modify the value for a specific key
            Console.WriteLine("\nUpdating element with key 2...");
            DictionaryCollection.Update(students, 2, "Bobby"); // Update element with key 2
            DictionaryCollection.ReadDictionary(students);

            // 4. Delete - Remove an element by key
            Console.WriteLine("\nDeleting element with key 3...");
            DictionaryCollection.Delete(students, 3); // Delete by key
            DictionaryCollection.ReadDictionary(students);

            //Assignment 1
            CodingConventions.NamingStandards();

            //Assignment 2
            Console.WriteLine("\nCRUD Operations Demonstration");

            // CRUD Operations on Dictionary
            Console.WriteLine("\n----------Dictionary CRUD Operations:----------");
            Collections.DictionaryCRUD();

            // CRUD Operations on Stack
            Console.WriteLine("\n---------Stack CRUD Operations:----------");
            Collections.StackCRUD();

            // CRUD Operations on Queue
            Console.WriteLine("\n---------Queue CRUD Operations:---------");
            Collections.QueueCRUD();

            // CRUD Operations on Set
            Console.WriteLine("\n--------Set CRUD Operations:---------");
            Collections.SetCRUD();

            // CRUD Operations on SortedSet
            Console.WriteLine("\n--------SortedSet CRUD Operations:----------");
            Collections.SortedSetCRUD();

            //Assignment 3
            Calculator<int>.GenericsCall();
            Delegates.DelegateCall();

            //Assignment 4
            NuGetJson.GetJson();

            //Assignment 5
            Oops.AbstractMethod();
            ArraySort.SortMethod11();
            ArraySort.SortMethod12();
            ArraySort.SortMethod13();
            ArraySort.SortMethod14();

            //Assignmet 7
            DataTypes.DataTypeCall();

            //Assignment 8
            MethodCallingConventions.MethodCall();

            //Assignment 6
            Features.SystemConsole();
            Features.FileCreate();



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

        //     }

        //     /// <summary>
        //     /// 
        //     /// </summary>
        //     /// <param name="title"></param>
        //     /// <param name="desc"></param>
        //     /// <param name="participants"></param>
        //     public void Populate(string title, string desc, string participants) { }
        //     static void Main(string[] args)
        //     {
        //         GettingStartedDelegate myref = mymethod;
        //         Action myactionref = mymethod;
        //         Action mylambdaaction = () => { Console.WriteLine("This is a lambda method method to demo"); };
        //         MyIntDelegate myintref = SomeMethod;
        //         Func<int,int> myfunc = SomeMethod;
        //         Func<int> mylambdafunc = () => 100;
        //         //myref();
        //         mylambdaaction();
        //         Console.WriteLine(mylambdafunc());
        //         mylambdafunc();

        //         int[] numbers = { 1, 2, 3, 4, 5 };
        //         int added = numbers.Aggregate((x,y)=> x + y);
        //         int multipled = numbers.Aggregate((x, y) => x * y);
        //         int adddoubled = numbers.Aggregate((x, y) => (x + y) * 2);
        //         Console.WriteLine(multipled);
        //         Console.WriteLine(added);
        //         Console.WriteLine(adddoubled);
        //         //numbers.
        //     }

        private static void SomeOtherMethod()
        {
            Console.WriteLine("Doing some other complext operation");
        }

        private static int add(int a, int b)
        {
            return a + b;
        }

        private static void PerformThis(GettingStartedDelegate x)
        {
            Console.WriteLine("Going to perform the required Operation");
            x();
        }

        private static int SomeMethod(int arh1)
        {
            Console.WriteLine($"This is inside my Int Method {arh1}");
            return 0;
        }

        private static void mymethod()
        {
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
            //TrainingDashboard automationTraining = new TrainingDashboard("", "", "");
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
