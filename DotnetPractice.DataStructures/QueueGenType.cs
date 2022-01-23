using System;
using System.Collections.Generic;

// Use items first-in-first-out (FIFO)
namespace DotnetPractice.DataStructures
{
    class QueueGenType
    {
        Queue<string> queue;

        public QueueGenType()
        {
            queue = new Queue<string>();
        }

        public void AddItem(string item)
        {
            queue.Enqueue(item);
        }

        public void Display()
        {
            foreach(string item in queue)
            {
                Console.WriteLine(item);
            }
        }

        public void RemoveItem()
        {
            queue.Dequeue();
        }


    }
} 
