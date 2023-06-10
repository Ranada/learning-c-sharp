using System.Collections.Generic;
namespace FindMissingElements;

class Program
{
    static List<int> FindMissingElements(int[] firstArray, int[] secondArray)
    {
        List<int> missingElements = new List<int>();
        HashSet<int> secondItemsHash = new HashSet<int>();

        foreach (int item in secondArray)
        {
            secondItemsHash.Add(item);
        }

        foreach (int item in firstArray)
        {
            if (!secondItemsHash.Contains(item))
            {
                missingElements.Add(item);
            }
        }

        return missingElements;
    }

    static void Main(string[] args)
    {
        FindMissingElements(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3 }).ForEach(Console.WriteLine); // Expect {4, 5}
        Console.WriteLine();
        FindMissingElements(new int[] { 3, 2 ,8, 4, 5 }, new int[] { 5, 7, 3, 0, 2 }).ForEach(Console.WriteLine); // Expect {8, 4}
    }
}
