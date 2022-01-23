using System;
using System.Collections.Generic;

// Given an unsorted array which has a number in the majority (a number appears more than 50% in the array), find that number?

namespace DotnetPractice.ArrayOperation
{
    class FindMajorityNumber
    {

        public int GetMajorityNumber(List<int> x) 
        {
            if(x.Count == 0) 
            {
                throw new ArgumentException("parameter should not be null");
            }

            int majority = x.Count / 2;
            Console.WriteLine($"Initial Majority value {majority}");
    
            Dictionary<int,int> d = new Dictionary<int, int>();

            foreach(int i in x)
            {
                if(d.ContainsKey(i))
                {
                    d[i]++;
                    if(d[i] > majority)
                        return i;
                }
                else
                    d.Add(i, 1);
            }
            throw new Exception("No majority element in array");
        }

    }
}