// Given an array of non-negative integers, A, of length N, you are initially positioned at the first index of the array.

// Each element in the array represents your maximum jump length at that position.

// Return the minimum number of jumps required to reach the last index.

// If it is not possible to reach the last index, return -1.

// Input 2:
//     A = [2,3,1,1,4]

// Output 2:
//     2

// Explanation 2:
//     The shortest way to reach index 4 is
//         Index 0 -> Index 1 -> Index 4
//     that requires 2 jumps.

using System;

namespace DotnetPractice.Practice
{
    class MinJumpArray
    {

        public void PrintMinJumpArray(int[] arr)
        {
            if(arr.Length == 0)
                return;

            int n = arr.Length;

            int[] jumps = new int[n];
 
            jumps[0] = 0;
    
            // Find the minimum number of
            // jumps to reach arr[i]
            // from arr[0], and assign
            // this value to jumps[i]
            for (int i = 1; i < n; i++) {
                jumps[i] = int.MaxValue;
                Console.WriteLine(jumps[i]);
                for (int j = 0; j < i; j++) {
                    Console.WriteLine(j + arr[j]);
                    if (i <= j + arr[j] && jumps[j] != int.MaxValue) {
                        jumps[i] = Math.Min(jumps[i], jumps[j] + 1);
                        break;
                    }
                }
            }
            Console.WriteLine(jumps[n - 1]);

        }

    }


}