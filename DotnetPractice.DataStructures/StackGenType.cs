using System;
using System.Collections.Generic;

// Use data Last-In-First-Out (LIFO)
namespace DotnetPractice.DataStructures
{
    class StackGenType
    {
        Stack<string> stack;

        public StackGenType()
        {
            stack = new Stack<string>();            
        }

        public void AddItem(string item)
        {
            stack.Push(item);
        }

        public void Display()
        {
            if(stack != null && stack.Count == 0)
            {
                Console.WriteLine("No Items found in stack");
                return;
            }
            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
        }

        public void RemoveItem()
        {
            stack.Pop();
        }

        public void ClearStack()
        {
            stack.Clear();
        }


    }
}