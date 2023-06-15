namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer Data Types");

            sbyte num1 = 1;
            sbyte num2 = 2;
            sbyte sum = (sbyte)(num1 + num2);
            Console.WriteLine($"sbyt sum (sbyte)({num1.ToString()} + {num2.ToString()}) = {sum}");
            Console.WriteLine("Note: the sbyte num1 and num2 are treated as integers during the sum operation and need to be cast to `sbyte`");

        }
    }
}