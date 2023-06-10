namespace FreqCounter;

class Program
{
    static void DisplayFreqCounter(int[] arr)
    {
        Dictionary<int, int> freqCounter = new Dictionary<int, int>();

        foreach (int item in arr)
        {
            if (freqCounter.ContainsKey(item))
            {
                freqCounter[item]++;
            }
            else
            {
                freqCounter[item] = 1;
            }
        }

        foreach (KeyValuePair<int, int> pair in freqCounter)
        {
            Console.WriteLine(pair.Key + "->" + pair.Value + " times");
        }
    }
    
    static void Main(string[] args)
    {
        DisplayFreqCounter(new int[] {1, 1, 1, 3, 3, 5});
    }
}
