using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class trycatch_Exceptions
    {
        public void display()
        {
            int a = 12, b = 13;
            try
            {
                string str = Console.ReadLine();
                int n = int.Parse(str);
                Console.WriteLine("Entered number is " + n);
                if (a == 122)
                    goto Ganesh;
                else
                    goto Rao;

            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            finally
            {
                Console.WriteLine("Finally block is executing");
            }
        Ganesh:
            Console.WriteLine("Found number and is equals to given number");

        Rao:
            Console.WriteLine("Not equals to given number");
        
            


}


    }
}
