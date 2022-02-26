// Given a binary tree, find the largest value in each level
// Input :
//         4
//        / \
//       9   2
//      / \   \
//     3   5   7 

// Output : 4 9 7
// Explanation : 
// There are three levels in the tree:
// 1. {4}, max = 4
// 2. {9, 2}, max = 9
// 3. {3, 5, 7}, max=7

using System;
using System.Collections.Generic;

namespace DotnetPractice.Practice
{
    class LargestValueEachLevel
    {
        public LNode head;
        Dictionary<int,int> dict = new Dictionary<int, int>();

        public LNode AddNodes(int[] d, LNode root, int i)
        {
            if(i<d.Length)
            {
                LNode temp = new LNode(d[i]);
                root = temp;
                root.left = AddNodes(d,root.left, 2*i+1);
                root.right = AddNodes(d,root.right, 2*i+2);
            }
            return root;
        }

        public void PrintNodes(LNode root)
        {
            if(root!= null)
            {
                PrintNodes(root.left);
                Console.Write(root.data + " ");
                PrintNodes(root.right);        
            }
        }

        public void LargestValue(LNode root)
        {
           GetLevel(root, 0);
            Dictionary<int,int> d = new Dictionary<int, int>();

            foreach(KeyValuePair<int,int> item in dict)
            {
                if(d.ContainsKey(item.Value))
                {
                    int i = d[item.Value];
                    if(i<item.Key)
                    {
                        d[item.Value] = item.Key; 
                    }
                }
                else
                {
                    d.Add(item.Value,item.Key);
                }
            }

            PrintDictionary(d);
        }

        public void GetLevel(LNode root, int level)
        {
            if(root == null)
                return;

            if(!dict.ContainsKey(root.data))
            {
                dict.Add(root.data, level);
                level += 1;
                GetLevel(root.left, level);
                GetLevel(root.right, level);
            }
        }

        public void PrintDictionary(Dictionary<int,int> d)
        {
            Console.WriteLine();
            foreach(KeyValuePair<int,int> item in d)
            {
                Console.WriteLine($" Level - {item.Key}, Max - {item.Value}");
            }
        }

    }

    class LNode
    {
        public LNode left;
        public LNode right;
        public int data;

        public LNode(int d)
        {
            this.data = d;
            this.left = null;
            this.right = null;
        }
    }
}