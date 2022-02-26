
using System;
using System.Collections.Generic;

namespace DotnetPractice.Practice
{
    class DLL
    {
       public   Node head;

        public void push(int new_data)
        {
            Node new_node = new Node(new_data);

            new_node.next = head;
            new_node.prev = null;

            if(head != null)
            {
                head.prev = new_node;
            }

            head = new_node;
        }

        public void InsertAfter(Node prev_node, int new_data)
        {
            if(prev_node == null)
            {
                Console.WriteLine("Node cannot be null");
                return;
            }

            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;

            new_node.prev = prev_node;

            if(new_node.next != null)
                new_node.next.prev = new_node;
        }

        public void append(int new_data)
            {
                /* 1. allocate node
                * 2. put in the data */
                Node new_node = new Node(new_data);
        
                Node last = head; /* used in step 5*/
        
                /* 3. This new node is going
                    to be the last node, so
                * make next of it as NULL*/
                new_node.next = null;
        
                /* 4. If the Linked List is empty,
                then make the new * node as head */
                if (head == null)
                {
                    new_node.prev = null;
                    head = new_node;
                    return;
                }
        
                /* 5. Else traverse till the last node */
                while (last.next != null)
                    last = last.next;
        
                /* 6. Change the next of last node */
                last.next = new_node;
        
                /* 7. Make last node as previous of new node */
                new_node.prev = last;
            }

             public void printlist(Node node)
            {
                Node last = null;
                Console.WriteLine("Traversal in forward Direction");
                while (node != null) {
                    Console.Write(node.data + " ");
                    last = node;
                    node = node.next;
                }
                Console.WriteLine();
                Console.WriteLine("Traversal in reverse direction");
                while (last != null) {
                    Console.Write(last.data + " ");
                    last = last.prev;
                }
            }
    }

    class Node
    {
        public Node prev;
        public Node next;
        public int data;

        public Node(int d)
        {   
            data= d;
        }
    }
    
}