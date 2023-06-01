namespace BinarySearchTree;


class Program
{
    class Node
    {
        public Node? Left { get; set; }
        public Node? Right { get; set; }
        public int? Data { get; set; }
    }

    class BinarySearchTree
    {
        public static Node Insert(Node? root, int value)
        {
            if (root == null)
            {
                root = new Node();
                root.Data = value;
            }
            else
            {
                if (value < root.Data)
                {
                    Console.WriteLine("Inserting on the LEFT");
                    root.Left = Insert(root.Left, value);
                }
                if (value > root.Data)
                {
                    Console.WriteLine("Inserting on the Right");
                    root.Right = Insert(root.Right, value);
                }
            }
            return root;
        }
    }

    static void Main(string[] args)
    {
        Node? rootNode = new Node();
        rootNode.Data = 4;

        BinarySearchTree.Insert(rootNode, 2);
        BinarySearchTree.Insert(rootNode, 6);
        BinarySearchTree.Insert(rootNode, 10);
        BinarySearchTree.Insert(rootNode, -10);
        BinarySearchTree.Insert(rootNode, 99);
    }
}
