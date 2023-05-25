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

        int num1 = 10;
        int num2 = 20;

        Console.WriteLine("\nThe value of num1 BEFORE calling TestFunc1 is: {0}", num1);
        TestFunc1(num1);
        Console.WriteLine("The value of num1 AFTER calling TestFunc1 is: {0}\n", num1);
        
        Console.WriteLine("The value of num2 BEFORE calling TestFunc2 is: {0}", num2);
        TestFunc2(ref num2);
        Console.WriteLine("The value of num2 AFTER calling TestFunc2 is: {0}\n", num2);
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

    static void TestFunc1(int num)
    {
        Console.WriteLine("TestFunc1 uses a copy of the argument.");
        num += 10;
        Console.WriteLine("The num incremented by ten in the function is: {0}", num);
    }
    
    static void TestFunc2(ref int num)
    {
        Console.WriteLine("TestFunc2 uses a copy of the argument.");
        num += 10;
        Console.WriteLine("The num incremented by ten in the function is: {0}", num);
    }
}
