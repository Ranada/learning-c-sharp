using AlgoLibrary;

namespace HeapPractice;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello from Program.cs");

        var heap = new Heap();

        Console.WriteLine("Heap length: {0}", heap.List.Count);
    }
}
