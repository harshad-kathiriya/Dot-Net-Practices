using System;

namespace DotnetPractice.MergeTwoSortedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // LinkedListData link1 = new LinkedListData();
            // LinkedListData link2 = new LinkedListData();

            // link1.AddNode(1);
            // link1.AddNode(2);
            // link1.AddNode(4);

            // link2.AddNode(1);
            // link2.AddNode(3);
            // link2.AddNode(4);
            
            // // // print first linked list
            // link1.PrintAllNode();

            // // // print second linked list
            // // link2.PrintAllNode();

            // // merge two sorted link list
            // Node finalLink = MergedLinkedList(link1, link2);
            
            // Console.WriteLine("Print Merge Linked list");
            // // print merge link
            // //PrintAllNode(finalLink);
            
            Node node1 = new Node();
            Node node2 = new Node();
            node1 = AddNode(1);
            node1.Next = AddNode(2);
            node1.Next.Next = AddNode(4);
            
            node2 = AddNode(1);
            node2.Next = AddNode(3);
            node2.Next.Next = AddNode(5);

            PrintAllNode(node1);
            
            PrintAllNode(node2);

            // merge two sorted link list
            Node finalLink = MergedLinkedList(node1, node2);
            
            Console.WriteLine("Print Merge Linked list");

            // print merge link
            PrintAllNode(finalLink);
            
        }

        static Node AddNode(int data)
        {
            Node node = new Node();
            node.Data = data;
            node.Next = null;
            return node;
        }

        static Node MergedLinkedList(Node first, Node second)
        {
            Node finalLink = new Node();

            if(first == null && second== null)
                return null;
            else if(first == null)
                return second;
            else if(second == null)
                return first;

            if(first.Data <= second.Data)
            {
                finalLink = first;
                first = first.Next;
            } 
            else
            {
                finalLink = second;
                second = second.Next;
            }
            
            Node tempFinalLink = finalLink;

            while ((first != null && first.Next != null)
                 && (second!= null && second.Next != null))
            {
                Node temp = null;
                 if(first.Data <= second.Data)
                 {
                     temp = first;
                     first = first.Next; 
                     Console.WriteLine($"First{first.Data}");
                 } 
                 else
                 {
                     temp = second;
                     second = second.Next;
                     Console.WriteLine($"Second{second.Data}");
                 }
                 tempFinalLink.Next = temp;
                 tempFinalLink = temp;
                 Console.WriteLine($"tempFinalLink - {tempFinalLink.Data}");
            }

           if(first != null) 
           {
                tempFinalLink.Next = first;
           } 
           if (second != null)
           {
                tempFinalLink.Next = second;
           }

            return finalLink;
        }

       static void PrintAllNode(Node node)
        {
            while (node.Next != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
            Console.WriteLine(node.Data);
            
        }

    }

    class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }
    }

    


}
