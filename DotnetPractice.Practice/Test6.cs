// Meta Strings (Check if two strings can become same after a swap in one string)

// Given two strings, the task is to check whether these strings are meta strings or not. Meta strings are the strings which can be made equal by exactly one swap in any of the strings. Equal string are not considered here as Meta strings.

// Examples: 
// Input : str1 = "geeks" 
//         str2 = "keegs"
// Output : Yes
// By just swapping 'k' and 'g' in any of string, 
// both will become same.

// Input : str1 = "rsting"
//         str2 = "string
// Output : No

// Input :  str1 = "Converse"
//          str2 = "Conserve"

using System;
using System.Collections.Generic;

namespace DotnetPractice.Practice
{
    class Test6
    {
        public void FindMetaStrings(string str1, string str2)
        {
            Dictionary<char, char> dict = new Dictionary<char,char>();

            int s1 = str1.Length;
            int s2 = str2.Length;

            char[] char1 = str1.ToCharArray();
            char[] char2 = str2.ToCharArray();
            
            int i =0,j = 0;

            while(i < s1 && j < s2)
            {
                if(char1[i] != char2[j])
                {
                    if(dict.ContainsKey(char2[j]))
                    {
                        char2[j] = dict[char1[i]];
                        Console.WriteLine($"contains - {char2[j]}");
                    }
                    else 
                    {
                        //char2[j] = char1[i];
                        dict.Add(char2[j], char1[i]);
                        Console.WriteLine($"else - {char2[j]}");
                    }
                }    

                ++i;
                ++j;
            }

            string newSt1 = new string(char1);
            string newSt2 = new string(char2);
             
             Console.WriteLine(newSt1);
             
             Console.WriteLine(newSt2);

            if(newSt1 == newSt2)
            {
                Console.WriteLine("Yes");
            }
            else 
            {
                Console.WriteLine("No");
            }



        }       
    }
}