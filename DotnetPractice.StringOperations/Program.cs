using System;

namespace DotnetPractice.StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare outString to performa multiple operation
            string outString = "";

            // declare string variable and array
            string str = "This is a string variable";
            string[] arrayStr = { "Red", "Blue", "Black" };

            // print the length
            Console.WriteLine("Length {0}",str.Length);

            // print the single character from array
            Console.WriteLine(arrayStr[2]);

            // iterate array
            foreach(string s in arrayStr) {
                Console.WriteLine(s);
            }

            // print each character from the string
            foreach(char c in str) 
            {
                Console.WriteLine(c);
            }

            // concatenation of two string
            outString = String.Concat(arrayStr);
            Console.WriteLine(outString);

            // join two string
            outString = String.Join("**", arrayStr);
            Console.WriteLine(outString);

            // compare string
            int result = String.Compare("This is a string", "This is a string");
            Console.WriteLine(result);

            // check the equality
            bool isEqual = str.Equals("This is a string variable");
            Console.WriteLine(isEqual);

            // searching
            Console.WriteLine(str.IndexOf('e'));
            Console.WriteLine(str.LastIndexOf('l'));

            // replace
            outString = str.Replace("string", "str");
            Console.WriteLine(outString);


        }
    }

}
