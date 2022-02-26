//Find subarray with given sum | Set 1 (Nonnegative Numbers)
// Given an unsorted array of nonnegative integers, find a continuous subarray which adds to a given number. 

// Input: arr[] = {1, 4, 20, 3, 10, 5}, sum = 33
// Output: Sum found between indexes 2 and 4
// Sum of elements between indices
// 2 and 4 is 20 + 3 + 10 = 33

// Input: arr[] = {1, 4, 0, 0, 3, 10, 5}, sum = 7
// Output: Sum found between indexes 1 and 4
// Sum of elements between indices
// 1 and 4 is 4 + 0 + 0 + 3 = 7

// Input: arr[] = {1, 4}, sum = 0
// Output: No subarray found
// There is no subarray with 0 sum

using System;

namespace DotnetPractice.Practice
{
    class Test3
    {
        public void FindSubArray(int[] arr, int sum)
        {
            int x = 0, y=0;
            
            for(int i=0; i < arr.Length; i ++)
            {
                int addition = arr[i];
                for(int j = i+1; j < arr.Length; j++)
                {        
                    addition += arr[j];

                    if(sum == addition)
                    {
                        x = i;
                        y = j;
                        break;
                    }
                }
                if(x !=0 && y != 0)
                    break;
            }           
            if( x !=0 && y != 0)
                Console.WriteLine($"Sum found between indexex {x} and {y}");
            else 
                Console.WriteLine("No subarray found");

        }

        public void FindSubArray_SlidingWindow(int[] arr, int sum)
        {
            int curr_sum = arr[0], start = 0;

            for(int i =1; i <=arr.Length; i++)
            {
                while (curr_sum > sum && start < i-1)
                {   
                        curr_sum -= arr[start];
                        start++;
                }

                if(curr_sum == sum) 
                {
                    int p = i-1;
                    Console.WriteLine($"Sum found between {start} and {p}");
                    break;
                }

                if(i < arr.Length)
                {
                    curr_sum += arr[i];
                }
            }

            if(curr_sum != sum)
                Console.WriteLine("No Subarray Found");           

        }
    }
}