/*
Given two sequences A, B, count number of unique ways in sequence A, to form a subsequence that is identical to the sequence B.

Subsequence : A subsequence of a string is a new string which is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (ie, “ACE” is a subsequence of “ABCDE” while “AEC” is not).
*/

using System;
using System.Text;

namespace DotnetPractice.DistinctSubSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Input");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter Second Input");
            string str2 = Console.ReadLine();

            CheckDistinctSubSequences_New(str1, str2);

          
        }

        static void CheckDistinctSubSequences(string s1, string s2)
        {
            if(s1.ToLower().Equals(s2.ToLower()))
            {
                Console.WriteLine("Both the strings are equal.");
                return;
            }          

            int sequenceCount =0;
            int counter = 0;
            foreach(char c in s1)
            {
                string temp = s1.Remove(counter,1);
                if(temp.ToLower().Equals(s2.ToLower()))
                {
                    sequenceCount++;
                }
                counter++;
            }

            if(sequenceCount > 0)
            {
                Console.WriteLine(sequenceCount);
                return;
            }    
            Console.WriteLine("No SubSequence Found !");
        }

        static void CheckDistinctSubSequences_New(string A, string B)
        {
            // A : "aaaababbababbaabbaaababaaabbbaaabbb"
            // B : "bbababa"

            int m = B.Length;
            int n = A.Length;


            int[, ] mat = new int[m+1, n+1];

            for (int i = 1; i <= m; i++)
                mat[i, 0] = 0;

            for (int j = 0; j <= n; j++)
                mat[0, j] = 1;


            for (int i = 1; i <= m; i++) {
                StringBuilder str = new StringBuilder();

                for (int j = 1; j <= n; j++) {
 
                    if (B[i - 1] != A[j - 1])
                    {
                        mat[i, j] = mat[i, j - 1];
                        Console.WriteLine("Not match " + mat[i, j - 1]);
                    }
                    else
                    {
                        mat[i, j] = mat[i, j - 1] + mat[i - 1, j - 1];
                         Console.WriteLine("Match " + mat[i, j]);
                    }
                    
                    str.Append(A[j - 1]);
                }
                Console.WriteLine(str);
            }

            Console.WriteLine(mat[m, n]);
        }

    }
}
