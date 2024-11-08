namespace KeywordLearning
{
    public class default_
    {
        public void display()
        {
            Console.WriteLine("8. DEFAULT");

            int defaultInt = default(int);
            Console.WriteLine("Default value of int: " + defaultInt);

            string defaultString = default(string);
            Console.WriteLine("Default value of string: " + defaultString); 

            int? defaultNullableInt = default(int?);
            Console.WriteLine("Default value of nullable int: " + defaultNullableInt);

            Console.WriteLine(" ");
        }
    }
}