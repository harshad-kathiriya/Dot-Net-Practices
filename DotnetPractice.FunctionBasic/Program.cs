using System;

namespace DotnetPractice.FunctionBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The result is {MilesToKM(8.0f)}");            
            Console.WriteLine($"The result is {MilesToKM(10.0f)}");
           
           PrintWithPrefix("Hello There!");
           PrintWithPrefix("How are you?", "Hello There");
           
            
        }

        static float MilesToKM(float miles) 
        {
            float result = miles * 1.6f;
            return result;
        }

        static void PrintWithPrefix(string theString, string prefix = "")
        {
            Console.WriteLine($"{prefix} {theString}");
        }
    }
}
