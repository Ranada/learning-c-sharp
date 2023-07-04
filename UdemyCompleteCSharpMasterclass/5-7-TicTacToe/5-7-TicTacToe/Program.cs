namespace _5_7_TicTacToe
{
    internal class Program
    {
        public static int currentPlayer = 2;
        public static int turnCount = 0;
        public static string input = "";

        public static string[,] board = {
                                            {"1", "2", "3"},
                                            {"4", "5", "6"},
                                            {"7", "8", "9"}
                                        };

        static void Main(string[] args)
        {

            do
            {
                PrintBoard();
                CheckCurrentPlayer();
                GetCurrentPlayerInput();

                // Check if there is a winner
                    // If there is a winner, print a message for the winner and end the game
                // If all the turnCount are used and there is no winner, print a message saying no one won, and reset the game
            } while (turnCount < 9);
            PrintBoard();
        }

        public static void CheckCurrentPlayer()
        {
            if (currentPlayer == 2)
            {
                currentPlayer = 1;
            }
            else 
            { 
                currentPlayer = 2;
            }
        }

        public static void GetCurrentPlayerInput() 
        {
            do 
            { 
                Console.Write($"Player {currentPlayer}, pick an available numbered position (1 through 9): ");
                input = Console.ReadLine()!;
                if (input == null) input = "";
                Console.WriteLine();
            } while (!isValid(ref input));

            UpdateBoard(input);
            turnCount++;
        }

        public static bool isValid(ref string input)
        {
            bool isInteger = false;
            int number = 0;
            bool isValidNumber = false;

            isInteger = int.TryParse(input, out number);

            if (isInteger && (number >= 0 && number <= 9))
            {
                isValidNumber = true;
            }
            else
            { 
                Console.WriteLine("You must enter an available number between 0 and 9.\n");
                return false;
            }

            if (isValidNumber)
            {
                if ((input == "1" && board[0, 0] != "1") ||
                    (input == "2" && board[0, 1] != "2") ||
                    (input == "3" && board[0, 2] != "3") ||
                    (input == "4" && board[1, 0] != "4") ||
                    (input == "5" && board[1, 1] != "5") ||
                    (input == "6" && board[1, 2] != "6") ||
                    (input == "7" && board[2, 0] != "7") ||
                    (input == "8" && board[2, 1] != "8") ||
                    (input == "9" && board[2, 2] != "9")
                    )
                 {
                    Console.WriteLine("Oops! This position is already filled. Select an available position number by choosing a visible number between 0 and 9.\n");
                    return false;
                 }

            }
            return true;
        }

        public static void UpdateBoard(string input)
        {
            string gamePiece = "";

            if (currentPlayer == 1) gamePiece = "X";
            else if (currentPlayer == 2) gamePiece = "O";
            
            if (input == "1") board[0,0] = gamePiece;
            if (input == "2") board[0,1] = gamePiece;
            if (input == "3") board[0,2] = gamePiece;
            if (input == "4") board[1,0] = gamePiece;
            if (input == "5") board[1,1] = gamePiece;
            if (input == "6") board[1,2] = gamePiece;
            if (input == "7") board[2,0] = gamePiece;
            if (input == "8") board[2,1] = gamePiece;
            if (input == "9") board[2,2] = gamePiece;
        }

        public static void PrintBoard()
        {
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[0,0], board[0,1], board[0, 2]);
            Console.WriteLine("_____|_____|_____");

            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("_____|_____|_____");

            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("     |     |    ");
        }
    }
}