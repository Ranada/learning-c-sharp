// See https://aka.ms/new-console-template for more information


using System.Numerics;

Random dice = new Random();

// Example of stateful (instance) method. Requires creating an instance of the class (ex. new Random())
// int roll = dice.Next(1, 7);

// .WriteLine is a static method. Does not require creating an instance of a class
// Console.WriteLine(roll);

// Will get a compilation error since a new object isn't created to access a stateful method
// int result = Random.Next();

// Method overload demo


string? input;
do
{

    int roll1 = dice.Next(1, 7);
    int roll2 = dice.Next(1, 7);
    int roll3 = dice.Next(1, 7);

    int total = roll1 + roll2 + roll3;

    if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
    {
        if ((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled triples! Winner, winner, chicken dinner! +6 bonus points to total!");
            total += 6;
        }
        else
        {
            Console.WriteLine("You rolled doubles! +2 bonus points to total!");
            total += 2;
        }
    }


    Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

    if (total >= 15)
    {
        Console.WriteLine("Congrats you win!");
    }
    else
    {
        Console.WriteLine("Womp womp. Sorry you loss.");
    }
    
    Console.WriteLine("\nPress any key to continue. Or type 'exit' to end the program");
    input = Console.ReadLine();

} while (input == null || !input.ToLower().Equals("exit"));