namespace KeywordLearning
{
    public class sizeof_lock
    {
        public void display()
        {
            Console.WriteLine("6. SIZEOF and LOCK");

            int sizeOfInt = sizeof(int);
            Console.WriteLine("Size of int: " + sizeOfInt);

            object lockObject = new object();
            lock (lockObject)
            {
                Console.WriteLine("Statement inside the lock block. ");
            }

            Console.WriteLine(" ");
        }
    }
}
