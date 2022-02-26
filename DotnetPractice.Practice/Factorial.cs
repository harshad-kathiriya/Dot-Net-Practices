
// Factorial 
// 5 = 5*4*3*2 = 120

using System;
namespace DotnetPractice.Practice
{
    class Factorial
    {
        public void GetFactorial(int n)
        {
            int sum = 1;
            
            while (n > 0)
            {
                sum = sum * n;
                n--;    
            }

            Console.WriteLine($"Factorial number - {sum}");     
        }
    }
}