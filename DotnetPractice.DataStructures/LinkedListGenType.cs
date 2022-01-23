using System;
using System.Collections.Generic;

// Access items sequentially
namespace DotnetPractice.DataStructures
{
    class LinkedListGenType
    {   
        LinkedList<string> linkedList;

        public LinkedListGenType()
        {
            linkedList = new LinkedList<string>();
        }

        public void AddItemAtFirst(string item)
        {
            linkedList.AddFirst(item);
        }

        public void AddItemAtLast(string item)
        {
            linkedList.AddLast(item);
        }

        public void RemoveLastItem()
        {
            linkedList.RemoveLast();
        }

        public void RemoveFirstItem()
        {
            linkedList.RemoveFirst();
        }

        public void Display()
        {
             Console.WriteLine("----------------");
            foreach(string str in linkedList)
            {
                Console.WriteLine(str);
            }
           
        }

        public void RemoveItem(string item)
        {
            linkedList.Remove(item);
        }

        public void PrintAllNode()
        {
            
            LinkedListNode<string> llist = linkedList.First;
            if(llist.List == null)
            {
                Console.WriteLine("No Item found");
            }

            while(llist != null)
            {
                Console.WriteLine(llist.Value);
                llist = llist.Next;
            }
        }


    }
}