using System.Runtime.CompilerServices;
using System.Transactions;

namespace _4_64_TernaryOperatorTempCheck
{
    internal class Program
    {
        static string entry;
        static bool entryIsInt;
        static int temp;
        static string stateOfMatter;
        static void Main(string[] args)
        {
            while (entry != "exit") { 
                Console.Write("Enter a temperature: ");
                entry = Console.ReadLine();

                entryIsInt = int.TryParse(entry, out temp);

                if (entryIsInt)
                {
                    stateOfMatter = temp <= 15 ? "It is too cold here.\n" : temp >= 16 && temp <= 28 ? "It is ok\n" : "It is hot here.\n";
                    Console.WriteLine(stateOfMatter);
                }
                else
                {
                    Console.WriteLine("Not a valid temperature.");
                }
            }
            Console.WriteLine("Exiting program. Have a nice day!");
        }

        public static void CheckTemp(int temp) { }
    }
}

/*
We have studied ternary operators and their usage so here is a small challenge for you. 
Let's create a small application that takes a temperature value as input and checks if the input is an integer or not.

If the input value is not an integer value, it should print to the console "Not a valid Temperature".

And if the input value is the valid integer then it should work as mentioned below.

If input temperature value is <=15 it should write "it is too cold here" to the console.

If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.

If the input temperature value is > 28 it should write "it is hot here" to the console.

Make sure to use ternary operators and not if statements to check for the three conditions, 
however you can use if statement for the other conditions like to check if the entered value is a valid integer or not.
 */