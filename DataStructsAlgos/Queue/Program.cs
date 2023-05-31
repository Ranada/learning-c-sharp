using System.Collections.Generic;

namespace Queue;

class Program
{
    static void printBinary(int n)
    {
        if (n <= 0)
        {
            return;
        }

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        for (int i = 0; i < n; i++)
        {
            int current = queue.Dequeue();
            Console.WriteLine(current);
            queue.Enqueue(current * 10);
            queue.Enqueue(current * 10 + 1);
        }



    }

    // queue: [110, 111, 1000, 1001, 1010, 1011]
    //1, 10, 11, 100, 101
    static void Main(string[] args)
    {
        printBinary(5);
    }
}
