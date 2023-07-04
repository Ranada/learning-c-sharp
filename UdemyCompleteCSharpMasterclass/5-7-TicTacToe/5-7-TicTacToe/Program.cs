namespace _5_7_TicTacToe
{
    internal class Program
    {
        public static int currentPlayer = 2;
        public static int turnCount = 0;
        //public static string input = "";

        public static string[,] board = {
                                            {"1", "2", "3"},
                                            {"4", "5", "6"},
                                            {"7", "8", "9"}
                                        };

        static void Main(string[] args)
        {

            do
            {

                Console.Clear();
                CheckCurrentPlayer();
                GetCurrentPlayerInput();

                if (HaveWinner())
                {
                    ResetGame();
                }

                if (ReachMaxTurns())
                {
                    ResetGame();
                }

            } while (turnCount < 9);
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
            string input = "";

            do
            {
                PrintBoard();
                Console.Write($"Player {currentPlayer}, pick an available numbered position (1 through 9): ");
                input = Console.ReadLine()!;
                if (input == null) input = "";
                Console.WriteLine();
            } while (!isValid(input));

            UpdateBoard(input);
            turnCount++;
        }

        public static bool isValid(string input)
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
                Console.Clear();
                Console.WriteLine("*** OOPS! You must enter an available number position between 0 and 9.***\n");

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
                    Console.Clear();
                    Console.WriteLine("*** OOPS! This position is already filled. Select an available number position between 0 and 9. ***\n");
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

            if (input == "1") board[0, 0] = gamePiece;
            if (input == "2") board[0, 1] = gamePiece;
            if (input == "3") board[0, 2] = gamePiece;
            if (input == "4") board[1, 0] = gamePiece;
            if (input == "5") board[1, 1] = gamePiece;
            if (input == "6") board[1, 2] = gamePiece;
            if (input == "7") board[2, 0] = gamePiece;
            if (input == "8") board[2, 1] = gamePiece;
            if (input == "9") board[2, 2] = gamePiece;
        }

        public static bool HaveWinner()
        {
            if (IsHorizontalWin() || IsVerticalWin() || IsDiagonalWin())
            {
                Console.Clear();
                PrintBoard();
                Console.WriteLine($"**** Player {currentPlayer} wins! *****\n");
                Console.WriteLine("Press ANY KEY to reset the game.");
                Console.ReadKey();

                return true;
            }

            return false;
        }

        public static bool IsHorizontalWin()
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                if (
                    (board[row, 0] == "X" && board[row, 1] == "X" && board[row, 2] == "X") ||
                    (board[row, 0] == "O" && board[row, 1] == "O" && board[row, 2] == "O")
                    )
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsVerticalWin()
        {
            for (int col = 0; col < board.GetLength(1); col++)
            {
                if (
                    (board[0, col] == "X" && board[1, col] == "X" && board[2, col] == "X") ||
                    (board[0, col] == "O" && board[1, col] == "O" && board[2, col] == "O")
                    )
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsDiagonalWin()
        {

            if (
                (board[0, 0] == "X" && board[1, 1] == "X" && board[2, 2] == "X") ||
                (board[0, 0] == "O" && board[1, 1] == "O" && board[2, 2] == "O")
                )
            {
                return true;
            }

            if (
                (board[0, 2] == "X" && board[1, 1] == "X" && board[2, 0] == "X") ||
                (board[0, 2] == "O" && board[1, 1] == "O" && board[2, 0] == "O")
                )
            {
                return true;
            }

            return false;
        }

        public static bool ReachMaxTurns()
        {
            if (turnCount == 9)
            {
                Console.Clear();
                PrintBoard();
                Console.WriteLine("**** Draw! No One Wins ****\n");
                Console.WriteLine("Press ANY KEY to reset the game.");
                Console.ReadKey();
                return true;
            }

            return false;
        }

        public static void ResetGame()
        {
            board = new [,] {
                { "1", "2", "3"},
                { "4", "5", "6"},
                { "7", "8", "9"}
            };

            turnCount = 0;

            Console.Clear();
        }

        public static void PrintBoard()
        {
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[0, 0], board[0, 1], board[0, 2]);
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