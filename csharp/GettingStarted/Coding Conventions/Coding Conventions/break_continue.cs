namespace KeywordLearning
{
    public class break_continue
    {
        public void display()
        {
            string[] arr = { "Java", "Python", "SQL", "R", "HTML" };
            Console.WriteLine("4. BREAK CONTINUE");
            foreach (string i in arr)
            {
                if (i == "R")
                {
                    continue;
                }
                else if (i == "HTML")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(" ");


        }
    }

}