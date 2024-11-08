using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class Continue_Break
    {
       public void display()
        {
            for(int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                    continue;
            }
        }
    }
}
