namespace _3_56_TryParseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entry = "";
            int temp = 0;
            int numTemp = 0;

            do
            {
                Console.WriteLine("Enter temperature: ");
                entry = Console.ReadLine();

                bool success = int.TryParse(entry, out temp);

                if (success)
                {
                    numTemp = temp;
                    Console.WriteLine("String number successfully parsed");
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