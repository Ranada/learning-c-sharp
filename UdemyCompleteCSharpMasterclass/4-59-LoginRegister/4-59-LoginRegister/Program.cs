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
            bool usernameValid = false;
            bool passwordValid = false;
            string usernameEntry = "";
            string passwordEntry = "";

            while (!usernameValid)
            { 
                checkUsername(ref usernameEntry, ref usernameValid);
            }

            while (!passwordValid)
            {
                checkPassword(ref passwordEntry, ref passwordValid);
            }
        }

        public static void checkUsername(ref string usernameEntry, ref bool usernameValid) {
            Console.WriteLine("Enter username:");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Username is valid.\n");
                usernameValid = true;
            }
            else
            {
                Console.WriteLine("Username does no exist. Try again.\n");
            }
        }

        public static void checkPassword(ref string passwordEntry, ref bool passwordValid) {   
            Console.WriteLine("Enter password:");
            if (password == Console.ReadLine())
            {
                Console.WriteLine("Password is valid");
                Console.WriteLine("Successful login!");
                passwordValid = true;
                return;
            }
            else
            {
                Console.WriteLine("Password is incorrect. Try again.\n");
            }
        }
    }
}