namespace _9_131_posts_inheritence_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string? entry = "";

            do
            {
                Console.WriteLine("Enter type of post you want to create ('text', 'image', or 'video'): ");
                Console.WriteLine("Or enter 'q' or 'quit' to exit the app.\n");
                Console.Write("> ");
                entry = Console.ReadLine();
                if (entry != null)
                {
                    Console.WriteLine($"{entry}\n");
                }
            } while (entry != "q" && entry != "quit");

            Console.WriteLine("Exiting the program");

            /*
             * General Post
             * - ID
             * - Title
             * - Author
             * - Post date
             * 
             * Image post
             * - Inherit general post
             * - Image URL
             * 
             * Video post
             * - Inherit general post
             * 
             */
        }
    }
}