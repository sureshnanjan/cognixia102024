using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class conditionsdemo
    {
        int a = 10;
        int n = 2;
        public void display()
        {
            if (a == 11)
                Console.WriteLine("false");
            else if (a == 10)
                Console.WriteLine("true");
            else
                Console.WriteLine("Everything is ok");
            switch (n)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;


            }


        }




    }
}