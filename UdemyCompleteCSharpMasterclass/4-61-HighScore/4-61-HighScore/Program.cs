using System.Threading.Channels;
using System.Transactions;

namespace _4_61_HighScore
{
    internal class Program
    {
        static bool gameOn = true;
        static int score = 0;
        static int highscore = 0;
        static string player = "";
        static string highscorePlayer = "";
        static void Main(string[] args)
        {
            while (gameOn)
            {
                if (gameOn) GetPlayer();
                if (gameOn) GetScore();
            }

            Console.WriteLine("Exiting game.");
        }

        public static void GetPlayer()
        {
            Console.Write("Enter player name: ");
            player = Console.ReadLine();
            if (player == "exit") gameOn = false;
        }

        public static void GetScore()
        {
            Console.Write("Enter score: ");
            string scoreEntry = Console.ReadLine();
            if (scoreEntry == "exit")
            {
                gameOn = false;
                return;
            }
            Console.WriteLine();

            bool success = int.TryParse(scoreEntry, out score);

            if (success)
            {
                ProcessScore(player, score);
            }
            else
            {
                Console.WriteLine("Please enter an integer for the score. Try again.\n");
            }
        }
        
        public static void ProcessScore(string player, int score)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = player;

                Console.WriteLine($"New high score is {highscore}.");
                Console.WriteLine($"New high score holder is {highscorePlayer}.\n");
            }
            else
            {
                Console.WriteLine($"The old highscore of {highscore} could not be broken and is still held by {highscorePlayer}.\n");
            }
        }
    }
}