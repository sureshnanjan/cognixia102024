
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
*/using System.Reflection.Metadata;
using KeywordLearning;
using Microsoft.VisualBasic;
using PetstoreModel;
using TypeSystemDemo;
using static KeywordLearning.Program;
using Newtonsoft.Json;

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
        public static void Main(string[] args)
        {
            //GettingStartedDelegate myref = mymethod;
            //Action myactionref = mymethod;
            //Action mylambdaaction = () => { Console.WriteLine("This is a lambda method method to demo"); };
            //MyIntDelegate myintref = SomeMethod;
            //Func<int, int> myfunc = SomeMethod;
            //Func<int> mylambdafunc = () => 100;
            ////myref();
            //mylambdaaction();
            //// Console.WriteLine(mylambdafunc());
            //mylambdafunc();

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int added = numbers.Aggregate((x, y) => x + y);
            //int multipled = numbers.Aggregate((x, y) => x * y);
            //int adddoubled = numbers.Aggregate((x, y) => (x + y) * 2);
            //Console.WriteLine(multipled);
            //Console.WriteLine(added);
            //Console.WriteLine(adddoubled);
            //numbers.

            //collection
            //assignament 1
            collection.demo();
            //c# problem
            //assignament 2
            Program.problem();
            Program.problem1();
            Program.DisplayEnvironment();
            //assignament 3
            // No arguments: Using default values
            Program.SimpleMethod();
            //assignament 4
            // Positional arguments followed by a sequence of remaining arguments
            Program.SimpleMethod(42, "Hello", false, "Extra1", "Extra2", "Extra3");

            // Calling by Named Parameter convention
            Program.SimpleMethod(str: "New Value", number: 999);
            // Call the method with two integers
            var result1 = Program.addNumbers(0, 0);

            // Call the method with two floats
            var result2 = Program.addNumbers(1.0f, 1.0f);

            // Call the method with two doubles
            var result3 = Program.addNumbers(1.0, 1.0);

            // Call the method with an int and a float
            var result4 = Program.addNumbers(1, 1.0f);

            // Call the method with a float and an int
            var result5 = Program.addNumbers(1.0f, 1);

            // Call the method with two floats and an additional string
            var result6 = Program.addNumbers(1.0f, 1.0f, "This is with additional inputs");
            
            // Test values
            int num1 = 4;
            int num2 = 4;

            // Calling the squareVal method (pass by value)
            Console.WriteLine($"Before squareVal: num1 = {num1}");
            Program.squareVal(num1);  // num1 is passed by value, so it won't be modified
            Console.WriteLine($"After squareVal: num1 = {num1}");

            // Calling the squareRef method (pass by reference)
            Console.WriteLine($"Before squareRef: num2 = {num2}");
            Program.squareRef(ref num2);  // num2 is passed by reference, so it will be modified
            Console.WriteLine($"After squareRef: num2 = {num2}");
            // Example for 'in'
            int numberIn = 5;
            Console.WriteLine($"Before 'in' method: {numberIn}");
            Program.SquareIn(in numberIn);
            Console.WriteLine($"After 'in' method: {numberIn}");  // 'in' parameters cannot be modified inside the method

            // Example for 'out'
            int numberOut;
            bool success = Program.TryParseInt("123", out numberOut);
            if (success)
            {
                Console.WriteLine($"'out' method returned: {numberOut}");  // 'out' parameter is assigned inside the method
            }
            else
            {
                Console.WriteLine("Failed to parse integer.");
            }
            
            // Example for 'ref'
            int numberRef = 10;
            Console.WriteLine($"Before 'ref' method: {numberRef}");
            Program.DoubleValue(ref numberRef);
            Console.WriteLine($"After 'ref' method: {numberRef}");  // 'ref' parameter can be modified inside the method

            Console.WriteLine("Welcome to the BookStore Application!");

            // Create an instance of the BookStoreCalculator class
            var calculator = new BookStoreCalculator();

            // Example of calculating the total price for a cart of books
            var books = new Book[]
            {
                new Book("The Great Gatsby", 10.99m),
                new Book("1984", 8.99m),
                new Book("To Kill a Mockingbird", 12.50m)
            };

            decimal totalPrice = calculator.CalculateTotalPrice(books);
            Console.WriteLine($"The total price of the books in your cart is: {totalPrice:C}");
            //assignament 5
            OopsDemonstration.DemonstrateOopsConcepts();
            //assignament 6
            GetJson.SerializeWrite();
            //assignament 7
            MethodCalling.execute();
            //assignament 8
            TrainingDetails.Display();
            //Assignment genericsdelegate

            GenricAndDelegate.DemonstrateGenerics();





        }

}
}
    

       


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


//        }

//        private static void MoveObjects(IMove[] movingobjects)
//        {
//            foreach (var item in movingobjects)
//            {
//                item.Move();
//            }
//        }

        
        
//        }

        
//}
