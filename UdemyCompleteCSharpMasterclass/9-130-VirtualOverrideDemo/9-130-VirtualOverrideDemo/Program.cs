namespace _9_130_VirtualOverrideDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string divider = "";

            for (int i = 0; i < 100; i++)
            {
                divider += "-";
            }

            Animal animal = new Animal("Dodo", 99);
            Console.WriteLine($"My animal's name is {animal.Name}");
            Console.WriteLine($"He is {animal.Age} years old");
            animal.MakeSound();
            animal.Eat();
            animal.Play();

            
            Console.WriteLine(divider);
            Dog dog = new Dog("Copper", 12);
            Console.WriteLine($"My dog's name is {dog.Name}");
            Console.WriteLine($"He is {dog.Age} years old");
            dog.MakeSound();
            dog.Eat();
            dog.Play();
        }
    }
}