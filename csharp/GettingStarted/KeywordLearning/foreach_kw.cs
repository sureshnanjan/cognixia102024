using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class foreach_kw
    {
        public void display()
        {
            int[] num= { 1, 2, 33, 4, 5, 5, 67, 7 };
            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
