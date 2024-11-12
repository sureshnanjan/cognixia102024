using System.Reflection.Metadata;
using PetstoreModel;
using TypeSystemDemo;
using System;
using KeywordLearning;
using static KeywordLearning.class_keyword;
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

            ClassKeyword demo = new ClassKeyword();
            demo.ShowMessage();
            demo.DisplayInfo();


            TrainingDashboard dashboard = new TrainingDashboard("", "", "");
            dashboard.Publish();  // Call the Publish method to display training info


            demo.SwitchCaseEx(2);
            demo.GotoExample();
            demo.FinallyExample();


            Levels lev = Levels.Low;
            Console.WriteLine($"Level is: {lev}");

            demo.MessageReceived += message => Console.WriteLine($"Message received: {message}");
            demo.TriggerEvent("Hello from the event!");

            Console.WriteLine("Main method completed.");

        }

        //private static void SomeOtherMethod() {
        //    Console.WriteLine("Doing some other complext operation");
        //}

        //private static int add(int a, int b) {
        //    return a + b;
        //}

        //private static void PerformThis(GettingStartedDelegate x) {
        //    Console.WriteLine("Going to perform the required Operation");
        //    x();
        //}

        //private static int SomeMethod(int arh1) {
        //    Console.WriteLine($"This is inside my Int Method {arh1}");
        //    return 0; }

        //private static void mymethod() {
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





    }


}
