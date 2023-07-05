namespace _7_105_ArrayArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] happiness = { 1, 5, 99, 1000, 50, 24 };
            SunIsShining(happiness);
        }

        public static void SunIsShining(int[] happiness)
        {
            Console.WriteLine("Let's boost the happiness!");
            foreach (int num in happiness) {
                Console.WriteLine($"{num} -> {num + 2}");
            }
        }
    }
}