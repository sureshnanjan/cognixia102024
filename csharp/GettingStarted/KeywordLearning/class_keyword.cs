using System;
namespace KeywordLearning
{
    public class class_keyword
    {
        public enum Levels { High, Medium, Low }


        public interface IKeywordDemo
        {
            void DisplayInfo();
        }

        //public abstract class AbstractAndDelegateDemo
        //{
        //    public abstract void ShowMessage();
        //}


        public class ClassKeyword : AbstractAndDelegateDemo, IKeywordDemo
        {
            public bool BoolVal { get; set; }
            public int IntVal { get; set; }
            public float FloatVal { get; set; }
            public double DoubleVal { get; set; }
            public string StringVal { get; set; }


            public ClassKeyword()
            {
                BoolVal = true;
                IntVal = 100;
                FloatVal = 200.3f;
                DoubleVal = 128.67;
                StringVal = "hello";
            }


            public override void ShowMessage()
            {
                Console.WriteLine("This is my show message");
            }


            public void DisplayInfo()
            {
                Console.WriteLine($"Bool Value: {BoolVal}, Int Value: {IntVal}, Float Value: {FloatVal}, Double Value: {DoubleVal}, String Value: {StringVal}");
            }


            public void SwitchCaseEx(int level)
            {
                Levels levelnum = (Levels)level;
                switch (levelnum)
                {
                    case Levels.High:
                        Console.WriteLine("High level implemented");
                        break;
                    case Levels.Medium:
                        Console.WriteLine("Medium level implemented");
                        break;
                    case Levels.Low:
                        Console.WriteLine("Low level implemented");
                        break;
                    default:
                        Console.WriteLine("Invalid level");
                        break;
                }
            }


            public void GotoExample()
            {
                int i = 0;
            startLoop:
                if (i < 3)
                {
                    Console.WriteLine($"Goto loop count: {i}");
                    i++;
                    goto startLoop;
                }
            }


            public void FinallyExample()
            {
                try
                {
                    int divisor = 0; // This could be any value, set it to a non-zero value for a safe division
                    if (divisor == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    else
                    {
                        int result = 10 / divisor;
                        Console.WriteLine($"Result: {result}");
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Division by zero error caught.");
                }
                finally
                {
                    Console.WriteLine("This block always executes regardless of exception.");
                }
            }


        }


    }
}
