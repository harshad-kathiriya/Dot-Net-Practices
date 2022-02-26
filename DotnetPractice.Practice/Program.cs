using System;
using System.Collections.Generic;
namespace DotnetPractice.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountString();

            //FindLargestWordFromDictionary();

            //FindSubArray();

            //FindLarestSubString();

            //FindTwoNonRepeatingNumber();
            //MetaStrings();
            //JumpingNumber();

            //MergeSort();
            //QuickSort();
            //HeapSort();
            //BFS();
            //Anagram();
            // Armstrong();
            //Fibonacci();
            //Factorial();
            //BitwiseAndShiftOperator();
            //DFS();
            //DoubleLinkedList();
            //MutliDimensionalArray();
            //FindLargetValueInEachLevel();
            MinJumpArray();
        }

        static void CountString()
        {
            // Count of strings that can be formed using a, b and c under given constraints
            Test1 test1 = new  Test1();
            Console.WriteLine(test1.CountStr(3 ,1 ,2));
        }

        static void FindLargestWordFromDictionary()
        {
            Test2 test2 = new Test2();
            test2.FindLargestWord_Optimize(new List<string>() {"ale", "apple", "monkey", "plea"}, "apple");
        }

        static void FindSubArray()
        {
            Test3 test3 = new Test3();
            test3.FindSubArray(new int[] {1,4,20,3,10,5}, 33);
            test3.FindSubArray(new int[] {1,4,0,0,3,10,5}, 7);
            test3.FindSubArray(new int[] {1,4}, 0);
            Console.WriteLine("Sliding Window Method");
            test3.FindSubArray_SlidingWindow(new int[] {1,4,20,3,10,5}, 33);
            test3.FindSubArray_SlidingWindow(new int[] {1,4,0,0,3,10,5}, 7);
            test3.FindSubArray_SlidingWindow(new int[] {1,4}, 0);            
        }

        static void FindLarestSubString()
        {
            Test4 test4 = new Test4();
            test4.FindLargestSubstringWithKUnique("aabbcc", 1);
            test4.FindLargestSubstringWithKUnique("aabbcc", 2);
            test4.FindLargestSubstringWithKUnique("aabbcc", 3);
            test4.FindLargestSubstringWithKUnique("aaabbb", 3);
        }

        static void FindTwoNonRepeatingNumber()
        {
            Test5 test5 = new Test5();
            test5.FindTwoNonRepeatingNumber(new int[] {2,4,7,9,4,2});
        }

        static void MetaStrings()
        {
            Test6 test6 = new Test6();
            test6.FindMetaStrings("geeks", "keegs");
            test6.FindMetaStrings("rsting", "string");
            test6.FindMetaStrings("Converse", "Conserve");
        }

        static void JumpingNumber()
        {
            Test7 test7 = new  Test7();
            Console.WriteLine("Check Jumping Number");
            test7.CheckJumpingNumber(121);
            test7.CheckJumpingNumber(7839);

            Console.WriteLine("Print All Jumping Number");
            test7.PrintAllJumpingNumberBFS(30);

        }

        static void MergeSort()
        {
            MergeSortTest mergeSortTest = new  MergeSortTest();
            mergeSortTest.Sort(new int[] {10,3,11,8,1});
            mergeSortTest.Sort(new int[] {5,8,3,2,1});
            
        }

        static void QuickSort()
        {
            QuickSortTest quickSortTest = new QuickSortTest();
            quickSortTest.QuickSort(new int[] {10,3,11,8,1});
            //quickSortTest.QuickSort(new int[] {8,9,3,5,6});
            
        }

        static void HeapSort()
        {
            HeapSortTest heapSortTest = new HeapSortTest();
            heapSortTest.HeapSort(new int[] {12,11,13,5,6,7});
        }

        static void BFS()
        {
            BFSGraph bfsGraph = new BFSGraph(4);
            bfsGraph.AddEdge(0,1);
            bfsGraph.AddEdge(0,2);
            bfsGraph.AddEdge(1,2);
            bfsGraph.AddEdge(2,0);
            bfsGraph.AddEdge(2,3);
            bfsGraph.AddEdge(3,3);
            
            Console.WriteLine("Following is Breadth-First traversal(starting from vertex 2)");
            bfsGraph.BFS(2);
            Console.WriteLine();

            Console.WriteLine("Following is Breadth-First traversal(starting from vertex 1)");
            bfsGraph.BFS(1);
            Console.WriteLine();
            
            Console.WriteLine("Following is Breadth-First traversal(starting from vertex 3)");
            bfsGraph.BFS(3);
            Console.WriteLine();
            
        }

        static void Anagram()
        {
            Anagram anagram = new Anagram();
            anagram.CheckAnagram("FIRED", "FRIED");
            anagram.CheckAnagram("AVD", "DFD");
            anagram.CheckAnagram("ABC", "ABCD");
        }

        static void Armstrong()
        {
            Armstrong armstrong = new Armstrong();
            armstrong.CheckArmstrong(153);
            armstrong.CheckArmstrong(157);
            armstrong.CheckArmstrong(111);
            
        }

        static void Fibonacci()
        {
            Fibonacci fibonacci = new  Fibonacci();
            fibonacci.PrintFibonacci(7);
            fibonacci.PrintFibonacci(10);
            fibonacci.PrintFibonacci(20);

            Console.WriteLine("Fibonacci with recursion");
            fibonacci.FiboWithRecursion(7);
        }

        static void Factorial()
        {
            Factorial factorial = new Factorial();
            factorial.GetFactorial(5);
        }

        static void BitwiseAndShiftOperator()
        {
            BitwiseAndShiftOperator bitwiseAndShiftOperator = new BitwiseAndShiftOperator();
           // bitwiseAndShiftOperator.FindElementThatAppearsOnce(new int[] {3,3,2,3});

           // Console.WriteLine("Detect if two integers have opposite signs");
           // bitwiseAndShiftOperator.DetectTwoIntegersHaveOppositeSigns(-100,200);

            // Console.WriteLine("Add 1 to a given number");
            // bitwiseAndShiftOperator.AddOneToGivenNumber(11);

            // Console.WriteLine("Find the Number Occurring Odd Number of Times");
            // bitwiseAndShiftOperator.FindTheNumberOccuringOddNumberofTimes(new int[] {1, 2, 3, 2, 3, 1, 3});
            // bitwiseAndShiftOperator.FindTheNumberOccuringOddNumberofTimes(new int[] {2, 3, 5, 4, 5, 2, 4, 3, 5, 2, 4, 4, 2});

            Console.WriteLine("Count set bits in an integer");
            bitwiseAndShiftOperator.CountSetBitsInInteger(6);
            bitwiseAndShiftOperator.CountSetBitsInInteger(13);
        }

        static void DFS()
        {
            DFSGraph dfs = new DFSGraph(4);
            dfs.AddEdge(0,1);
            dfs.AddEdge(0,2);
            dfs.AddEdge(1,2);
            dfs.AddEdge(2,0);
            dfs.AddEdge(2,3);
            dfs.AddEdge(3,3);
            Console.WriteLine("Following is depth first Traversal starting from vertex 2");
            dfs.DFS(2);
            Console.WriteLine();
            Console.WriteLine("Following is depth first Traversal starting from vertex 1");
            dfs.DFS(1);
            Console.WriteLine();
            Console.WriteLine("Following is depth first Traversal starting from vertex 0");
            dfs.DFS(0);

        }

        static void DoubleLinkedList()
        {
            DLL dll = new DLL();
 
            // Insert 6. So linked list becomes 6->NULL
            dll.append(6);
    
            // Insert 7 at the beginning.
            // So linked list becomes 7->6->NULL
            dll.push(7);
    
            // Insert 1 at the beginning.
            // So linked list becomes 1->7->6->NULL
            dll.push(1);
    
            // Insert 4 at the end. So linked list
            // becomes 1->7->6->4->NULL
            dll.append(4);
    
            // Insert 8, after 7. So linked list
            // becomes 1->7->8->6->4->NULL
            dll.InsertAfter(dll.head.next, 8);
    
            Console.WriteLine("Created DLL is: ");
            dll.printlist(dll.head);
        }

        static void MutliDimensionalArray()        
        {
            int[,] m = new int[2,3] {{1,2,3}, {3,4,5}};

            MutliDimensionalArray mutliDimensionalArray= new MutliDimensionalArray(m);
            mutliDimensionalArray.PrinArray(2,3);
            mutliDimensionalArray.GetLastElement();
        }

        static void FindLargetValueInEachLevel()
        {
            LargestValueEachLevel l = new LargestValueEachLevel();
            int[] n = new int[] {4,9,2,3,5,7};
            l.head= l.AddNodes(n,l.head,0);
            l.PrintNodes(l.head);

            l.LargestValue(l.head);
           
        }

        static void MinJumpArray()
        {
            MinJumpArray minJumpArray = new MinJumpArray();
            minJumpArray.PrintMinJumpArray(new int[] {2,3,1,1,4});
        }
    }
}
