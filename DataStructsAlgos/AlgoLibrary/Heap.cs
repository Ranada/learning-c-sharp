namespace AlgoLibrary
{
    public class Heap
    {
        public List<int> nodeList {  get; set; }
        public int Length { get { return nodeList.Count; } }

        public Heap()
        {
            nodeList = new List<int>() { 0 };
        }
    }
}
