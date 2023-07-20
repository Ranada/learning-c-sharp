namespace _9_130_VirtualOverrideDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Copper", 12);
            Console.WriteLine($"My animal's name is: {animal.Name} years old");
            Console.WriteLine($"He is: {animal.Age}");
            animal.MakeSound();
            animal.Eat();
            animal.Play();
        }
    }
}