namespace Parsing;

class Program
{
    static void Main(string[] args)
    {
        string numStr1 = "1";
        string numStr2 = "2.00";
        string numStr3 = "3000";
        string numStr4 = "3,000.00";

        // The Parse function attempts to parse a string into a number
        // but it might throw an exception, so we need to catch it

        int targetNum = 0;

        try
        {
            // TODO: Use Parse to try a simple integer

            // TODO: Use Parse to try a floating point number
            // This only works if the decimal value is 0

            // TODO: Use Parse to try a number with thousands marker

            // TODO: Use Parse to try a number with thousands marker AND decimal

            // TODO: This works with other types too, like bool

            // TODO: Or floating point numbers
        }
        catch
        {

        }

        // TODO: The TryParse function is similar but handles the exceptions for us
    }
}
