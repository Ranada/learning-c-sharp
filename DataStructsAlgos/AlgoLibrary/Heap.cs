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
}


