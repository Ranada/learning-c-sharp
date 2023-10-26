namespace AlgoLibrary;
using System.Collections.Generic;

public class MySelectionSort
{
    
    public static void SelectionSortList(List<int> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            int minIndex = i;
            for (int ptr = i + 1; ptr < list.Count; ptr++)
            {
                if (list[ptr] < list[minIndex])
                {
                    minIndex = ptr;
                }
            }
            
            int temp = list[i];
            list[i] = list[minIndex];
            list[minIndex] = temp;
        }
    }

    public static void PrintList(List<int> list)
    {
        Console.Write("{ ");

        foreach (int num in list)
        {
            Console.Write($"{num} ");
        }

        Console.WriteLine("}");
    }
}