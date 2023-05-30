namespace RotateArray;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };

        Console.WriteLine("BEFORE");
        Console.WriteLine(String.Join(",", arr) + "\n");

        RotateArrayLeft(arr);
        RotateArrayLeft(arr);

        Console.WriteLine("AFTER");
        Console.WriteLine(String.Join(",", arr) + "\n");
    }

    static void RotateArrayLeft(int[] arr)
    {
        int temp = arr[0];

        for (int index = 0; index < arr.Length - 1; index++)
        {
            arr[index] = arr[index + 1];
        }
        arr[arr.Length - 1] = temp;
    }
}

// 1,2,3,4,5,6
// ^
// Save first index num in temp
// Shift all the numbers to the left
// Add temp to last index