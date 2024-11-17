namespace KeywordLearning
{
    public class interface_
    {
        public void display()
        {
            Console.WriteLine("8. INTERFACE");

            IAnimal animal = new Dog();
            animal.MakeSound();

            Console.WriteLine(" ");
        }
    }
    public interface IAnimal
    {
        void MakeSound();
    }
    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}