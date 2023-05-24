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

        // TODO: Specifying numerical formatting
        // General format is {index[,aligntment]:[format]}
        // Common types are N (number), G (General), F (Fixed-point)
        // E (Exponential, D (Decimal), P (Percent), X (Hexadecimal),
        // C (Currency in local format)
        Console.WriteLine("Number: {0:N}, General: {0:G}, Fixed point: {0:F}, Exponential: {0:E}", val1);
        Console.WriteLine("Decimal: {0:E}, Number: {0:N}, Fixed point: {0:F}, General: {0:G}", val2);

        // TODO: Add a number after the format to specify precision
        Console.WriteLine("Decimal: {0:E3}, Number: {0:N7}, Fixed point: {0:F1}, General: {0:G3}", val2);

        // TODO: Formatting with alignment and spacing
        Console.WriteLine("\n-------Sales Data------");
        foreach (int q in quarter) {
            Console.Write("{0,12}", q);
        }
        Console.WriteLine();
        
        foreach (int sale in sales) {
            Console.Write("{0,12:C2}", sale);
        }
        Console.WriteLine();
        
        foreach (double pct in intlMixPct) {
            Console.Write("{0,12:P1}", pct);
        }
        Console.WriteLine();

        // 

    }
}
