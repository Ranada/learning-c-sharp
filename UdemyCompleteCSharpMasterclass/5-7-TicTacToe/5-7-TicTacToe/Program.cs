namespace _5_7_TicTacToe
{
    internal class Program
    {
        //public static bool continueGame = true;
        public static int currentPlayer = 2;
        public static int turnCount = 0;
        public static string? input = "";
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
                // Track number of turnCount
                // Check player turn
                CheckCurrentPlayer();
                GetCurrentPlayerInput();
                // Ask current player to pick a number position on the game board
                    // If it is player 1's turn, replace number with "X" for player 1 and increment the number of turnCount
                    // If it is plasyter 2's turn, replace number with "O" for player 2 and increment the number of turnCount
                // Print the updated game board
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
            Console.Write($"Player {currentPlayer}, pick an available numbered position (1 through 9): ");
            input = Console.ReadLine();
            Console.WriteLine();

            if (input == null) input = "";

            UpdateBoard(input);
            turnCount++;
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