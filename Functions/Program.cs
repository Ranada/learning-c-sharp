namespace Functions;

class Program
{
    static void Main(string[] args)
    {
        PrintWithPrefix("This is an example with a default prefix.");
        PrintWithPrefix("###>", "This is an example with a prefix argument in order.");
        PrintWithPrefix(str: "This is an example using argument names out of order.", prefix: "%%%>");
        PrintWithPrefix(":D", "Let's convert miles to kilometers");
        
        Console.WriteLine("6.8 miles converts to {0} km", MilesToKm(6.8f));
        Console.WriteLine("1.5 miles converts to {0} km", MilesToKm(1.5f));
    }

    static void PrintWithPrefix(string str, string prefix = "")
    {
        Console.WriteLine($"{prefix}{str}");
    }

    static float MilesToKm(float miles)
    {
        float result = miles * 1.6f;
        return result;
    }
}
