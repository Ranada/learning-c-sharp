namespace _5_7_TicTacToe
{
    internal class Program
    {
        public static string[,] board = {
                                            {"1", "2", "3"},
                                            {"4", "5", "6"},
                                            {"7", "8", "9"}
                                        };
        static void Main(string[] args)
        {
            bool continueGame = true;
            int currentPlayer = 1;
            
            do
            {
                // Track number of turns
                // Check player turn
                // Ask current player to pick a number position on the game board
                    // If it is player 1's turn, replace number with "X" for player 1 and increment the number of turns
                    // If it is plasyter 2's turn, replace number with "O" for player 2 and increment the number of turns
                // Print the updated game board
                // Check if there is a winner
                    // If there is a winner, print a message for the winner and end the game
                // If all the turns are used and there is no winner, print a message saying no one won, and reset the game
            } while (continueGame);
            PrintBoard();
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