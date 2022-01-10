using System;

namespace DotnetPractice.If
{
    class Program
    {
        static void Main(string[] args)
        {
            // if-else statement
            int val = 10;

            if(val == 10) 
                Console.WriteLine("Value is 10");
            else if (val > 10)
                Console.WriteLine("Value is greater than 10");
            else 
                Console.WriteLine("Value is not 10");
            
            // ternary operator
            Console.WriteLine(val == 10 ? "Value is 10": "Value is something else");

        }
    }
}
