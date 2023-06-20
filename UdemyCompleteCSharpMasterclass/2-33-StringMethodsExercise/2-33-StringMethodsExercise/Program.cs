namespace _2_33_StringMethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? entry;
            do {
                Console.WriteLine("Please enter your name and press enter:");
                entry = Console.ReadLine();

                Console.WriteLine($"Uppercase: {entry?.ToUpper()}");
                Console.WriteLine($"Lowercase: {entry?.ToLower()}");
                Console.WriteLine($"Trimmed leading/ending whitespace: {entry?.Trim()}\n");

                if (entry.Length >= 4) { 
                    Console.WriteLine($"Substring with length of 4: {entry?.Substring(0, 4)}\n");
                }
            } while (entry != "exit");
        }
    }
}