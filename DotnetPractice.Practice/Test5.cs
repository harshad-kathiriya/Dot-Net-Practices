// Find the two non-repeating elements in an array of repeating elements/ Unique Numbers 2

// Given an array in which all numbers except two are repeated once. (i.e. we have 2n+2 numbers and n numbers are occurring twice and remaining two have occurred once). Find those two numbers in the most efficient way.  

using System;
using System.Collections.Generic;

namespace DotnetPractice.Practice
{
    class Test5
    {
        public void FindTwoNonRepeatingNumber(int[] nums)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();

            for(int i=0; i < nums.Length; i++)
            {
                if(dict.ContainsKey(nums[i]))
                {
                    int n = dict[nums[i]];
                    dict[nums[i]] = ++n;
                } 
                else
                    dict.Add(nums[i], 1);    
                
            }

            foreach(KeyValuePair<int,int> di in dict)
            {
                if(di.Value == 1)
                {
                    Console.WriteLine($"{di.Key} {di.Value}");
                }
            }

        }
    }
}