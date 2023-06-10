namespace RotateArray;

class Program
{
    static void Main(string[] args)
    {
        int[] input = { 1, 2, 3, 4, 5, 6 };

        Console.WriteLine("BEFORE");
        Console.WriteLine(String.Join(",", input) + "\n");

        // RotateArrayLeft(input);
        // RotateArrayLeft(input);

        RotateArrayRight(input);
        RotateArrayRight(input);

        Console.WriteLine("AFTER");
        Console.WriteLine(String.Join(",", input) + "\n");
    }

    static void RotateArrayLeft(int[] input)
    {
        int temp = input[0];

        for (int index = 0; index < input.Length - 1; index++)
        {
            input[index] = input[index + 1];
        }
        input[input.Length - 1] = temp;
    }

    static void RotateArrayRight(int[] input)
    {
        int temp = input[input.Length - 1];

        for (int index = input.Length - 1; index > 0; index--)
        {
            input[index] = input[index - 1];
        }
        input[0] = temp;
    }
}

// 1,2,3,4,5,6
// ^
// Save first index num in temp
// Shift all the numbers to the left
// Add temp to last index