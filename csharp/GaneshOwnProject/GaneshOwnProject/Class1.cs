namespace GaneshOwnProject
{
    public class Class1
    {
        // Car class implementing ICar interface
        public class Car : ICar
        {
            public void StartEngine()
            {
                Console.WriteLine("Car engine started.");
            }

            public void StopEngine()
            {
                Console.WriteLine("Car engine stopped.");
            }
        }

        // Bike class implementing IBike interface
        public class Bike : IBike
        {
            public void Pedal()
            {
                Console.WriteLine("Pedaling the bike.");
            }

            public void Brake()
            {
                Console.WriteLine("Bike brake applied.");
            }
        }

    }
}
