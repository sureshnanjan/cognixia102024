using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemo
{

 
//loop.cs
 
public class NumberPrinter
    {
        public void PrintNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
   
   
}
