namespace Exceptions;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 10001;
        int num2 = 10;
        int result;

        // Try, Catch, Finally statments
        try 
        {
            if (num1 > 1000)
            {
                throw new ArgumentOutOfRangeException("num1", "num1 is greater than 1000");
            }
            result = num1 / num2;
            Console.WriteLine("Result: {0}", result);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Whoops!");
            Console.WriteLine(e.Message);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Oh snap!");
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Note: this code is in the `finally` block which always runs");
        }
    } 
}
