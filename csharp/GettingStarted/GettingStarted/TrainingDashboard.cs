
using static KeywordLearning.class_keyword;
using Generic;

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
            //demo.ShowMessage();
            //demo.DisplayInfo();


            //TrainingDashboard dashboard = new TrainingDashboard("", "", "");
            //dashboard.Publish();  // Call the Publish method to display training info


            //demo.SwitchCaseEx(2);
            //demo.GotoExample();
            //demo.FinallyExample();


            //Levels lev = Levels.Low;
            //Console.WriteLine($"Level is: {lev}");

            //demo.MessageReceived += message => Console.WriteLine($"Message received: {message}");
            //demo.TriggerEvent("Hello from the event!");

            //Console.WriteLine("Main method completed.");


        }

    



    }


}
