﻿namespace CyclicLinkedList;

class CustomLinkedList
{
    Node? head;

    public class Node
    {
        public int data;
        public Node? next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    public Boolean hasCycle()
    {
        HashSet<int> visitedNodes = new HashSet<int>();

        if (head == null || head.next == null)
        {
            return false;
        }

        Node? curr = head;

        while (curr != null)
        {
            Console.WriteLine(curr.data);
            if (visitedNodes.Contains(curr.data))
            {
                Console.WriteLine("The list has a cycle!");
                return true;
            }
            else
            {
                visitedNodes.Add(curr.data);
            }
            curr = curr.next;
        }

        Console.WriteLine("The list is linear.");

        return false;
    }

    static void Main(string[] args)
    {
        CustomLinkedList noCycleLinkedList = new CustomLinkedList();
        Node firstNode = new Node(3);
        Node secondNode = new Node(4);
        Node thirdNode = new Node(5);
        Node fourthNode = new Node(6);

        noCycleLinkedList.head = firstNode;
        firstNode.next = secondNode;
        secondNode.next = thirdNode;
        thirdNode.next = fourthNode;

        Console.WriteLine("----First linked list----");
        Console.WriteLine(noCycleLinkedList.hasCycle());
        Console.WriteLine();

        CustomLinkedList cycleLinkedList = new CustomLinkedList();
        cycleLinkedList.head = firstNode;
        thirdNode.next = secondNode;

        Console.WriteLine("----Second linked list----");
        Console.WriteLine(cycleLinkedList.hasCycle());
        Console.WriteLine();
    }
}
