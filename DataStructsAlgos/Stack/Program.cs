using System.Collections.Generic;

namespace Stack;

class Program
{
    static void PrintNextGreaterElement(int[] arr)
    {
        // If the arr is empty return

        // If the array length is 1 return -1

        // Create stack
        // Add push first item of array to stack

        // Loop through array starting from index 1
            // Peek at the top of the stack
            // If the current item is greater than peek item 
                // Print "peek item -> current item"
                // Pop stack
            // Else push the current item to the stack

        // While the stack is not null
            // Pop the stack and print "Popped item -> -1"
    }
    static void Main(string[] args)
    {
        int[] arr = new int[] {15, 8, 4, 10};
        // int[] arr = new int[] {2};
        // int[] arr = new int[] {2, 3};
        // int[] arr = new int[] {};

        PrintNextGreaterElement(arr);
    }
}
