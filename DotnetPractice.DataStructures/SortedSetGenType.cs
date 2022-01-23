using System;
using System.Collections.Generic;

// A set for mathematical functions
namespace DotnetPractice.DataStructures
{
    class SortedSetGenType
    {
        SortedSet<int> sortedSet;

        public SortedSetGenType()
        {
            sortedSet = new SortedSet<int>();
        }

        public void AddItem(int item)
        {
            sortedSet.Add(item);
        }

        public void Display()
        {
            foreach (int item in sortedSet)
            {
                Console.WriteLine(item);
            }
        }
        


    }
}