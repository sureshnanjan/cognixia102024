






using System.Linq.Expressions;
using System.Reflection.Metadata;
using KeywordLearning;
using PetstoreModel;
using TypeSystemDemo;
namespace GettingStarted;
public class TrainingDashboard
{
    public static void Main(string[] args)
    {
        // Example usage of the generic stack with CRUD operations
        StackCRUD<int> intStack = new StackCRUD<int>();

        // Create operations: Push items onto the stack
        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);

        // Read operation: Peek the top element
        Console.WriteLine($"Top element: {intStack.Peek()}");

        // Update operation: Change the top element
        intStack.Update(40);

        // Delete operation: Pop the top element
        intStack.Pop();

        // Display the current state of the stack
        intStack.DisplayStack();

        // Check if the stack is empty
        Console.WriteLine($"Is stack empty? {intStack.IsEmpty()}");

        // Push more elements to the stack
        intStack.Push(50);
        intStack.Push(60);

        // Display updated stack
        intStack.DisplayStack();

        //Dictionaries

        DictionaryCRUD<int, string> dictionary = new DictionaryCRUD<int, string>();

        // Create operations: Add key-value pairs to the dictionary
        dictionary.Add(1, "Apple");
        dictionary.Add(2, "Banana");
        dictionary.Add(3, "Cherry");

        // Read operation: Get the value associated with a key
        Console.WriteLine($"Key 2: {dictionary.Get(2)}");

        // Update operation: Modify the value for an existing key
        dictionary.Update(2, "Blueberry");

        // Delete operation: Remove a key-value pair from the dictionary
        dictionary.Delete(1);

        // Display the current state of the dictionary
        dictionary.DisplayDictionary();

        // Check if a key exists in the dictionary
        Console.WriteLine($"Contains Key 1? {dictionary.ContainsKey(1)}");
        Console.WriteLine($"Contains Key 3? {dictionary.ContainsKey(3)}");

        // Check if the dictionary is empty
        Console.WriteLine($"Is dictionary empty? {dictionary.IsEmpty()}");

        // Add more key-value pairs to the dictionary
        dictionary.Add(4, "Dragonfruit");
        dictionary.Add(5, "Elderberry");

        // Display updated dictionary
        dictionary.DisplayDictionary();

        var intList = new GenericList<int>();
        intList.AddItem(10);
        intList.AddItem(20);
        intList.AddItem(30);
        intList.DisplayList(); // Output: 10, 20, 30

        // Find item greater than 15
        var found = intList.FindItem(n => n > 15);
        Console.WriteLine($"Found: {found}"); // Output: 20

        // Update item at index 1
        intList.UpdateItem(1, 100);
        intList.DisplayList(); // Output: 10, 100, 30

        // Remove item by value
        intList.RemoveItem(10);
        intList.DisplayList(); // Output: 100, 30

        CustomerQueueManagement queueManagement = new CustomerQueueManagement();

        bool exit1 = false;
        while (!exit1)
        {
            Console.WriteLine("\n--- Customer Queue Management ---");
            Console.WriteLine("1. Add Customer (Enqueue)");
            Console.WriteLine("2. View All Customers");
            Console.WriteLine("3. Update Customer");
            Console.WriteLine("4. Remove Customer (Dequeue)");
            Console.WriteLine("5. Search Customer");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            string choice1 = Console.ReadLine();

            switch (choice1)
            {
                case "1":
                    // Add customer (Enqueue)
                    Console.Write("Enter Customer ID: ");
                    int customerId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Customer Name: ");
                    string name1 = Console.ReadLine();
                    queueManagement.EnqueueCustomer(customerId, name1);
                    break;

                case "2":
                    // View all customers
                    queueManagement.ViewQueue();
                    break;

                case "3":
                    // Update customer
                    Console.Write("Enter Customer ID to update: ");
                    int updateId1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter New Customer Name: ");
                    string newName1 = Console.ReadLine();
                    queueManagement.UpdateCustomer(updateId1, newName1);
                    break;

                case "4":
                    // Remove customer (Dequeue)
                    queueManagement.DequeueCustomer();
                    break;

                case "5":
                    // Search customer
                    Console.Write("Enter Customer ID to search: ");
                    int searchId1 = int.Parse(Console.ReadLine());
                    queueManagement.SearchCustomer(searchId1);
                    break;

                case "6":
                    // Exit
                    exit1 = true;
                    Console.WriteLine("Exiting the program.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        
        }
        }
    }
//    public static void Main(string[] args)
//{
//    class_keyword one = new class_keyword();
//    one.display();
//    if_else two = new if_else();
//    two.display();
//    switch_case three = new switch_case();
//    three.display();
//    break_continue four = new break_continue();
//    four.display();
//    long_while five = new long_while();
//    five.display();
//    sizeof_lock six = new sizeof_lock();
//    six.display();
//    interface_ seven = new interface_();
//    seven.display();
//    default_ eight = new default_();
//    eight.display();
//    decimal_int_return nine = new decimal_int_return();
//    nine.display();
//    //DelegateKeyword five = new DelegateKeyword();
//    //five.display();
//    //FixedKeyword six = new FixedKeyword();
//    //six.display();

//}
////        // Fields
////        string _title;
////        string _description;
////        DateTime _current_date;
////        string participants;
////        Participant[] tr_participants;

////        // Operation
////        public void Publish() {
////            Console.WriteLine("This is the Data for Dashboard");
////        }

////        public TrainingDashboard(string title, string desc, string participants)
////        {
////            this._title = title;
////            this._description = desc;
////            this.participants = participants;  
////            //foreach (var item in participants.Split(","))
////            //{
////                //this.participants.Append(item);
////            //}


////        }

////        public void Populate() {
////            Console.WriteLine(_title + " " + _description + " " + participants);
////        }
////        static void Main(string[] args)
////        {
////            string trainername = "Suresh Nanjan";
////            Console.WriteLine("Hello, World!");
////            TrainingDashboard automationTraining = new TrainingDashboard("Training","Job","Samson");
////            automationTraining.Populate();
////            automationTraining.Publish();
////        }
////>>>>>>> 667ea71 (file added)
////    }
////}

////delegate void GettingStartedDelegate();
////delegate int MyIntDelegate(int x);
/////// <summary>
/////// This is a class to represent training reports 
/////// </summary>
////internal class TrainingDashboard
////{
////    // Fields
////    string _title;
////    string _description;
////    DateTime _current_date;
////    string participants;
////    Participant[] tr_participants;

////    // Operation
////    /// <summary>
////    /// 
////    /// </summary>
////    public void Publish() {
////        Console.WriteLine("This is the Data for Dashboard");
////    }

////    public TrainingDashboard(string title, string desc, string participants)
////    {
////        this._title = title;
////        this._description = desc;
////        this.participants = participants;  
////        //foreach (var item in participants.Split(","))
////        //{
////            //this.participants.Append(item);
////        //}


////    }

////<<<<<<< HEAD
////    /// <summary>
////    /// 
////    /// </summary>
////    /// <param name="title"></param>
////    /// <param name="desc"></param>
////    /// <param name="participants"></param>
////    public void Populate(string title, string desc, string participants) { }
////=======
////    public void Populate() {
////        Console.WriteLine(_title + " " + _description + " " + participants);
////    }
////>>>>>>> 667ea71 (file added)
////    static void Main(string[] args)
////    {
////        GettingStartedDelegate myref = mymethod;
////        Action myactionref = mymethod;
////        Action mylambdaaction = () => { Console.WriteLine("This is a lambda method method to demo"); };
////        MyIntDelegate myintref = SomeMethod;
////        Func<int,int> myfunc = SomeMethod;
////        Func<int> mylambdafunc = () => 100;
////        //myref();
////        mylambdaaction();
////        Console.WriteLine(mylambdafunc());
////        mylambdafunc();

////        int[] numbers = { 1, 2, 3, 4, 5 };
////        int added = numbers.Aggregate((x,y)=> x + y);
////        int multipled = numbers.Aggregate((x, y) => x * y);
////        int adddoubled = numbers.Aggregate((x, y) => (x + y) * 2);
////        Console.WriteLine(multipled);
////        Console.WriteLine(added);
////        Console.WriteLine(adddoubled);
////        numbers.
////    }

////    private static void SomeOtherMethod() {
////        Console.WriteLine("Doing some other complext operation");
////    }

////    private static int add(int a, int b) {
////        return a + b;
////    }

////    private static void PerformThis(GettingStartedDelegate x) {
////        Console.WriteLine("Going to perform the required Operation");
////        x();
////    }

////    private static int SomeMethod(int arh1) {
////        Console.WriteLine($"This is inside my Int Method {arh1}");
////        return 0; }

////    private static void mymethod() {
////        Console.WriteLine("This is a Method Returning Void Taking Nothing");
////    }

////    private static void Interface_Demo()
////    {
////        // Name + number of arguments + types of arguments
////        //dashboard_demo();
////        //User suresh = new User();
////        Console.WriteLine("Welcome to Programming");
////        ClassDemo myclass = new ClassDemo(1, "suresh");
////        Console.WriteLine(myclass);
////        int[] numbers = { 10, 12, 3, 0, 9, 25 };
////        Array.Sort(numbers);
////        foreach (var item in numbers)
////        {
////            Console.WriteLine(item);
////        }
////        ClassDemo[] myTypes = { new ClassDemo(1, "A"), new ClassDemo(5, "Five"), new ClassDemo(2, "two") };
////        Array.Sort(myTypes);
////        foreach (var item in myTypes)
////        {
////            Console.WriteLine(item);
////        }
////    }


////    static void Interface_Demo(string arg1) { }
////    static void Interface_Demo(int arg1) { }

////    //int Interface_Demo(string arg1) { }

////    private static void dashboard_demo()
////    {

////        string trainername = "Suresh Nanjan";
////        Console.WriteLine("Hello, World!");
////<<<<<<< HEAD
////        TrainingDashboard automationTraining = new TrainingDashboard("", "", "");
////        //automationTraining.Populate()
////        //automationTraining.Publish();

////        // A collection of Moving Objects
////        IMove[] movingobjects = { new Car(), new Bird(), new Bike() };
////        MoveObjects(movingobjects);

////        int num1 = 10;
////        int num2 = 11;
////        ClassDemo cl1 = new ClassDemo(1, "one");
////        ClassDemo cl2 = new ClassDemo(2, "two");
////        DayOfWeek dayofWeek = DayOfWeek.Sunday;


////=======
////        TrainingDashboard automationTraining = new TrainingDashboard("Training","Job","Samson");
////        automationTraining.Populate();
////        automationTraining.Publish();
////>>>>>>> 667ea71 (file added)
////    }

////    private static void MoveObjects(IMove[] movingobjects)
////    {
////        foreach (var item in movingobjects)
////        {
////            item.Move();
////        }
////    }



////    }

