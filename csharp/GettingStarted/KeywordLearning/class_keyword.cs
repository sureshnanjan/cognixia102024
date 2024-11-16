using System;
namespace KeywordLearning
{
    public class class_keyword
    {
        public int PublicVar = 5;
        string[] colors = { "Red", "Green", "Blue" };

        public class_keyword()
        {
            if (PublicVar > 10)
            {
                Console.WriteLine("Number is greater than 10.");
            }
            else
            {
                Console.WriteLine("Number is less than or equal to 10.");
            }
        }

        public void Showcolour()
        {
            foreach (var color in colors)
            {
                Console.WriteLine("Colour: " + color);
            }
        }

        public void Output(string[] args)
        {
            class_keyword obj = new class_keyword();  

            obj.Showcolour();  
        }
    }
}
