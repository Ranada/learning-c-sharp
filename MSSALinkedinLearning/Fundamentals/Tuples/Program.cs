namespace Tupples;

class Program
{
    static void Main(string[] args)
    {
        // Tuple declared explicitly
        (int num1, int num2) tup1 = (20, 30);
        
        // Tuple declared implicitly with `Item#` keyword used to access values
        var tup2 = ("First item", 123.45f);

        Console.WriteLine($"BEFORE - tup1: {tup1}");
        Console.WriteLine($"BEFORE - tup2: {tup2}");

        tup1.num1 = 99;
        tup1.num2 = 777;

        tup2.Item1 = "New item 1";
        tup2.Item2 = 789.123f;
        
        Console.WriteLine($"AFTER - tup1: {tup1}");
        Console.WriteLine($"AFTER - tup2: {tup2}\n");

        // Example using tuple return function instead of `out` keyword
        (int, int) result = AddMultiply(20, 30);
        Console.WriteLine($"Sum: {result.Item1} Product: {result.Item2}");

    }

    static (int, int) AddMultiply(int num1, int num2)
    {
        int sum = num1 + num2;
        int product = num1 * num2;
        return (sum, product);
    }
}
