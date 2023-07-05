namespace _7_104_JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] friendsFamily = new string[][]
            {
                new string[] {"Chris", "Jason", "Janice"},
                new string[] { "Marc", "Don", "Ariel"},
                new string[] {"Mupri", "Eric"}
            };

            foreach (string[] row in friendsFamily)
            {
                string friend = row[0];
                Console.Write($"{friend}'s famiy members are ");
                for (int i = 1; i < row.Length; i++)
                {
                    string familyMember = row[i];
                    Console.Write($"{familyMember}");

                    if (i != row.Length - 1) { 
                        Console.Write(", ");
                    }
                }
                Console.Write(".\n");
            }
        }
    }
}