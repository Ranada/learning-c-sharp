namespace BinaryTree;

class Program
{
    class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Data { get; set; }
    }

    static void Main(string[] args)
    {
        //      4
        //   1     3
        // 8   9  6  

        Node nodeFour = new Node();
        nodeFour.Data = 4;

        Node nodeOne = new Node();
        nodeOne.Data = 1;

        Node nodeEight = new Node();
        nodeEight.Data = 8;

        Node nodeNine = new Node();
        nodeNine.Data = 9;

        Node nodeThree = new Node();
        nodeThree.Data = 3;

        Node nodeSix = new Node();
        nodeSix.Data = 6;

        nodeFour.Left = nodeOne;
        nodeFour.Right = nodeThree;

        nodeOne.Left = nodeEight;
        nodeOne.Right = nodeNine;

        nodeThree.Left = nodeSix;

        Console.WriteLine(nodeFour.Data);
        Console.WriteLine(nodeFour.Left.Data);
        Console.WriteLine(nodeFour.Right.Data);
        Console.WriteLine();
    }
}
