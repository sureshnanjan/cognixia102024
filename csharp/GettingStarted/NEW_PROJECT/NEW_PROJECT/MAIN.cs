using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PROJECT
{
    public class MAIN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the main file");
            call_ calculate = new call_();
            calculate.display();
            Set_ myset = new Set_();
            myset.display();
            SortedSet_ mySS=new SortedSet_();
            mySS.display();
            Beep makesound = new Beep();
            makesound.sound();

        }
    }
}
