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
                    root.Left = Insert(root.Left, value);
                }
                if (value > root.Data)
                {
                    root.Right = Insert(root.Right, value);
                }
            }
            return root;
        }

        public static void InOrderTraversal(Node? root)
        {
            if (root == null)
            {
                return;
            }

            InOrderTraversal(root.Left);
            Console.Write(root.Data + "->");
            InOrderTraversal(root.Right);
        }
        public static bool Search(Node? root, int value)
        {
            if (root == null)
            {
                return false;
            }

            Console.Write(root.Data + "->");

            if (value < root.Data)
            {
                return Search(root.Left, value);
            }
            else if (value > root.Data)
            {
                return Search(root.Right, value);
            }
            else
            {
                return true;
            }
        }
    }

    static void Main(string[] args)
    {
        //          4
        //      2       6
        //  -10   3       10
        //     -5       8    99
        Node? rootNode = new Node();
        rootNode.Data = 4;

        BinarySearchTree.Insert(rootNode, 2);
        BinarySearchTree.Insert(rootNode, 6);
        BinarySearchTree.Insert(rootNode, 10);
        BinarySearchTree.Insert(rootNode, -10);
        BinarySearchTree.Insert(rootNode, 99);
        BinarySearchTree.Insert(rootNode, 3);
        BinarySearchTree.Insert(rootNode, -5);

        Console.WriteLine("Current BinarySearchTree");
        BinarySearchTree.InOrderTraversal(rootNode);
        Console.WriteLine("\n");


        Console.WriteLine("Search results");
        Console.WriteLine(BinarySearchTree.Search(rootNode, 4)); // True
        Console.WriteLine(BinarySearchTree.Search(rootNode, 6)); // True
        Console.WriteLine(BinarySearchTree.Search(rootNode, 10)); // True
        Console.WriteLine(BinarySearchTree.Search(rootNode, -10)); // True
        Console.WriteLine(BinarySearchTree.Search(rootNode, 99)); // True
        Console.WriteLine(BinarySearchTree.Search(rootNode, 7)); // False
        Console.WriteLine(BinarySearchTree.Search(rootNode, 0)); // False
    }
}
