using System;
using System.Collections.Generic;

// A sorted collection.
namespace DotnetPractice.DataStructures
{
    class SortedListGenType
    {
        SortedList<string,string> sortedList;

        public SortedListGenType()
        {
            sortedList = new SortedList<string,string>();
        }

        public void AddItem(string item)
        {
            sortedList.Add(item, item);
        }

        public void Display()
        {
            foreach(KeyValuePair<string,string> item in sortedList)
            {
                Console.WriteLine($"Key - {item.Key}, Value - {item.Value}");
            }
        }

    }
}