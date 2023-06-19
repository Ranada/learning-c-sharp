namespace _2_29_ParsingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            Console.WriteLine($"{float.Parse(stringForFloat)} is {float.Parse(stringForFloat).GetType()} dataype");
            Console.WriteLine($"{Int32.Parse(stringForInt)} is {Int32.Parse(stringForInt).GetType()} dataype");
        }
    }
}