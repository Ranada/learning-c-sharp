using System;

namespace ForLoops;

class Program
{
    static void Main(string[] args)
    {
        int myNum = 15;
        int[] nums = new int[] { 0, 99, 123, 345, 999, 2345, 2, 5 };
        string str = "The cow jumped over the moon.";

        //For loop
        Console.WriteLine("-----For Loop-----");
        for (int index = 0; index < myNum; index++)
        {
            Console.WriteLine("Index: {0}", index);
        }

        // Foreach-in-loop
        Console.WriteLine("\n-----Foreach-in-loop on array-----");
        foreach (int num in nums)
        {
            Console.WriteLine("Num: {0}", num);
        }

        Console.WriteLine("\n-----Foreach-in-loop counting 'o's in string-----");
        var count = 0;
        foreach (char c in str)
        {
            if (c == 'o')
            {
                count++;
            }
        }

        Console.WriteLine("String: {0}", str);
        Console.WriteLine("Number of o's in the string is: {0}\n", count);
    }
}
