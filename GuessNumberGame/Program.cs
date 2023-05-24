namespace GuessNumberGame;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------Guess the Number Game--------");
        Console.WriteLine("I'm thinking of a number between 0 and 10.");
        Console.WriteLine("Enter your number guess or 'exit' to leave the game.\n");

        int randomNumber = new Random().Next(20);
        string input;
        bool continueGame = true;

        while (continueGame)
        {
            Console.WriteLine("What's your guess?");
            input = Console.ReadLine();
            Console.WriteLine($"Your guess: {input}");

            if (input == "exit")
            {
                continueGame = false;
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Muahahah! The random number is: {randomNumber}");
    }
}
