namespace IsPalindrome;

class Program
{
    static void Main(string[] args)
    {
        // Palindrom Challenge Rules
        // Program read input and determines if palindrome
        // Must ignore case and punctuation
        // Function must be named IsPalindrome
        // Returns two values: Boolean and integer
        // Program runs until "exit" is typed

        // Test Cases
        // radar -> Palindrome: True, Length: 5
        // No 'X' in Nixon. -> Palindrome: True, Length: 16;
        // A man, a plan, a Canal Panama! -> 
        // Madam, I'm Adam. -> Palindrome: True, Length: 16
        // Hello world -> Palindrome: False, Length: 0
        // exit

        Console.WriteLine("Palindrome: {0}", IsPalindrome("Radar")); // Expect Palinedrome: True, Length: 5
        Console.WriteLine(IsPalindrome("No 'X' in Nixon.")); // Palindrome: True, Length: 16;
        Console.WriteLine(IsPalindrome("A man, a plan, a Canal Panama!")); // Palindrome: True, Length: 30
        Console.WriteLine(IsPalindrome("Madam, I'm Adam")); // Palindrome: True, Length: 16
        Console.WriteLine(IsPalindrome("Hello world")); // Hello world -> Palindrome: False, Length: 0

        // No 'X' in Nixon.
        // l
        //                r
    }

    static (bool, int) IsPalindrome(string str)
    {
        int l = 0;
        int r = str.Length - 1;

        while (l < r)
        {
            char leftChar = Char.ToLower(str[l]);
            char rightChar = Char.ToLower(str[r]);

            if (isAlphabet(leftChar) && isAlphabet(rightChar))
            {
                if (leftChar != rightChar) return (false, str.Length);
                l++;
                r--;
                continue;
            }
            else
            {
                if (!(isAlphabet(leftChar)))
                {
                    l++;
                }

                if (!(isAlphabet(rightChar)))
                {
                    r--;
                }
                continue;
            }

        }

        return (true, str.Length);
    }

    static bool isAlphabet(char c)
    {
        if (c >= 'a' && c <= 'z')
        {
            return true;
        }
        return false;
    }
}
