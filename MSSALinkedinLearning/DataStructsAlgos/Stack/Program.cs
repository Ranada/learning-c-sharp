using System.Collections.Generic;

namespace Stack;

class Program
{
    static void PrintNextGreaterElement(int[] arr)
    {
        Console.WriteLine("-----------------------");

        if (arr.Length == 0)
        {
            Console.WriteLine("Array is empty or null");
            return;
        }

        Stack<int> stack = new Stack<int>();
        stack.Push(arr[0]);

        for (int index = 1; index < arr.Length; index++)
        {
            int current = arr[index];

            if (stack.Count > 0)
            {
                int popped = stack.Pop();

                while (popped < current)
                {
                    Console.WriteLine(popped + "->" + current);
                    if (stack.Count == 0)
                    {
                        break;
                    }
                    popped = stack.Pop();
                }

                if (popped > current)
                {
                    stack.Push(popped);
                }
            }
            stack.Push(current);
        }

        while(stack.Count > 0)
        {
            Console.WriteLine(stack.Pop() + "->" + -1);
        }

    }
    static void Main(string[] args)
    {
        int[] arr1 = new int[] { 15, 8, 4, 10 };
        int[] arr2 = new int[] { 2 };
        int[] arr3 = new int[] { 2, 3 };
        int[] arr4 = new int[] { };

        PrintNextGreaterElement(arr1);
        PrintNextGreaterElement(arr2);
        PrintNextGreaterElement(arr3);
        PrintNextGreaterElement(arr4);
    }
}
