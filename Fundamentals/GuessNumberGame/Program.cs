namespace GuessNumberGame;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n--------------------------------Guess the Number Game--------------------------------");
        Console.WriteLine("I'm thinking of a number between 0 and 10.");
        Console.WriteLine("Enter your guess or 'exit' to leave the game.\n");

        int randomNumber = new Random().Next(20);
        string? input;
        int guess;
        int guessCount = 0;
        bool continueGame = true;

        while (continueGame)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("What's your guess?");
            input = Console.ReadLine();

            if (input == "exit")
            {
                continueGame = false;
                Console.WriteLine($"\n---------Muahahaha! The random number is: {randomNumber}---------");

            }

            bool isInteger = false;
            isInteger = Int32.TryParse(input, out guess);

            if (isInteger && guess >= 0 && guess <= 20)
            {
                Console.WriteLine($"Your guess: {guess}");
                guessCount++;

                if (guess == randomNumber)
                {
                    Console.WriteLine($"\n********Congrats! You correctly guessed the random number ({randomNumber}) using {guessCount} attempts********");
                    continueGame = false;
                }
                else
                {
                    Console.WriteLine("Your guess is {0} than the random number.", guess < randomNumber ? "LOWER" : "HIGHER");
                }
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
