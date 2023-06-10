// See https://aka.ms/new-console-template for more information
using System;

namespace VarsAndData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intro to variables and data types");
            Console.Write($"Size of int: {sizeof(int)} bytes\n");
            Console.Write($"Size of float: {sizeof(float)} bytes\n");
            Console.Write($"Size of decimal: {sizeof(decimal)} bytes\n");
            Console.Write($"Size of char: {sizeof(char)} bytes\n\n");
            
            // Basic value type variables
            int intNum = 99;
            float floatNum = 123.45f;
            decimal decimalNum = 1.2345m;
            char character = 'z';

            // Declare a string with an initial value
            string word = "hello";

            // Declare an implicitely typed variable
            var implicitString = "Implicit String";
            var implicitInt = 55;

            // Declare an empty array that can hold five integers
            int[] intArray = new int[5];
            Console.Write($"Size of new int[5]: {intArray.Length * sizeof(int)} bytes\n\n");

            // Declare an array of strings with initial values
            string[] stringArray = {"one", "two", "three"};
            Console.Write($"Size of stringArray: {stringArray.Length * sizeof(int)} bytes\n\n");

            // Print all the values from the variables above in a string
            Console.Write("Print example variable values\n");

            dynamic[] arr = {intNum, floatNum, decimalNum, character, word, implicitString, implicitInt, intArray, stringArray};
            for (int index = 0; index < arr.Length; index++)
            {
                dynamic item = arr[index];
                dynamic dataType = item.GetType();
                // dynamic size = System.Runtime.InteropServices.Marshal.SizeOf(item);

                Console.Write($"Index: {index}, Value: {item}, Data type: {dataType}\n");
            }

            // Declare a null object and print it
            object? obj = null;
            Console.Write($"\nNull object: {obj}\n\n");

            // Implicit type conversion example: int to bignumber
            Console.Write("Implicitly convert intNum of type integer to bigNum of type long\n");
            Console.Write($"BEFORE - intNum Value: {intNum}, Data type: {intNum.GetType()}\n");
            long bigNum;
            bigNum = intNum;
            Console.Write($"AFTER - bigNum Value: {bigNum}, Data type: {bigNum.GetType()}\n\n");

            // Explicit type conversion example: integer to float and print it
            Console.Write("Explicitly convert intNum to float data type\n");
            Console.Write($"BEFORE - intNum Value: {intNum}, Data type: {intNum.GetType()}\n");
            float i_to_f = (float)intNum;
            Console.Write($"AFTER - i_to_f Value: {i_to_f}, Data type: {i_to_f.GetType()}\n\n");
            
            // Explicit type conversion example: float to integer and print it
            Console.Write("Explicitly convert floatNum to integer data type\n");
            Console.Write($"BEFORE - floatNum Value: {floatNum}, Data type: {floatNum.GetType()}\n");
            int f_to_i = (int)floatNum;
            Console.Write($"AFTER - f_to_i Value: {f_to_i}, Data type: {f_to_i.GetType()}\n\n");
        }
    }
}
