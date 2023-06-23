using System.ComponentModel;

namespace _4_59_LoginRegister
{
    internal class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
        }

        public static void Register() {
            Console.WriteLine("Create username:");
            username = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Create password:");
            password = Console.ReadLine();
            Console.WriteLine();
        }

        public static void Login()
        {
            string usernameEntry = "";
            string passwordEntry = "";

            while (usernameEntry != username)
            {
                Console.WriteLine();
                Console.WriteLine("Enter username:");
                if (username == Console.ReadLine())
                {
                    Console.WriteLine("Username is valid.");
                    Console.WriteLine();
    
                    while (passwordEntry != password)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter password:");
                        if (password == Console.ReadLine())
                        {
                            Console.WriteLine("Password is valid");
                            Console.WriteLine("Successful login!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Password is incorrect. Try again.");
                            continue;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Username does no exist. Try again.\n");
                    continue;
                }
            }
        }
    }
}