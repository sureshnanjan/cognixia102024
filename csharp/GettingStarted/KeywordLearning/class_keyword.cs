namespace KeywordLearning
{
    // Class definition using the 'class' keyword
    public class ClassKeyword
    {
        // Field using 'readonly' and 'const' keywords
        private readonly int readonlyField = 10;
        public const double Pi = 3.14159;

        // Property using 'get' and 'set' keywords
        public string Name { get; set; }

        // Constructor using 'public' access modifier and 'this' keyword
        public ClassKeyword(string name)
        {
            this.Name = name;
        }

        // Method with 'static', 'void', and 'try-catch' keywords
        public static void DisplayDetails()
        {
            // Local variable using 'int' and 'var' keywords
            int number = 5;
            var message = "Hello, World!";

            try
            {
                // Conditional statement with 'if' and 'else'
                if (number > 0)
                {
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine("Number is not positive.");
                }
            }
            catch (Exception ex)
            {
                // Exception handling using 'catch' and 'throw'
                Console.WriteLine("An error occurred: " + ex.Message);
                throw;
            }
        }

        // Method demonstrating 'return' and 'params' keywords
        public int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        // Method using 'override' and 'virtual' keywords
        public virtual string GetGreeting()
        {
            return "Hello from ClassKeyword!";
        }
    }

    // Derived class using 'inheritance' with 'base' and 'override' keywords
    public class DerivedKeyword : ClassKeyword
    {
        public DerivedKeyword(string name) : base(name)
        {
        }

        // Override method to provide new functionality
        public override string GetGreeting()
        {
            return "Hello from DerivedKeyword!";
        }
    }
}