namespace MatchingBrackets;

class Program
{
    static bool HasMatchingBrackets(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '(')
            {
                stack.Push(c);
            }

            if (c == ')')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(HasMatchingBrackets("(Hello World)")); // Expect True
        Console.WriteLine(HasMatchingBrackets("(stuff( more stuff))")); // Expect True
        Console.WriteLine(HasMatchingBrackets("(Hello World")); // Expect False
        Console.WriteLine(HasMatchingBrackets("(stuff)))) more stuff)")); // Expect False
    }
}
