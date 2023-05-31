namespace MatchingBrackets;

class Program
{
    static bool HasMatchingBrackets(string input)
    {
        Console.WriteLine(input);
        return true;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(HasMatchingBrackets("(Hello World)"));
        Console.WriteLine(HasMatchingBrackets("(Hello World"));
    }
}
