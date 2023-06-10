namespace StringOperations;

class Program
{
    static void Main(string[] args)
    {
        string outstr;
        string str1 = "The quick brown fox jumps over the lzy dog.";
        string str2 = "This is a string";
        string str3 = "THIS is a STRING";
        string[] strs = { "one", "two", "three", "four" };

        // TODO: Length of a string property
        int length = str1.Length;
        Console.WriteLine("Length of str1: {0}", length);

        // TODO: Access individual characters
        Console.WriteLine("Character at index 4 in str1 is: {0}", str1[4]);

        // TODO: Iterate over a string
        foreach (char c in str1)
        {
            Console.Write(c);
            if (c == 's')
            {
                Console.WriteLine();
                break;
            }
        }

        // TODO: String Concat method
        outstr = String.Concat(strs);
        Console.WriteLine("Concatenated string with array of string: {0}", outstr);
        
        outstr = String.Concat(str1, str2, str3);
        Console.WriteLine("Concatenated string with string arguments: {0}", outstr);

        // TODO: String Join method
        outstr = String.Join('.', strs);
        Console.WriteLine("Join string with array of string: {0}", outstr);
        
        outstr = String.Join("---", str1, str2, str3);
        Console.WriteLine("Join string with string arguments: {0}", outstr);

        // TODO: String comparison
        // Compare will perform an ordinal comparison and return:
        // < 0 if first string comes before second string
        // 0 if first string equals second string
        // > 0 if first string comes after the second in sort ordr

        int result1 = String.Compare("stuff", "Stuff"); // Expect to return -1
        Console.WriteLine("Compare 'stuff' vs 'Stuff' results in: {0}", result1);
        
        int result2 = String.Compare("bcd", "acd"); // Expect to return 1
        Console.WriteLine("Compare 'bcd' vs 'acd' results in: {0}", result2);
        
        int result3 = String.Compare("equal", "equal"); // Expect to return 0
        Console.WriteLine("Compare 'equal' vs 'equal' results in: {0}", result3);

        // TODO: Compare strings using Equals method
        Console.WriteLine("Use Equal method on 'Hello' vs 'Hello' results in: {0}", String.Equals("Hello", "Hello")); // Expect true

        // TODO: Search string using IndexOf method
        int index = str1.IndexOf("qui"); // Expect 4
        Console.WriteLine("Index of 'qui' in str1 is: {0}", index);

        // TODO: Replace string using Replace method
        outstr = str1.Replace("fox", "wombat");
        Console.WriteLine("Replace 'fox' with 'wombat' in str1 -> {0}", outstr);
    }
}
