using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace AverageScore
{
    internal class Program
    {
        static int sum = 0;
        static int scoreEntry = 0;
        static int entriesCount = 0;
        static string entry = "";
        static bool success = false;
        static double average;
        static void Main(string[] args)
        {
            Console.WriteLine("This is an average score calculator.");
            Console.WriteLine("Enter scores between 0 and 20.");
            Console.WriteLine("Enter -1 to calculate the average.\n");

            CalculateAverageScore();
        }

        public static void CalculateAverageScore() {

            while (entry != "-1") { 
                Console.Write("Enter score: ");
                entry = Console.ReadLine();

                success = int.TryParse(entry, out scoreEntry);

                if (success)
                {
                    if (scoreEntry == -1)
                    {
                        GetAverage();
                    }
                    if (ScoreInRange())
                    {
                        GetSum();
                    }
                }
                else 
                {
                    ErrorMessage();
                }

            } 
        }

        public static bool ScoreInRange()
        {
            if (scoreEntry >= 0 && scoreEntry <= 20)
            {
                return true;
            }
            else if (scoreEntry != -1)
            { 
                ErrorMessage();
            }
            return false;
        }

        public static void GetAverage()
        {
            if (entriesCount > 0)
            { 
                average = sum / (double)entriesCount;
            }
            Console.WriteLine($"Average score is: {average:N2}");
            return;
        }

        public static void GetSum()
        {
            sum += scoreEntry;
            entriesCount++;
        }

        public static void ErrorMessage()
        {
            Console.WriteLine("Score entry should be between 0 and 20. Try agin.");
        }
    }
}