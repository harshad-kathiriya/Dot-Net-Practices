using System;

// Standard numeric format strings
// https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

namespace DotnetPractice.StringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] quarters = { 1,2,3,4 };
            int[] sales = { 1000, 1500, 2000, 25000 };
            double[] intLMixPct = { .386, .413, .421, .457 };
            string str1 = "TestStr";
            int val1 = 1234;
            decimal val2 = 1234.5678m;

            // Basic formatting
            Console.WriteLine("{0}", str1);

            // Specifying Numerical formatting
            // General format is {nidex[,alignment]:[format]}
            // Commong types are N (Number), G (General), F (Fixed-point)
            // E (Exponential), D (Decimal), P (Percent), X (Hexadecimal)
            // C (Currency in local format)

            Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}", val1);
            //Console.WriteLine("{0:E}, {0:N}, {0:F}, {0:G}", val2);

            Console.WriteLine("{0:D6}, {0:N2}, {0:F1}, {0:G3}", val1);

            // formatting with alignment and specing
            Console.WriteLine("{0,12} {1,12} {2,12} {3,12}", 
                quarters[0], quarters[1], quarters[2], quarters[3] );

            Console.WriteLine("{0,12:C0} {1,12:C0} {2,12:C0} {3,12:C0}", 
                sales[0], sales[1], sales[2], sales[3] );

            Console.WriteLine("{0,12:P0} {1,12:P1} {2,12:P2} {3,12:P3}", 
                intLMixPct[0], intLMixPct[1], intLMixPct[2], intLMixPct[3] );


        }
    }
}
