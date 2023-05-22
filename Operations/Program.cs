using System;

namespace Operations;
class Program
{
    static void Main(string[] args)
    {
        // Declare two int variables
        int num1 = 10;
        int num2 = 20;

        // Declare two string variables
        string str1 = "abcd";
        string str2 = "efgh";

        // Experiment with different math operators
        Console.WriteLine("---------Basic Math---------");
        Console.WriteLine((num2 / num1) * num2);
        Console.WriteLine(str1 + str2);

        // Experiment with increment/ decrement operators
        Console.WriteLine("---------Increment/Decrement---------");
        Console.WriteLine($"(Before) num1 = {num1}, num2 = {num2};");
        num1++;
        num2--;
        Console.WriteLine($"(After) num1 = {num1}, num2 = {num2};\n");

        // Operator shorthand
        Console.WriteLine("---------Operator shorthand---------");
        Console.WriteLine($"(Before) num1 = {num1}, num2 = {num2};");
        num1-=200;
        num2+=200;
        Console.WriteLine($"(After) num1 = {num1}, num2 = {num2};\n");

        // Comparison operators
        Console.WriteLine("---------Comparison operators---------");
        Console.WriteLine($"num1 > num2 && num2 >= 5 is {num1 > num2 && num2 >= 5}");
        Console.WriteLine($"num1 > num2 || num2 >= 5 is {num1 > num2 || num2 >= 5}\n");

        // Experiment with null-coalescing operators `??` and `??=`
        Console.WriteLine("---------Null-coalexing operators `??` and `??=`---------");
        string? str3 = null;
        Console.WriteLine(str3 ?? "`??` used Unknown string");
        str3 ??= "`??=` used to assign this string";
        Console.WriteLine(str3);
    }
}

