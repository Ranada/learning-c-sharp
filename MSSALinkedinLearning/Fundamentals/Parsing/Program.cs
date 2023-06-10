using System.Globalization;

namespace Parsing;

class Program
{
    static void Main(string[] args)
    {
        string numStr1 = "1";
        string numStr2 = "2.00";
        string numStr3 = "3,000";
        string numStr4 = "3,000.00";

        // The Parse function attempts to parse a string into a number
        // but it might throw an exception, so we need to catch it

        int targetNum = 0;

        try
        {
            // TODO: Use Parse to try a simple integer
            targetNum = int.Parse(numStr1);
            Console.WriteLine(targetNum);

            // TODO: Use Parse to try a floating point number
            // This only works if the decimal value is 0
            targetNum = int.Parse(numStr2, NumberStyles.Float);
            Console.WriteLine(targetNum);

            // TODO: Use Parse to try a number with thousands marker
            targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
            Console.WriteLine(targetNum);

            // TODO: Use Parse to try a number with thousands marker AND decimal
            targetNum = int.Parse(numStr4, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint);
            Console.WriteLine(targetNum);

            // TODO: This works with other types too, like bool
            Console.WriteLine($"{bool.Parse("False")}");

            // TODO: Or floating point numbers
            Console.WriteLine($"{float.Parse("1.2345"):F1}");


        }
        catch
        {
            Console.WriteLine("Whoops. The conversion failed.");
        }

        // TODO: The TryParse function is similar but handles the exceptions for us
        bool success = false;
        success = Int32.TryParse(numStr1, out targetNum);

        if (success)
        {
            Console.WriteLine($"String: {numStr1} Parsed as: {targetNum} Successful?: {success}");
        }
        else
        {
            Console.WriteLine($"Attempted to parse '{numStr1 ?? "<null>"}' failed.");
        }
    }
}
