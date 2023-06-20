namespace _3_47_GreetFriends
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[] { "Chris", "Marc", "Iris" };
            GreetFriends(friends);
        }

        public static void GreetFriends(string[] friends)
        {
            foreach (string friend in friends)
            {
                Console.WriteLine($"Hello, {friend}!");
            }
        }
    }
}