using System;

namespace DotnetPractice.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare basic variables
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';
            long l = 10;

            // declare a string
            string str = "string";

            // declare a implicit variable
            var x = 10;
            var z = "Hello!";

            // declare an array
            int[] vals = new int[5];
            string[] colors = {"red", "blue", "black"};

            // null values
            Object obj = null;
            Console.WriteLine(obj);


        }
    }
}
