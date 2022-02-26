// Find the longest substring with k unique characters in a given string

// Given a string you need to print longest possible substring that has exactly M unique characters. If there are more than one substring of longest possible length, then print any one of them.

// "aabbcc", k = 1
// Max substring can be any one from {"aa" , "bb" , "cc"}.

// "aabbcc", k = 2
// Max substring can be any one from {"aabb" , "bbcc"}.

// "aabbcc", k = 3
// There are substrings with exactly 3 unique characters
// {"aabbcc" , "abbcc" , "aabbc" , "abbc" }
// Max is "aabbcc" with length 6.

// "aaabbb", k = 3
// There are only two unique characters, thus show error message. 

using System;
using System.Collections.Generic;

namespace DotnetPractice.Practice
{
    class Test4
    {

        private (bool, int) Constrains(string input, int uniqueCharacter, bool checkEqual = false)
        {
            Dictionary<char,int> dict = new Dictionary<char,int>();

            for(int i =0; i < input.Length; i++)
            {
                if(!dict.ContainsKey(input[i])) 
                {
                    dict.Add(input[i], input[i]);
                }
            }

            if(checkEqual && uniqueCharacter == dict.Count )
                return (true, dict.Count);

            if(uniqueCharacter > dict.Count && !checkEqual)
                return (true, dict.Count);

            return (false, dict.Count);
        }
        
        public void FindLargestSubstringWithKUnique(string input, int uniqueCharacter)
        {          
            var check = Constrains(input, uniqueCharacter, false); 
            if(check.Item1)
            {
                Console.WriteLine($"There are only {check.Item2} unique characters in '{input}', thus show error message");
                return;
            }
            List<string> list = new List<string>();

            for(int i = 0; i < input.Length; i++)
            {
                for(int j=i+1; j <= input.Length; j++ )
                {
                    string s = input.Substring(i,j-i);
                    var items = Constrains(s, uniqueCharacter, true);

                    if(items.Item1) 
                    {
                        list.Add(s);
                    }
                }
            }

            int length = 0;
            string largeStr = "";
            foreach (string item in list)
            {
                if(length < item.Length)
                {
                    length = item.Length;
                    largeStr= item;
                }
            }

            Console.WriteLine($"Max is {largeStr} with length {length}");

        }
    }
    
}