using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajProject
{
    internal class Interface
    {
        public static void Main(string[] args)
        {
            // Demonstrating IDriveable interface
            Car car = new Car();
            Airplane airplane = new Airplane();

            Console.WriteLine("Demonstrating IDriveable:");
            car.Drive();
            airplane.Drive();

            // Demonstrating IFlyable interface
            Console.WriteLine("\nDemonstrating IFlyable:");
            airplane.Fly();

            // Demonstrating IWritable interface
            Document document = new Document();
            TextFile textFile = new TextFile();

            Console.WriteLine("\nDemonstrating IWritable:");
            document.Write();
            textFile.Write();
        }
    }

    // Custom Interfaces
    public interface IDriveable
    {
        void Drive();
    }

    public interface IFlyable
    {
        void Fly();
    }

    public interface IWritable
    {
        void Write();
    }

    // Class implementing IDriveable
    public class Car : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("The car is driving on the road.");
        }
    }

    // Class implementing IDriveable and IFlyable
    public class Airplane : IDriveable, IFlyable
    {
        public void Drive()
        {
            Console.WriteLine("The airplane is taxiing on the runway.");
        }

        public void Fly()
        {
            Console.WriteLine("The airplane is flying in the sky.");
        }
    }

    // Class implementing IWritable
    public class Document : IWritable
    {
        public void Write()
        {
            Console.WriteLine("Writing to the document...");
        }
    }

    // Class implementing IWritable
    public class TextFile : IWritable
    {
        public void Write()
        {
            Console.WriteLine("Writing to the text file...");
        }
    }
}
