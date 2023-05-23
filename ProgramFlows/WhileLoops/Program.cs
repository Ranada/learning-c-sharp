using System;

namespace WhileLoops;

class Program
{
    static void Main(string[] args)
    {
        // While loop checks condition first before running
        string? input = "";
        // while(input != "exit")
        // {
        //     Console.WriteLine("Enter a command:");
        //     input = Console.ReadLine();
        //     Console.WriteLine("You entered: {0}\n", input);
        // }

        // Do-while loop runs at least one time
        do
        {
            Console.WriteLine("Enter a command:");
            input = Console.ReadLine();
            Console.WriteLine("You entered: {0}\n", input);
        }
        while(input != "exit");
    }
}
