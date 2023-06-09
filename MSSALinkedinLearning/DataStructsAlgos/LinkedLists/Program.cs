﻿namespace LinkedLists;

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

        public void Display()
        {
            Node? current = head;

            while (current != null)
            {
                Console.Write(current.data + "->");
                current = current.next;
            }
        }

        public void DeleteKthNodeFromEnd(int k)
        {
            if (head == null || k == 0)
            {
                return;
            }

            Node? first = head;
            Node? second = head;

            for (int i = 0; i < k; i++)
            {
                second = second.next;

                if (second?.next == null)
                {
                    if (i == k - 1)
                    {
                        head = head.next;
                    }
                    return;
                }

            }

            while (second.next != null)
            {
                first = first?.next;
                second = second.next;
            }

            first.next = first?.next?.next;
        }

        // k=3
        // 1->2->3->4->5->6
        //       f
        //                s

        public void DeleteLastHalf()
        {
            Node? current = head;
            if (head == null || head.next == null)
            {
                head = null;
            }

            Node? slow = head;
            Node? fast = head;
            Node? prev = null;

            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow?.next;
                fast = fast.next.next;
            }

            prev.next = null;
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

            Console.WriteLine("Before");
            linkedList.Display();
            Console.WriteLine();
            Console.WriteLine();

            // linkedList.DeleteLastHalf();
            linkedList.DeleteKthNodeFromEnd(3);

            Console.WriteLine("After");
            linkedList.Display();
            Console.WriteLine();
        }
    }
}


//      1->2->3->4->5->6->
//      s
//      f
//            p