namespace _3_56_TryParseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entry = "";
            int parsedNum = 0;

            do
            {
                Console.WriteLine("Enter temperature: ");
                entry = Console.ReadLine();

                bool success = int.TryParse(entry, out parsedNum);

                if (success)
                {
                    Console.WriteLine($"String number successfully parsed: {parsedNum}");
                }
                else
                {
                    Console.WriteLine("Could not parse entry into an integer");
                }

                Console.WriteLine();

            } while (entry != "exit");
        }
    }
}