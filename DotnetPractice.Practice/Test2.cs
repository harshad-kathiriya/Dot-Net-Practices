// Find largest word in dictionary by deleting some characters of given string

// Giving a dictionary and a string ‘str’, find the longest string in dictionary which can be formed by deleting some characters of the given ‘str’. 

// Input : dict = {"ale", "apple", "monkey", "plea"}   
//         str = "abpcplea"  
// Output : apple 

// Input  : dict = {"pintu", "geeksfor", "geeksgeeks", 
//                                         " forgeek"} 
//          str = "geeksforgeeks"
// Output : geeksgeeks

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DotnetPractice.Practice
{
    class Test2
    {
        public void FindLargestWord(List<string> list, string str)
        {
            string result = "";
            int length = 0;

            foreach (string s in list)
            {
                for(int i =0; i < s.Length; i++)
                {
                    if(length < s.Length && isSubSequence(s, str))
                    {
                        result = s;
                        length  = s.Length;
                    }    
                }   
            }
            Console.WriteLine($"Result - {result}");
        }

        private bool isSubSequence(string str1, string str2)
        {
            int m = str1.Length, n= str2.Length;

            int j = 0;

            for (int i = 0; i < n && j < m; i++)
            {
                if(str1[j] == str2[i])
                {
                    j++;
                }
            }

            return (j==m);
        }

        public void FindLargestWord_Optimize(List<string> list, string str)
        {
            var ls =list.OrderByDescending(s => s.Length);

            int length = 0;
            string result = "";

            foreach(string item in ls)
            {
                if(length > item.Length )
                    break;
                    
                for(int i =0; i < item.Length; i++)
                {
                    if(length < item.Length && isSubSequence(item, str))
                    {
                        result = item;
                        length  = item.Length;                        
                    }    
                }  
            }
            Console.WriteLine($"Result - {result}");
        }

    }

    
    
}
