using System;

namespace Comments;

class Program
{
    ///This is an example of XML comment documentation
    /// They start with triple-slashses and have a special syntax
    /// <summary>
    /// This is an example summary element
    /// </summary>
    /// <param name='args'>An array of string argument from the command line</param>
    /// <returns>
    /// No return value
    /// </returns>
    static void Main(string[] args)
    {
        // Single line comment
        
        Console.WriteLine("Hello, World!");

        /*
        Multi- line comments go here
        Another line
        Another line
        Another line
        Another line
        */
    }
}
