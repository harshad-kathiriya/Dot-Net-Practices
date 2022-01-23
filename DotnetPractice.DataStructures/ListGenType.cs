using System;
using System.Collections.Generic;

// Access items by index
namespace DotnetPractice.DataStructures
{
    class ListGenType
    {
        List<Items> list;
        
        public ListGenType()
        {
            list = new List<Items>();
        }

        public void AddItem(Items item)
        {
            list.Add(item);
        }

        public void Display()
        {
            foreach(Items item in list)
            {
                Console.WriteLine($"Id - {item.id}, Name - {item.name}, Price - {item.price}");
            }
            Console.WriteLine($"Item - {list[0].name}");
        }

        public void CheckItem(Items item)
        {
            if(list.Contains(item))
            {
                Console.WriteLine("Found !!");
            }
            else
            {
                Console.WriteLine("Not Found !!");                
            }
        }

        public void InsertItem(int position, Items item)
        {
            list.Insert(position, item);
        }

        public void RemoveItem(int position)
        {
            list.RemoveAt(position);
        }
    }

    class Items
    {
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
    }
}