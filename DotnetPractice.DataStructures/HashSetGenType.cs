using System;
using System.Collections.Generic;

// A set for mathematical functions.
// The HashSet<T> class provides high-performance set operations. 
// A set is a collection that contains no duplicate elements, and whose elements are in no particular order.
namespace DotnetPractice.DataStructures
{
    class HashSetGenType
    {
        HashSet<int> hashset;

        public HashSetGenType()
        {
            hashset = new HashSet<int>();
        }

        public void AddItem(int item)
        {
            hashset.Add(item);
        }

        public void Display()
        {
            foreach(int item in hashset)
            {
                Console.WriteLine(item);
            }
        }

        

    }
}