using System.Collections.Generic;

namespace Stack;

class Program
{
    static void PrintNextGreaterElement(int[] arr)
    {
        // If the arr is empty return
        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("Array is empty or null");
            return;
        }

        // If the array length is 1, print "first item -> -1"
        if (arr.Length == 1)
        {
            Console.WriteLine($"{arr[0]} -> -1");
            return;
        }

        // Create stack
        Stack<int> stack = new Stack<int>();

        // Add push first item of array to stack
        stack.Push(arr[0]);

        // Loop through array starting from index 1
        for (int index = 1; index < arr.Length; index++)
        {
            // Peek at the top of the stack
            int topItem = stack.Peek();
            int currentItem = arr[index];

            // If the current item is greater than peek item
            if (currentItem > topItem)
            {
                // Print "peek item -> current item"
                Console.WriteLine($"{topItem} -> {currentItem}");
                // Pop stack
                stack.Pop();
            }
            else
            {
                // Else push the current item to the stack
                stack.Push(currentItem);
            }

            if (index == arr.Length -1)
            {
                stack.Push(currentItem);
            }
        }

        // While the stack is not null
        // Pop the stack and print "Popped item -> -1"
        foreach (int num in stack)
        {
            Console.WriteLine($"{num} -> -1");
        }

    }
    static void Main(string[] args)
    {
        int[] arr = new int[] { 15, 8, 4, 10 };
        // int[] arr = new int[] {2};
        // int[] arr = new int[] {2, 3};
        // int[] arr = new int[] {};

        PrintNextGreaterElement(arr);
    }
}
