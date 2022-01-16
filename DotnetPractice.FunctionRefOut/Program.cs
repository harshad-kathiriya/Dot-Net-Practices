using System;

namespace DotnetPractice.FunctionRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 10;
            int val2 = 20;

            TestFunc1(val1);
            Console.WriteLine($"{val1}");

            TestFunc2(ref val1);
            Console.WriteLine($"{val1}");

            int result = 0;
            Console.WriteLine($"{val2}");            
            TestFunc3(val2,out result);
            Console.WriteLine($"{result}");
        }


        static void TestFunc1(int arg1) 
        {
            Console.WriteLine($"{arg1}");
        }

        static void TestFunc2(ref int arg1) 
        {
            Console.WriteLine($"{arg1}");
            arg1 +=10;
        }

        static void TestFunc3(int arg1, out int arg2) 
        {
            Console.WriteLine($"{arg1}");
            arg2 = arg1 +=10;
        }
        
    }
}
