using System.Reflection.Metadata;
using PetstoreModel;
using TypeSystemDemo;
using TypeSystemDemo.GettingStarted;
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
        // string[] participants;
        //Participant[] tr_participants;

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
        public void Populate(string title, string desc, string participants) { }
        static void Main(string[] args)
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

            Console.WriteLine("-----this example for Abstract------ ");
            //abstract
            Animal mycat = new cat();
            mycat.sound();
            Animal mydog = new dog();
            mydog.sound();
            Console.WriteLine("----this example for enum----");
            //enum
            weeks workingdays = weeks.Monday | weeks.Tuesday | weeks.Wednesday;
            Console.WriteLine($"workingdays: {workingdays}");
            weeks workfromhome = weeks.Thursday | weeks.Friday;
            Console.WriteLine($"workfromhome: {workfromhome}");
            weeks holidays = weeks.Saturday | weeks.Sunday;
            Console.WriteLine($"Holidays: {holidays}");
            Console.WriteLine("-----this example for interface----");
            //interface
            username id = new username();
            id.Account();
            id.user_details();
            //condition
            Console.WriteLine("------this example for Condition------ \n");
            Condition condition = new Condition();
            condition.CheckIfElse();   
            condition.CheckSwitchCase();  
            condition.CheckTernary();  

            Console.WriteLine("-----this example for delgate-----");
            //delgate 
            Calculator calc = new Calculator();
            
            Operation addOperation = new Operation(calc.Add);
            Console.WriteLine("Addition: " + addOperation(5, 3));

            
            Operation subtractOperation = new Operation(calc.Subtract);
            Console.WriteLine("Subtraction: " + subtractOperation(5, 3));

            
            Operation multiplyOperation = new Operation(calc.Multiply);
            Console.WriteLine("Multiplication: " + multiplyOperation(5, 3));
            Console.WriteLine("Overriding");
            // overriding
            Shape myShape = new Shape();
            Shape myCircle = new Circle();     
            Shape myRectangle = new Rectangle(); 
            myShape.Draw();        
            myCircle.Draw();       
            myRectangle.Draw();
            Console.WriteLine("example for size of");
            // Example for  size of 
            Console.WriteLine("Size of int: " + sizeof(int));     
            Console.WriteLine("Size of float: " + sizeof(float)); 
            Console.WriteLine("Size of double: " + sizeof(double)); 
            Console.WriteLine("Size of char: " + sizeof(char));   
            Console.WriteLine("Size of bool: " + sizeof(bool));   




            // END MAIN FUNCTION

        }
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


        //TrainingDashboard automationTraining = new TrainingDashboard("","","");
        // automationTraining.Populate();
        automationTraining.Publish();

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
