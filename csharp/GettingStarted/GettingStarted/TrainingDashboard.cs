<<<<<<< HEAD
﻿using System.Reflection.Metadata;
using PetstoreModel;
using TypeSystemDemo;
namespace GettingStarted
{
    delegate void GettingStartedDelegate();
    delegate int MyIntDelegate(int x);
=======
﻿namespace GettingStarted
{
>>>>>>> 48fe5fffc6e46224a6ee23d1f54ad30da99a4b49
   /// <summary>
   /// This is a class to represent training reports 
   /// </summary>
    internal class TrainingDashboard
    {
        // Fields
        string _title = "Something";
        string _description = "Something";
        DateTime _current_date = DateTime.Now;
        string[] participants = { "12", "32", "43", "35", "67","79", "10" };
        Participant[] tr_participants;

        // Operation
<<<<<<< HEAD
        /// <summary>
        /// 
        /// </summary>
=======
>>>>>>> 48fe5fffc6e46224a6ee23d1f54ad30da99a4b49
        public void Publish() {
            Console.WriteLine("This is the Data for Dashboard");
        }

        public TrainingDashboard(string title, string desc, string participants)
        {
            this._title = title;
            this._description = desc;
            this.tr_participants = new Participant[participants.Split(',').Length]; ;
            foreach (var item in participants.Split(","))
            {
                //this.participants.Append(item);
            }
            

        }

        public void Populate(string title, string desc, string participants) 
        {
            this._title = title;
            this._description = desc;
            this.participants = participants.Split(',');
        }
        static void Main(string[] args)
        {
<<<<<<< HEAD
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
            
=======
>>>>>>> 48fe5fffc6e46224a6ee23d1f54ad30da99a4b49
            string trainername = "Suresh Nanjan";
            Console.WriteLine("Hello!! "+trainername);
            TrainingDashboard automationTraining = new TrainingDashboard("","","");
            automationTraining.Populate("","","");
            automationTraining.Publish();
        }
    }
}