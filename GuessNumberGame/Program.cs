namespace GuessNumberGame;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n----------------------Guess the Number Game-----------------------");
        Console.WriteLine("I'm thinking of a number between 0 and 10.");
        Console.WriteLine("Enter your guess or 'exit' to leave the game.\n");

        int randomNumber = new Random().Next(20);
        string? input;
        int guess;
        int guessCount = 0;
        bool continueGame = true;

        while (continueGame)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("What's your guess?");
            input = Console.ReadLine();

            if (input == "exit")
            {
                continueGame = false;
                Console.WriteLine($"\n---------Muahahaha! The random number is: {randomNumber}---------");

            }

            bool isInteger = false;
            isInteger = Int32.TryParse(input, out guess);

            if (isInteger)
            {
                Console.WriteLine($"Your guess: {guess}");
                guessCount++;

                if (guess < 0 || guess > 20)
                {
                    Console.WriteLine($"Whoops! Your guess is outside the range of 0 and 20.");
                    Console.WriteLine($"Try again.");
                    continue;
                }

                if (guess > randomNumber)
                {
                    Console.WriteLine($"Your guess is HIGHER than the random number.");
                    continue;
                }

                if (guess < randomNumber)
                {
                    Console.WriteLine($"Your guess is LESS than the random number.");
                    continue;
                }

                if (guess == randomNumber)
                {
                    Console.WriteLine($"\n*******Congrats! You correctly guessed the random number: {randomNumber} with {guessCount} attempts*******");
                    continueGame = false;
                }
                Console.WriteLine("------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine($"\nWhoops! You need to enter a number between 0 and 20.");
                Console.WriteLine($"Try again.");
            }
            Console.WriteLine();
        }
    }
}
