namespace _2_33_StringMethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? entry;
            string? @char = null;
            int? index;

            do {
                Console.WriteLine("Enter a string:");
                entry = Console.ReadLine();
                
                Console.WriteLine();

                Console.WriteLine("Enter a character to search:");
                @char = Console.ReadLine();

                index = entry?.ToUpper().IndexOf(@char.ToUpper());

                if (index >= 0)
                {
                    Console.WriteLine($"Character found at index: {index}");
                }
                else {
                    Console.WriteLine("Character not found.");
                }

                Console.WriteLine();

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