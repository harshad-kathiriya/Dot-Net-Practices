
using System;

namespace DotnetPractice.Practice
{
    class BitwiseAndShiftOperator
    {


      public void FindElementThatAppearsOnce(int[] arr)  
      {
        // Find the element that appears once
        // The expected time complexity is O(n) and O(1) extra space.
        // Input: arr[] = {12, 1, 12, 3, 12, 1, 1, 2, 3, 3} 
        // Output: 2 
        // In the given array all element appear three times except 2 which appears once.

        // Input: arr[] = {10, 20, 10, 30, 10, 30, 30} 
        // Output: 20 
        // In the given array all element appear three times except 20 which appears once. 
    
        int n = arr.Length;

        int ones =0, twos= 0;
        int common_bit_mask;

        for(int i=0; i<n; i++)
        {
            Console.WriteLine($"step 1 - {(ones & arr[i])} ");
            Console.WriteLine($"step 2 - {twos | (ones & arr[i])} ");
            
            twos = twos | (ones & arr[i]);

            Console.WriteLine($"step 3 - {(ones ^ arr[i])} ");
            
            ones = ones ^ arr[i];
            Console.WriteLine(Convert.ToString(ones, toBase:2));
            
            common_bit_mask = ~(ones & twos);
            Console.WriteLine(Convert.ToString(common_bit_mask, toBase:2));
            
            Console.WriteLine($"step 4 - {~(ones & twos)} ");

            ones &= common_bit_mask;

            Console.WriteLine($"step 5 - {ones} ");

            twos &= common_bit_mask;

            Console.WriteLine($"step 6 - {twos} ");

        }

        Console.WriteLine(ones);

        uint a = 0b_1111_1000;
        uint b = 0b_1001_1101;
        uint c = a & 1;
        Console.WriteLine(Convert.ToString(c, toBase: 2));
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

      }

    
        public void DetectTwoIntegersHaveOppositeSigns(int n1, int n2)
        {
            // Detect if two integers have opposite signs
            // Given two signed integers, write a function that returns true if the signs of given integers are different, otherwise false. For example, the function should return true -1 and +100, and should return false for -100 and -200. The function should not use any of the arithmetic operators. 
            // Let the given integers be x and y. The sign bit is 1 in negative numbers, and 0 in positive numbers. The XOR of x and y will have the sign bit as 1 iff they have opposite sign. In other words, XOR of x and y will be negative number number iff x and y have opposite signs. The following code use this logic. 

            Console.WriteLine(Convert.ToString(n1, toBase: 2));
            Console.WriteLine(Convert.ToString(n2, toBase: 2));
            Console.WriteLine((n1^n2));

            if((n1^n2)<0)
            {
                Console.WriteLine("Signs are opposite");
            }
            else
            {
                Console.WriteLine("Signs are not opposite");
            }

        }

        public void AddOneToGivenNumber(int x)
        {
            // Write a program to add one to a given number. The use of operators like ‘+’, ‘-‘, ‘*’, ‘/’, ‘++’, ‘–‘ …etc are not allowed. 
            // Examples: 
            

            // Input:  12
            // Output: 13

            // Input:  6
            // Output: 7

            int m =1;

            while((int)(x&m) == 1)
            {
                x = x ^ m;
                m <<= 1;
                Convert.ToString(x,toBase:2);
            }   

            x = x ^ m;
            Console.WriteLine(x);
        }

        public void FindTheNumberOccuringOddNumberofTimes(int[] arr)
        {
            // Given an array of positive integers. All numbers occur an even number of times except one number which occurs an odd number of times. Find the number in O(n) time & constant space.

            // Examples : 

            // Input : arr = {1, 2, 3, 2, 3, 1, 3}
            // Output : 3

            // Input : arr = {5, 7, 2, 7, 5, 2, 5}
            // Output : 5


            int res =0;
            for(int i=0; i<arr.Length; i++)
            {
                res = res ^ arr[i];
            }

            Console.WriteLine(res);

        }

        public void SwapBitsInNumber(int x, int p1, int p2, int n)
        {
            // Swap bits in a given number
            // Given a number x and two positions (from the right side) in the binary representation of x, write a function that swaps n bits at given two positions and returns the result. It is also given that the two sets of bits do not overlap.
            // Input:
            // x = 47 (00101111)
            // p1 = 1 (Start from the second bit from the right side)
            // p2 = 5 (Start from the 6th bit from the right side)
            // n = 3 (No of bits to be swapped)
            // Output:
            // 227 (11100011)
            // The 3 bits starting from the second bit (from the right side) are 
            // swapped with 3 bits starting from 6th position (from the right side)

             // Move all bits of first
        // set to rightmost side
            int set1 = (x >> p1) & ((1 << n) - 1);
    
            // Move all bits of second set
            // set to rightmost side
            int set2 = (x >> p2) & ((1 << n) - 1);
    
            // XOR the two sets
            int xor = (set1 ^ set2);
    
            // Put the xor bits back to
            // their original positions
            xor = (xor << p1) | (xor << p2);
    
            // XOR the 'xor' with the original number
            // so that the two sets are swapped
            int result = x ^ xor;
            Console.WriteLine("Result = " + result);
        }

        public void CountSetBitsInInteger(int n)
        {
            // Write an efficient program to count the number of 1s in the binary representation of an integer.
            // Input : n = 6
            // Output : 2
            // Binary representation of 6 is 110 and has 2 set bits

            // Input : n = 13
            // Output : 3
            // Binary representation of 13 is 1101 and has 3 set bits

            // INPUT - 6 [1101] - binary representation. Total count - 3

            int count=0;
          
            while(n>0)
            {
                count += n & 1;
                n >>= 1;
                Console.WriteLine(n);
            }

            Console.WriteLine($"Total Count - {count}");
     
        }





    }
}