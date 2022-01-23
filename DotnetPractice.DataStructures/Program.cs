using System;

namespace DotnetPractice.DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Structure
            Console.WriteLine("Data Structure");
            Console.WriteLine("---------------");
            Console.WriteLine("1. Dictionary // Generic Type - System.Collections.Generic");
            Console.WriteLine("2. Hashtable // Non-Generic Type - System.Collections");
            Console.WriteLine("3. List<T> // Generic Type - System.Collections.Generic");
            Console.WriteLine("4. ArrayList // Non-Generic Type - System.Collections");
            Console.WriteLine("5. Queue // Generic Type - System.Collections.Generic");
            Console.WriteLine("6. Stack // Generic Type - System.Collections.Generic");
            Console.WriteLine("7. LinkedList // Generic Type - System.Collections.Generic");
            Console.WriteLine("8. SortedList // Generic Type - System.Collections.Generic");
            Console.WriteLine("9. HashSet // Generic Type - System.Collections.Generic");
            Console.WriteLine("10. SortedSet // Generic Type - System.Collections.Generic");
            Console.WriteLine("11. Struct // Data Type ");

            string input = Console.ReadLine();
            Execute(Convert.ToInt32(input));

        }

        static void Execute(int i)
        {
            switch (i)
            {
                case 1: //  Dictionary
                    CallDictionary();
                    break;
                case 2: // Hashtable
                    CallHashTable();
                    break;
                case 3: // List<T>
                    CallList();
                    break;   
                case 4: // ArrayList
                    CallArrayList();
                    break;
                case 5: // Queue
                    CallQueue();
                    break;
                case 6: // Stack
                    CallStack();
                    break;
                case 7: // LinkedList
                    CallLinkedList();
                    break;
                case 8: // Sorted List
                    CallSortedList();
                    break;
                case 9: // HashSet
                    CallHashSet();
                    break;
                case 10: // SortedSet
                    CallSortedSet();
                    break;
                case 11: // Struct Datatype
                    CallStructDataType();
                    break;

                default:
                    break;
            }
        }

        static void CallDictionary()
        {
            DictionaryGenType dictionaryGenType = new DictionaryGenType();
            dictionaryGenType.AddItem("txt");
            dictionaryGenType.AddItem("png");
            dictionaryGenType.AddItem("txt");
            dictionaryGenType.AddItem("doc");
            dictionaryGenType.Display();

            // remove item
            dictionaryGenType.RemoveItem("png");
            dictionaryGenType.Display();

        }

        static void CallHashTable()
        {
            HashtableNonGenType hashtableNonGenType = new  HashtableNonGenType();
            hashtableNonGenType.AddItem("txt");
            hashtableNonGenType.AddItem("png");
            hashtableNonGenType.AddItem("txt");
            hashtableNonGenType.AddItem("doc");
            hashtableNonGenType.Display();

        }

        static void CallList()
        {
            ListGenType listGenType = new ListGenType();
            listGenType.AddItem(new Items() { id = 1, name = "Item 1", price = 100.4F });
            listGenType.AddItem(new Items() { id = 2, name = "Item 2", price = 140.4F });
            listGenType.AddItem(new Items() { id = 3, name = "Item 3", price = 230.4F });
            listGenType.Display();
            listGenType.CheckItem(new Items { id=2 });

            listGenType.InsertItem(2, new Items() { id = 201, name = "Item 201", price = 180.4F });

            listGenType.Display();

            listGenType.RemoveItem(1);

            listGenType.Display();
        }

        static void CallArrayList()
        {
            ArrayListNonGenType arrayListNonGenType = new ArrayListNonGenType();
            arrayListNonGenType.AddItem("Red");
            arrayListNonGenType.AddItem("Blue");
            arrayListNonGenType.AddItem("Black");
            arrayListNonGenType.AddItem("Green");
            arrayListNonGenType.Display();            
        }

        static void CallQueue()
        {
            QueueGenType queueGenType = new QueueGenType();
            queueGenType.AddItem("One");
            queueGenType.AddItem("Two");
            queueGenType.AddItem("Three");
            queueGenType.AddItem("Four");
            queueGenType.Display();
            queueGenType.RemoveItem();
            queueGenType.Display();

        }

        static void CallStack()
        {
            StackGenType stackGenType = new StackGenType();
            stackGenType.AddItem("Item1");
            stackGenType.AddItem("Item2");
            stackGenType.AddItem("Item3");
            stackGenType.Display();
            stackGenType.RemoveItem();
            stackGenType.Display();
            stackGenType.ClearStack();
            stackGenType.Display();
        }

        static void CallLinkedList()
        {
            LinkedListGenType linkedListGenType = new LinkedListGenType();
            linkedListGenType.AddItemAtFirst("Red");
            linkedListGenType.AddItemAtFirst("Blue");
            linkedListGenType.AddItemAtLast("Green");
            linkedListGenType.AddItemAtLast("Black");
            linkedListGenType.PrintAllNode();
                        
            linkedListGenType.RemoveFirstItem();
            linkedListGenType.RemoveLastItem();
            linkedListGenType.Display();
            linkedListGenType.RemoveItem("Red");
            linkedListGenType.Display();
            
        }

        static void CallSortedList()
        {
            SortedListGenType sortedListGenType = new SortedListGenType();
            sortedListGenType.AddItem("Red");
            sortedListGenType.AddItem("Blue");
            sortedListGenType.AddItem("Green");
            sortedListGenType.AddItem("Violate");
            sortedListGenType.AddItem("Yellow");
            sortedListGenType.Display();
        }

        static void CallHashSet()
        {
            HashSetGenType hashSetGenType = new HashSetGenType();
            hashSetGenType.AddItem(2);
            hashSetGenType.AddItem(4);
            hashSetGenType.AddItem(1);
            hashSetGenType.AddItem(8);
            hashSetGenType.Display();
        }

        static void CallSortedSet()
        {
            SortedSetGenType sortedSetGenType = new SortedSetGenType();
            sortedSetGenType.AddItem(3);
            sortedSetGenType.AddItem(2);
            sortedSetGenType.AddItem(5);
            sortedSetGenType.AddItem(1);
            sortedSetGenType.Display();
        }

        static void CallStructDataType()        
        {
            People people = new People();
            people.name = "John";
            people.address.city = "New York";
            people.address.state = "NY";

            StructDataType structDataType = new StructDataType(people);
            structDataType.Display();
        }
    }
}
