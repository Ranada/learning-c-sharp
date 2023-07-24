namespace _9_131_posts_inheritence_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartApp();
            ManagePosts();

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

        static string Divider()
        {
            string str = "";
            for (int i = 0; i < 100; i++)
            {
                str += '-';
            }
            return str;
        }

        static void StartApp()
        {
            Console.Write("Enter your username: ");
            string? username = Console.ReadLine();
            Console.WriteLine($"***** Hi {username}, start creating posts!*****");
        }

        static void ManagePosts()
        {
            string? entry = "";

            do
            {
                Console.WriteLine(Divider());
                Console.WriteLine("Enter the type of post you want to create: 'text', 'image', or 'video' (enter 'q' or 'quit' to exit.)");
                Console.Write("> ");
                entry = Console.ReadLine();
                if (entry != null)
                {
                    if (isValid(entry))
                    {
                        if (entry.ToLower().Equals("text")) 
                        {
                            Console.WriteLine("This is a text post");
                            GeneralPost post = new GeneralPost("Text title", "Content text", "Some date");
                            Console.WriteLine(post.Id);
                            Console.WriteLine(post.Title);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"* Oops! You must enter 'text', 'image' or 'video'. Try again. \n");
                    }
                }
            } while (entry != "q" && entry != "quit");
        }

        static bool isValid(string entry)
        {
            if (entry.ToLower() == "text" || entry.ToLower() == "image" || entry.ToLower() == "video")
            {
                return true;
            }
            return false;
        }

    }
}