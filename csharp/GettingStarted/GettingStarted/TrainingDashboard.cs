<<<<<<< HEAD
﻿using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using PetstoreModel;
using TypeSystemDemo;
=======
﻿/// <summary>
/// This class represents a training reports
/// </summary>
>>>>>>> 627ac15 (resolve)
namespace GettingStarted
{
    internal class TrainingDashboard
    {
        // Fields
        private string _title;
        private string _description;
        private DateTime _currentDate;
        private Participant[] _trParticipants;

        // Constructor that accepts a list of participant names and maps them to Participant objects
        public TrainingDashboard(string title, string desc, string[] participants)
        {
            _title = title;
            _description = desc;
            // Convert string array to Participant array
            _trParticipants = CreateParticipants(participants);
        }

        // Method to convert string array to an array of Participant objects
        private Participant[] CreateParticipants(string[] participants)
        {
            // Placeholder employee code generation, just for this example
            var participantList = new List<Participant>();
            int id = 1;
            foreach (var participant in participants)
            {
                var nameParts = participant.Split(' ');
                // Assuming participant name is "FirstName LastName"
                participantList.Add(new Participant($"E{id++}", nameParts[0], nameParts[1]));
            }
            return participantList.ToArray();
        }

        // Method to publish the dashboard
        public void Publish()
        {
            Console.WriteLine("This is the Data for Dashboard");
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Description: {_description}");
            Console.WriteLine("Participants:");
            foreach (var participant in _trParticipants)
            {
                Console.WriteLine($"- {participant.FirstName} {participant.LastName} (Code: {participant.EmployeeCode})");
            }
        }

        static void Main(string[] args)
        {
<<<<<<< HEAD
            //OperatorsIndexers();
            var c = new Counter();
            c.ThresholdReached += c_ThresholdReached;
            c.ThresholdReached += another_ThresholdReached;
            Console.WriteLine("The Event Mechanism");
            c.FireEvent();

            int? number = null;
            int another = null;
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
=======
<<<<<<< HEAD
>>>>>>> 627ac15 (resolve)
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
=======
            string trainerName = "Suresh Nanjan";
            Console.WriteLine(trainerName);
>>>>>>> 3b5525c (week4)
            Console.WriteLine("Hello, World!");

            // Example participants array (just names in this case)
            string[] participants = { "John Doe", "Jane Smith" };

            // Create an instance of TrainingDashboard with the participants
            TrainingDashboard automationTraining = new TrainingDashboard(
                "Automation Training",
                "Learn how to automate processes",
                participants
            );

            // Publish the training dashboard
            automationTraining.Publish();
        }
    }
}


