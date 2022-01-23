using System;
using System.Collections.Generic;

namespace DotnetPractice.DetectCycleInLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // CreateLinkedList linkedList = new CreateLinkedList();
            // linkedList.PrintAllNode();
            // Console.WriteLine("Remove Test2");
            // linkedList.RemoveNode("Test2");
            // linkedList.PrintAllNode();
            // Console.WriteLine("Remove First Node");
            // linkedList.RemoveFirstNode();
            // linkedList.PrintAllNode();
            // Console.WriteLine("Remove Last Node");
            // linkedList.RemoveLastNode();
            // linkedList.PrintAllNode();

            LinkedListCycle linkedListCycle  = new LinkedListCycle();
            linkedListCycle.AddNode(1);
            linkedListCycle.AddNode(2);
            linkedListCycle.AddNode(3);
            linkedListCycle.PrintAllNode();
            linkedListCycle.DetectCycle();
            linkedListCycle.CreateCycle();
            linkedListCycle.DetectCycle();
 
        }
    }

    class CreateLinkedList    
    {
        LinkedList<string> link = new LinkedList<string>();

        public CreateLinkedList()
        {
            link.AddFirst("First");   
            link.AddLast("Test1");            
            link.AddLast("Test2");            
            link.AddLast("Last");

        }                     

        public void PrintAllNode()
        {
            foreach (string item in link)
            {
                Console.WriteLine(item);
            }
        }  

        public void RemoveNode(string node)
        {
            link.Remove(node);
        }

        public void RemoveFirstNode()
        {
            link.RemoveFirst();
        }

        public void RemoveLastNode()
        {
            link.RemoveLast();
        }
    }

    class LinkedListCycle
    {
        private Node head;
        
        public void AddNode(int data)
        {
            Node node = new Node(data);
            node.Next = head;
            head = node;
        }

        public void PrintAllNode()
        {
            while (head.Next != null)
            {
                 Console.WriteLine(head.Data);
                 head = head.Next;
            }
            Console.WriteLine(head.Data);

        }

        public void CreateCycle()
        {
            Node cur = head;
            while (cur.Next != null)
            {
                cur = cur.Next;
            }
            cur.Next = head;
        }

        public void DetectCycle()
        {
            Node lag = head;
            Node lead = head.Next;

            while (lead != null && lead.Next != null)
            {
                 if(lag == lead)
                 {
                     Console.WriteLine("Cycle Detected!!");
                     return;
                 }

                 lead = lead.Next;
            }
            Console.WriteLine("Cycle Not Detected!!");
        }

    }

    class Node
    {
        public Node Prev { get; set; }
        private int _data { get; set; }
        public Node Next { get; set; }

        public Node(int Data)
        {
            this._data = Data;
        }    

        public int Data { get { return this._data ; } }
    }
}
