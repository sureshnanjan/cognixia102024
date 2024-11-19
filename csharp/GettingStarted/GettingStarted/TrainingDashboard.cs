using System.Reflection.Metadata;
using KeywordLearning;
using PetstoreModel;
using TypeSystemDemo;
using Learn;
using Assignments;
using BrowserAutomation;
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
            //hi.welcome();
            //GettingStartedDelegate myref = mymethod;
            //Action myactionref = mymethod;
            //Action mylambdaaction = () => { Console.WriteLine("This is a lambda method method to demo"); };
            //MyIntDelegate myintref = SomeMethod;
            //Func<int,int> myfunc = SomeMethod;
            //Func<int> mylambdafunc = () => 100;
            ////myref();
            //mylambdaaction();
            //Console.WriteLine(mylambdafunc());
            //mylambdafunc();

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int added = numbers.Aggregate((x,y)=> x + y);
            //int multipled = numbers.Aggregate((x, y) => x * y);
            //int adddoubled = numbers.Aggregate((x, y) => (x + y) * 2);
            //Console.WriteLine(multipled);
            //Console.WriteLine(added);
            //Console.WriteLine(adddoubled);
            ////delegate
            //Calculator calc = new Calculator();

            //Operation addOperation = new Operation(calc.Add);
            //Console.WriteLine("Addition: " + addOperation(5, 3));


            //Operation subtractOperation = new Operation(calc.Subtract);
            //Console.WriteLine("Subtraction: " + subtractOperation(5, 3));


            //Operation multiplyOperation = new Operation(calc.Multiply);
            //Console.WriteLine("Multiplication: " + multiplyOperation(5, 3));

            ////keywords
            //class_keyword.DemonstrateKeywords();
            ////override
            //Shape myShape = new Shape();
            //Shape myCircle = new Circle();
            //Shape myRectangle = new Rectangle();
            //myShape.Draw();
            //myCircle.Draw();
            //myRectangle.Draw();

            ////enum
            //weeks workingdays = weeks.Monday;
            //Console.WriteLine($"workingdays: {workingdays}");
            //weeks workfromhome = weeks.Thursday;
            //Console.WriteLine($"workfromhome: {workfromhome}");
            //weeks holidays = weeks.Saturday;
            //Console.WriteLine($"Holidays: {holidays}");

            ////interface
            //Customer vj = new Customer();
            //vj.customer_details();
            //vj.user_details();

            ////absrtact
            //Console.WriteLine("----Abstract class----");
            //Orange Fruitorg = new Orange();
            //Fruitorg.Shape();
            //PineApple Fruitpine = new PineApple();
            //Fruitpine.Shape();

            ////collections
            //Collections.excuteCollections();

            //Assignments
            //Assignment 1
            //CodingSatandard.NamingConvention();
            //Assignment 2
            //Collection.CollectionMethods();
            //Assignment 3
            //genrics
            //GenricAndDelegate.DemonstrateGenerics();
            //delegates
            //GenricAndDelegate.DemonstrateDelegates();
            //assignment 4 json
            //GetJson.SerializeWrite();
            //assignment 5
            //oops.Demonstrateoops();
            //assignment 6
            //SystemFeatures.execute();
            //assignment 7
            //TrainingDetails train=new TrainingDetails();
            //train.DisplayDetails();
            //assignment 8
            //MethodCalling.execute();
            //to call chrome
            //ChromeAutomator chr = new ChromeAutomator();
            //to call edge
            EdgeAutomator edge = new EdgeAutomator();
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
