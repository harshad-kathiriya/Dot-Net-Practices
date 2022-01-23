
using System;
using System.Collections.Generic;

// Store items as key/value pairs for quick look-up by key
namespace DotnetPractice.DataStructures
{
    partial class DictionaryGenType
    {
        Dictionary<string,string> dict = null;

        public DictionaryGenType()
        {
            dict = new Dictionary<string, string>();
        }    

        public void AddItem(string item)
        {
            if(dict.ContainsKey(item))
            {
                Console.WriteLine("Key already existed !");                
            }
            else
            {
                dict.Add(item, item);
            }
        }

        public void Display()
        {
            Console.WriteLine($"Total count - {dict.Count} ");
            foreach (KeyValuePair<string,string> item in dict)
            {
                Console.WriteLine($"Key = {item.Key}, Value = {item.Value}");
            }

            foreach (string key in dict.Keys)
            {
                Console.WriteLine($"Key - {key} ");
            }

            foreach (string value in dict.Values)
            {
                Console.WriteLine($"Value - {value} ");
            }

        }

        public void RemoveItem(string key)
        {
            if(dict != null && dict.Count > 0)
            {
                dict.Remove(key);
            }
        }
    }
}