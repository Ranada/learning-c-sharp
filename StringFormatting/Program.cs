namespace StringFormatting;

class Program
{
    static void Main(string[] args)
    {
        int[] quarter = { 1, 2, 3, 4 };
        int[] sales = { 100000, 150000, 200000, 22500 };
        double[] intlMixPct = { .386, .413, .421, .457 };
        string str1 = "TestString";
        int val1 = 1234;
        decimal val2 = 1234.5678m;

        // Basic formatting information
        Console.WriteLine("{0}", str1);

    }
}
