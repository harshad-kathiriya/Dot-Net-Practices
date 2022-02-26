
// FIRED - FRIED

using System;
using System.Collections;

namespace  DotnetPractice.Practice
{
    class Anagram
    {
        public void CheckAnagram(string str1, string str2)
        {

            if(str1.Equals(str2))
            {
                Console.WriteLine($"{str1} {str2} both are anagram");
            }    

            char[] c1 = str1.ToCharArray();
            char[] c2 = str2.ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);

            string s1 = new string(c1);
            string s2 = new string(c2);

            if(s1.ToLower().Equals(s2.ToLower()))
            {
                Console.WriteLine($"{str1} {str2} both are anagram");
            }
            else 
            {
                Console.WriteLine($"{str1} {str2} both are not anagram");
            }
        }
    }
}