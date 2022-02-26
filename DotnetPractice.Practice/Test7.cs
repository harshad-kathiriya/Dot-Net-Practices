// Print all Jumping Numbers smaller than or equal to a given value

// A number is called as a Jumping Number if all adjacent digits in it differ by 1. The difference between ‘9’ and ‘0’ is not considered as 1. 
// All single digit numbers are considered as Jumping Numbers. For example 7, 8987 and 4343456 are Jumping numbers but 796 and 89098 are not. 
// Given a positive number x, print all Jumping Numbers smaller than or equal to x. The numbers can be printed in any order.

// Example: 

// Input: x = 20
// Output:  0 1 2 3 4 5 6 7 8 9 10 12

// Input: x = 105
// Output:  0 1 2 3 4 5 6 7 8 9 10 12
//          21 23 32 34 43 45 54 56 65
//          67 76 78 87 89 98 101

// Note: Order of output doesn't matter, 
// i.e. numbers can be printed in any order

using System;
using System.Collections.Generic;

namespace DotnetPractice.Practice
{
    class Test7
    {
        public void CheckJumpingNumber(int num)
        {   
            if(num == 0)
                return;
            int n = num;
            
            bool flag = true;
            while (num != 0)
            {
                int digit = num % 10;
                num = num/10;
                
                if(num !=0)
                {
                    int digit2 = num % 10;
                    
                    if(Math.Abs(digit-digit2) != 1)
                    {
                        flag = false;
                        break;
                    }
                }

            }

            if(flag)
            {
                Console.WriteLine($"{n} is a jumping number");
            }
            else
            {
                Console.WriteLine($"{n} is not a jumping number");                
            }

        }

        public void PrintAllJumpingNumberBFS(int num)
        {
            for(int i=1; i<= 9 && i<=num; i++)
            {   
                BFS(num,i);
            }
        }

        public void BFS(int x, int num)
        {
            Queue<int> q = new Queue<int>();
             q.Enqueue(num);

             while(q.Count!=0)
             {
                 num = q.Peek();
                 q.Dequeue();

               if(num <= x)
               {
                   Console.Write(num + " ");
                   int last_digit = num % 10;

                   if(last_digit == 0)
                   {
                       q.Enqueue((num * 10) + (last_digit + 1));
                   }
                   else if (last_digit == 9)
                   {
                       q.Enqueue((num *10) + (last_digit -1));
                   }
                   else
                   {
                      q.Enqueue((num * 10) + (last_digit - 1));
                      q.Enqueue((num * 10) + (last_digit + 1));
                   }
               }  
             } 
        }
        
    }
}