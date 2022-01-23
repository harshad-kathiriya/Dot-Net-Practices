using System;
using System.Collections;

// Access items by index
namespace DotnetPractice.DataStructures
{
    class ArrayListNonGenType
    {
        ArrayList arrayList;
        public ArrayListNonGenType()
        {
            arrayList = new ArrayList();
        }

        public void AddItem(string item)
        {
            arrayList.Add(item);
        }

        public void Display()
        {
            foreach (string item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}