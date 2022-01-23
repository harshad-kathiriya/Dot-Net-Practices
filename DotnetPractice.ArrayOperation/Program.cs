using System;
using System.Collections.Generic;

namespace DotnetPractice.ArrayOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>() {1, 100}; //{1,2,3,4,2,2,2,2,2};

            FindMajorityNumber f = new FindMajorityNumber();
            Console.WriteLine($"Majority number is {f.GetMajorityNumber(arr)}");



        }
    }
}
