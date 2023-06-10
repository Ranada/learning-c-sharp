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

        Console.WriteLine("Example use of `out` keyword");
        int sum, product;
        OutFunc(20, 30, out sum, out product);
        Console.WriteLine($"Sum: {sum} Product: {product}");

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

    // Using `out` keyword used to return multiple values. Found in older C# code. Tuples structure is now the preferred method.
    static void OutFunc(int num1, int num2, out int sum, out int product)
    {
        sum = num1 + num2;
        product = num1 * num2;
    }
}
