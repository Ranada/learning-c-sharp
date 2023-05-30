namespace LinkedLists;

class Program
{

    public class CustomLinkedList
    {
        Node? head;

        public class Node
        {
            public int? data;
            public Node? next;

            public Node(int? d)
            {
                data = d;
            }
        }

        static void Main(string[] args)
        {
            CustomLinkedList linkedList = new CustomLinkedList();
            Node firstNode = new Node(1);
            Node secondNode = new Node(2);
            Node thirdNode = new Node(3);
            Node fourthNode = new Node(4);
            Node fifthNode = new Node(5);
            Node sixthNode = new Node(6);

            linkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;
            fourthNode.next = fifthNode;
            fifthNode.next = sixthNode;

           Node ptr = linkedList.head;

           
           while (ptr.next != null)
           {
            Console.WriteLine($"Value: {ptr.data}, Next Value: {ptr.next.data}");
            ptr = ptr.next;
           }

        }
    }
}

