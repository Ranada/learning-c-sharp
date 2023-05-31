namespace Stack;

class Program
{
    static void PrintNextGreaterElement(int[] arr)
    {
        Console.WriteLine("Inside PrintNextGreaterElement");
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
