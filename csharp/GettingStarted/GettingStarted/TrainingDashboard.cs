 using System.Reflection.Metadata;
using PetstoreModel;
using TypeSystemDemo;
namespace GettingStarted;
using KeywordLearning;
using ganesh1;
using System.Data.Common;
using static KeywordLearning.Interface1;
using System;

class TrainingDashboard
{
    // Example for structures in C#
    struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point: ({X}, {Y})");
    }
}
public static void Main(string[] args)
    {
        class_keyword ck = new class_keyword();
        ck.display();
        ck.calculate();

        var abd =  new Square1(12);
        Console.WriteLine($"Area of the square = {abd.GetArea()}");
        datatypesdemo dtd= new datatypesdemo();
        dtd.disp();
        conditionsdemo cd=new conditionsdemo();
        cd.display();
        Dog myDog = new Dog("Buddy");

        // Calling methods
        myDog.DisplayInfo();      // Calls method from Animal class
        myDog.MakeSound();        // Calls overridden method in Dog class
        myDog.Fetch();            // Calls method specific to

        sizedemo sd = new KeywordLearning.sizedemo();
        sd.display();

        trycatch_Exceptions tce = new trycatch_Exceptions();
        tce.display();
        Interface1 id1 = new MyDog();
        Interface1 id2 = new Cat();
        Console.WriteLine("Dog:");
        id1.MakeSound();  // Calls Dog's MakeSound method
        id1.Move();       // Calls Dog's Move method

        Console.WriteLine("\nCat:");
        id2.MakeSound();  // Calls Cat's MakeSound method
        id2.Move();       // Calls Cat's Move method

       

        // Create an instance of the structure Point
        Point p1 = new Point(5, 10);

        // Call the method Display on the structure instance
        p1.Display();  // Output: Point: (5, 10)

        enumdemo person1 = new enumdemo("John Doe", Status.Active);
        enumdemo person2 = new enumdemo("Jane Smith", Status.Inactive);

        // Display information
        person1.DisplayInfo();
        person2.DisplayInfo();

        // program for delegate type
        // Create instances of Calculator and MathOperations
        Calculator calc = new Calculator();

        // Create a delegate that points to the Square method
        delegatedemo.OperationDelegate del = new delegatedemo.OperationDelegate(calc.Square);
        calc.PerformOperation(del, 5);  // Output: Result: 25

        // Reassign the delegate to point to the Double method
        del = new delegatedemo.OperationDelegate(calc.Double);
        calc.PerformOperation(del, 5);  // Output: Result: 10

        // Reassign the delegate to point to the Cube method
        del = new delegatedemo.OperationDelegate(calc.Cube);
        calc.PerformOperation(del, 5);  // Output: Result: 125





    }
}




















//    delegate void GettingStartedDelegate();
//    delegate int MyIntDelegate(int x);
//   /// <summary>
//   /// This is a class to represent training reports 
//   /// </summary>
//    internal class TrainingDashboard
//    {
//        // Fields
//        string _title;
//        string _description;
//        DateTime _current_date;
//        string participants;
//        //Participant[] tr_participants;

//        // Operation
//        /// <summary>
//        /// 
//        /// </summary>
//        public void Publish() {
//            Console.WriteLine("This is the Data for Dashboard");
//        }

//        public TrainingDashboard(string title, string desc, string participants)
//        {
//            this._title = title;
//            this._description = desc;
//            this.participants = participants;
//            //foreach (string item in participants.Split(","))
//            //{
//            //    this.participants.Append(item);
//            //}



//        }

//<<<<<<< HEAD
//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="title"></param>
//        /// <param name="desc"></param>
//        /// <param name="participants"></param>
//        public void Populate(string title, string desc, string participants) { }
//        static void Main(string[] args)
//        {
//            GettingStartedDelegate myref = mymethod;
//            Action myactionref = mymethod;
//            Action mylambdaaction = () => { Console.WriteLine("This is a lambda method method to demo"); };
//            MyIntDelegate myintref = SomeMethod;
//            Func<int,int> myfunc = SomeMethod;
//            Func<int> mylambdafunc = () => 100;
//            //myref();
//            mylambdaaction();
//            Console.WriteLine(mylambdafunc());
//            mylambdafunc();

//            int[] numbers = { 1, 2, 3, 4, 5 };
//            int added = numbers.Aggregate((x,y)=> x + y);
//            int multipled = numbers.Aggregate((x, y) => x * y);
//            int adddoubled = numbers.Aggregate((x, y) => (x + y) * 2);
//            Console.WriteLine(multipled);
//            Console.WriteLine(added);
//            Console.WriteLine(adddoubled);
//            numbers.
//        }

//        private static void SomeOtherMethod() {
//            Console.WriteLine("Doing some other complext operation");
//        }

//        private static int add(int a, int b) {
//            return a + b;
//        }

//        private static void PerformThis(GettingStartedDelegate x) {
//            Console.WriteLine("Going to perform the required Operation");
//            x();
//        }

//        private static int SomeMethod(int arh1) {
//            Console.WriteLine($"This is inside my Int Method {arh1}");
//            return 0; }

//        private static void mymethod() {
//            Console.WriteLine("This is a Method Returning Void Taking Nothing");
//        }

//        private static void Interface_Demo()
//        {
//            // Name + number of arguments + types of arguments
//            //dashboard_demo();
//            //User suresh = new User();
//            Console.WriteLine("Welcome to Programming");
//            ClassDemo myclass = new ClassDemo(1, "suresh");
//            Console.WriteLine(myclass);
//            int[] numbers = { 10, 12, 3, 0, 9, 25 };
//            Array.Sort(numbers);
//            foreach (var item in numbers)
//            {
//                Console.WriteLine(item);
//            }
//            ClassDemo[] myTypes = { new ClassDemo(1, "A"), new ClassDemo(5, "Five"), new ClassDemo(2, "two") };
//            Array.Sort(myTypes);
//            foreach (var item in myTypes)
//            {
//                Console.WriteLine(item);
//            }
//        }


//        static void Interface_Demo(string arg1) { }
//        static void Interface_Demo(int arg1) { }

//        //int Interface_Demo(string arg1) { }

//        private static void dashboard_demo()
//        {
            
//            string trainername = "Suresh Nanjan";
//            Console.WriteLine("Hello, World!");
//            TrainingDashboard automationTraining = new TrainingDashboard("", "", "");
//            //automationTraining.Populate()
//            //automationTraining.Publish();

//            // A collection of Moving Objects
//            IMove[] movingobjects = { new Car(), new Bird(), new Bike() };
//            MoveObjects(movingobjects);

//            int num1 = 10;
//            int num2 = 11;
//            ClassDemo cl1 = new ClassDemo(1, "one");
//            ClassDemo cl2 = new ClassDemo(2, "two");
//            DayOfWeek dayofWeek = DayOfWeek.Sunday;


//=======
//        public void Populate() {
//            Console.WriteLine(_title+" "+ _description+" "+participants);
        
//        }
//        static void Main(string[] args)
//        {
//            string md="Ganesh Rao";
//            Console.WriteLine("Hello, World!");
//            TrainingDashboard automationTraining = new TrainingDashboard("training", "job", md);
//            automationTraining.Populate();
//            automationTraining.Publish();
//>>>>>>> 0a7223b (files added)
//        }

//        private static void MoveObjects(IMove[] movingobjects)
//        {
//            foreach (var item in movingobjects)
//            {
//                item.Move();
//            }
//        }

        
        
//        }

        

