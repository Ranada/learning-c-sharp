using System.Text;
namespace ReverseEachWord;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ReverseEachWord("Taylor is a great worker"));
        Console.WriteLine(ReverseEachWord(null));
        Console.WriteLine(ReverseEachWord("racer racecar madam"));
        Console.WriteLine(ReverseEachWord("what can I do today"));
        Console.WriteLine(ReverseEachWord(" "));
    }

    static String? ReverseEachWord(String? sentence)
    {
        if (string.IsNullOrEmpty(sentence))
        {
            return sentence;
        }

        StringBuilder result = new StringBuilder(sentence.Length);
        string[] wordsArray = sentence.Split(" ");

        for (int index = 0; index < wordsArray.Length; index++)
        {
            String word = wordsArray[index];
            result.Append(Reverse(word));

            if (index != wordsArray.Length - 1)
            {
                result.Append(" ");
            }
        }

        return result.ToString();
    }
    static String Reverse(String word)
    {
        if (string.IsNullOrEmpty(word))
        {
            return word;
        }

        StringBuilder reversed = new StringBuilder(word.Length);

        for (int index = word.Length - 1; index >= 0; index--)
        {
            char c = word[index];
            reversed.Append(c);
        }

        return reversed.ToString();
    }

}
