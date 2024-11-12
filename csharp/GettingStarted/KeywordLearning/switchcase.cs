namespace KeywordLearning
{
    public class switch_case
    {
        public void display()
        {
            int digit = 3;
            Console.WriteLine("3. SWITCH");
            switch (digit)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;

            }
            Console.WriteLine(" ");
        }
    }
}
