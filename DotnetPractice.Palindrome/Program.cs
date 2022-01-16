using System;
using System.Text;

namespace DotnetPractice.Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "";
            (bool b, int l) result;
            Console.WriteLine("Let's begin:");
            while(inputStr != "exit") 
            {
                inputStr = Console.ReadLine();
                if(inputStr != "exit")
                {
                    result = isPalindrome(inputStr);
                    Console.WriteLine($"Palindrome: {result.b}, Length: {result.l}");
                }
            }
        }


        static (bool, int) isPalindrome(string str) 
        {
            string testStr = str.ToUpper();

            var sb = new System.Text.StringBuilder();
            foreach(char c in testStr)
            {
                if(!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }

            testStr = sb.ToString();            

            int i =0, j=testStr.Length -1;
            while(i<=j) {
                if(testStr[i] != testStr[j]) {
                    return(false, 0);
                }
                i++;
                j--;
            }

            return (true, str.Length);
        }

    }
}
