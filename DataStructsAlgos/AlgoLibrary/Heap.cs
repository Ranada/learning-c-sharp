namespace AlgoLibrary;

public class Heap
{
    public List<int> List { get; set; }

    public Heap()
    {
        List = new List<int>() { 0 };
    }

    public void Push(int val)
    { 
        List.Add(val);

        int i = List.Count - 1;

        while (List[i] < List[i / 2])
        { 
            int temp = List[i];
            List[i] = List[i / 2];
            List[i / 2] = temp;
            i /= 2;
        }
    }

    public int? Pop()
    {
        if (List.Count == 1) return null;

        if (List.Count == 2)
        {
            int lastNum = List[List.Count - 1];
            List.RemoveAt(List.Count - 1);
            return lastNum;
        }

        int result = List[1];

        // Add the value in the last index position to the first
        List[1] = List[List.Count - 1];

        // Remove the last index position form the list
        List.Remove(List.Count - 1);

        // Percolate down the first value while there is a left branch
        // If there is a right branch and the value of the right branch is less than the left branch and the current value is less than the right branch -> swap the values
        // Else if, the current value is less than the left branch -> swap values
        // Else, there's not where left to go -> return to exit the loop

        int i = 1;
        while (i * 2 < List.Count)
        {
            if (i * 2 + 1 < List.Count &&
                List[i * 2 + 1] < List[i * 2] &&
                List[i * 2 + 1] < List[i]  
               )
            {
                int temp = List[i];
                List[i] = List[i * 2 + 1];
                List[i * 2 + 1] = temp;
                i = i * 2 + 1;
            }
            else if (List[i * 2] < List[i])
            {
                int temp = List[i];
                List[i] = List[i * 2];
                List[i * 2] = temp;
                i = i * 2;
            }
            else
            {
                break;
            }
        
        }

        return result;
    }
}


