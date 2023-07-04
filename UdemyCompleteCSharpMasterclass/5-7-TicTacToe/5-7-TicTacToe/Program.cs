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