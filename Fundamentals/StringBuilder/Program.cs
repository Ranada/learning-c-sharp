namespace StringBuilder;

using System.Text;
class Program
{
    static void Main(string[] args)
    {
        int jumpCount = 99;
        string[] animals = {"wombat", "unicorn", "lemur"};

        // TODO: create a StringBuilder
        StringBuilder sb = new StringBuilder("Initial string. ", 200);        

        // TODO: print some basic stats about the StringBuilder
        Console.WriteLine($"Capacity: {sb.Capacity} Length: {sb.Length}");

        // TODO: Add some string to the builder using Append
        sb.Append("Here's another string to append.");

        // TODO: AppendLine can append a line ending
        sb.AppendLine();
        
        // TODO: AppendFormat can be used to append formatted strings
        sb.AppendFormat("The dog jumped {0} times!", jumpCount);
        sb.AppendLine();
        
        // TODO: AppendJoin can iterate over a set of values
        sb.Append("The dog jumped over a ");
        sb.AppendJoin(", ", animals);
        sb.AppendLine(".");

        // TODO: Modify the content using Replace
        sb.Replace("dog", "dodo bird");

        // TODO: Insert content at any index
        sb.Insert(16, "Inserting this line at index 16. ");
        sb.AppendLine();
        
        // TODO: Convert to a single string
        Console.WriteLine($"Capacity: {sb.Capacity} Length: {sb.Length}");
        Console.WriteLine(sb.ToString());
    }
}
