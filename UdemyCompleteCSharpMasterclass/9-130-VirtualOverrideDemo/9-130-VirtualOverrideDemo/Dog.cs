using System;
using _9_130_VirtualOverrideDemo;

public class Dog : Animal
{
	public Dog(string name, int age) : base(name, age)
	{
	}

    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }

    public override void Eat()
    {
        if (IsHungry)
        {
            Console.WriteLine($"{Name} is eating doggie biscuits.");
        }
        else
        {
            Console.WriteLine($"{Name} is not hungry.");
        }
    }

    public override void Play()
    {
        Console.WriteLine($"{Name} is doing zoomies around the house.");
    }
}


