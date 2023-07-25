using Xunit;
namespace _9_131_posts_inheritence_demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            ManagePosts(GetUsername());
            Console.WriteLine("Exiting the program");
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

        static string? GetUsername()
        {
            Console.Write("Enter your username: ");
            string? username = Console.ReadLine();
            Console.WriteLine($"***** Hi {username}, start creating posts!*****");
            return username;
        }

        static void ManagePosts(string? username)
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
                    if (IsValid(entry))
                    {
                        Handle(entry, username);
                    }
                    else
                    {
                        Console.WriteLine($"* Oops! You must enter 'text', 'image' or 'video'. Try again. \n");
                    }
                }
            } while (entry != "q" && entry != "quit");
        }

        static bool IsValid(string entry)
        {
            if (entry.ToLower() == "text" || entry.ToLower() == "image" || entry.ToLower() == "video")
            {
                return true;
            }
            return false;
        }

        static void Handle(string entry, string username)
        {
            if (entry.ToLower().Equals("text"))
            {
                GetTextPost(username);
            }
            if (entry.ToLower().Equals("image"))
            {
                GetImagePost(username);
            }
            if (entry.ToLower().Equals("video"))
            {
                GetVideoPost(username);
            }
        }
        static void GetTextPost(string username)
        {
            GeneralPost post = new GeneralPost();

            Console.Write("Enter post title: ");
            post.Title = Console.ReadLine();

            Console.Write("Enter text: ");
            post.Text = Console.ReadLine();

            post.Author = username;

            post.Date = DateTime.Now.ToString("M/d/yyyy");

            post.Display();
        }
        static void GetImagePost(string username)
        {
            ImagePost post = new ImagePost();

            Console.Write("Enter post title: ");
            post.Title = Console.ReadLine();

            Console.Write("Enter text: ");
            post.Text = Console.ReadLine();

            Console.Write("Enter image URL: ");
            post.ImageURL = Console.ReadLine();

            post.Author = username;

            post.Date = DateTime.Now.ToString("M/d/yyyy");

            post.Display();
        }
        static void GetVideoPost(string username)
        {
            VideoPost post = new VideoPost();

            Console.Write("Enter post title: ");
            post.Title = Console.ReadLine();

            Console.Write("Enter text: ");
            post.Text = Console.ReadLine();

            Console.Write("Enter video URL: ");
            post.VideoURL = Console.ReadLine();

            post.Author = username;

            post.Date = DateTime.Now.ToString("M/d/yyyy");

            post.Display();
        }
        [Fact]
        public void DemoTestMethod() { }
    }
}

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