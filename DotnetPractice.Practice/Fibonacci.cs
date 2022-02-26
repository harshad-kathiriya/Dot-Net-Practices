
// Input - 10
// 1 1 2 3 5 8

using System;

namespace DotnetPractice.Practice
{
    class Fibonacci
    {
        public void PrintFibonacci(int n)
        {
            int i=0;
            int j=0;
            int k=1;
            Console.Write($"{j} {k} ");
            for(int l=2; l<n;l++)
            {
                i = j+k;
                Console.Write($"{i} ");
                j = k;
                k=i;
            }
            
            Console.WriteLine();          
        }        

        public void FiboWithRecursion(int n)
        {
            Console.WriteLine(Fibo(n));
        }

        public int Fibo(int n)
        {
            if(n == 0 || n==1)
            {
                return n;
            }                            
            else 
            {
                return Fibo(n-1) + Fibo(n-2);
            }
        }
    }
}