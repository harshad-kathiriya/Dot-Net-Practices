using System;
using System.Collections;

// Store items as key/value pairs for quick look-up by key
namespace DotnetPractice.DataStructures
{
    class HashtableNonGenType
    {
        Hashtable hashTable;
        public HashtableNonGenType()
        {
            hashTable = new Hashtable();
        }

        public void AddItem(string item)
        {
            if(hashTable.ContainsKey(item))
            {
                Console.WriteLine("Key already existed !!");
            }
            else
            {
                hashTable.Add(item, item);    
            }            
        }

        public void Display()
        {
            foreach (DictionaryEntry item in hashTable)
            {
                Console.WriteLine($"Key - {item.Key}, Value - {item.Value}");
            }
        }

    }
}