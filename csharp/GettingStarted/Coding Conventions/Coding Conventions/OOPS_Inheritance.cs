using System;

public class Animal
{
    public string Name { get; set; }

    // Virtual method that can be overridden in derived classes
    public virtual void Speak()
    {
        Console.WriteLine($"The animal {Name} makes a sound.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Animal name: {this.Name}");
        // 'this' refers to the current instance of the class
    }
}

public class Dog : Animal
{
    public Dog(string name)
    {
        this.Name = name;
    }

    // Overriding the virtual method
    public override void Speak()
    {
        Console.WriteLine($"The dog {this.Name} barks!");
    }
}

public class Cat : Animal
{
    public Cat(string name)
    {
        base.Name = name;  // 'base' refers to the base class (Animal) 
    }

    public override void Speak()
    {
        Console.WriteLine($"The cat {base.Name} meows!");
    }
}
