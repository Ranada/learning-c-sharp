namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer Data Types");

            Console.WriteLine("sybyte");                  
            Console.WriteLine("256 values (-128 to 127)");

            sbyte num1 = 1;
            sbyte num2 = 2;    
            sbyte sum = (sbyte)(num1 + num2);
            Console.WriteLine($"sbyt sum (sbyte)({num1.ToString()} + {num2.ToString()}) = {sum}");
            Console.WriteLine("Note: The sbyte num1 and num2 are treated as integers during the sum operation and need to be cast to `sbyte`");
            Console.WriteLine();

            Console.WriteLine("short");
            short shortNum = -32768;
            Console.WriteLine($"Whole numbers from -32768 to 32767. For example: {shortNum}");
            Console.WriteLine();

            Console.WriteLine("int");
            int intNum = -2147483648;
            Console.WriteLine($"Whole numbers from -2,147,483,648 to 2,147,483,648. For example: {intNum}");
            
            Console.WriteLine();Console.WriteLine("long");
            long longNum = -9223327036854775808;
            Console.WriteLine($"Whole numbers from -9,223,327,036,854,775,808 to 9,223,327,036,854,775,807. For example: {longNum}");
            Console.WriteLine();

            Console.WriteLine(); Console.WriteLine("float");
            float x = 99.99f;
            Console.WriteLine($"Requires 'f' suffix. Allows decimals and a range from 1.5 x 10^-45 to 3.4 x 10^38. For example: {x}");
            Console.WriteLine("7-digit precision");
            Console.WriteLine();

            Console.WriteLine(); Console.WriteLine("double");
            double doubleNum = 1.5;
            Console.WriteLine($"Does not require suffix. Allows decimals with a higher rane than float. For example: {doubleNum}");
            Console.WriteLine("15-digit precision");
            Console.WriteLine();
        }
    }
}