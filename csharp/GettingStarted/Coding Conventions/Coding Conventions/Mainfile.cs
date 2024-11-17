using System;

namespace Mainfile
{

    public class Mainfile
    {

        static void Main(string[] args)
        {
            
            ////dictionary examples
            //dict dictionary = new dict();
            //dictionary.Execute();

            // Stack Operations
            StackExample stack = new StackExample();
            stack.Execute();

            // Queue Operations
            QueueExample queue = new QueueExample();
            queue.Execute();

            // Set Operations
            SetExample set = new SetExample();
            set.Execute();

            // SortedSet Operations
            SortedSetExample sortedSet = new SortedSetExample();
            sortedSet.Execute();

            Beep beep = new Beep();
            beep.display();
    }
    }
}

