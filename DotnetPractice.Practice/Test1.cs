
// Count of strings that can be formed using a, b and c under given constraints
// Given a length n, count the number of strings of length n that can be made using ‘a’, ‘b’ and ‘c’ with at-most one ‘b’ and two ‘c’s allowed.

// Input : n = 3 
// Output : 19 
// Below strings follow given constraints:
// aaa aab aac aba abc aca acb acc baa
// bac bca bcc caa cab cac cba cbc cca ccb 

// Input  : n = 4
// Output : 39

using System;

namespace  DotnetPractice.Practice
{
    class Test1
    {
        public int CountStr(int n, int bCount, int cCount)
        {
            if(bCount < 0 || cCount < 0)
                return 0;
            
            if(n==0) return 1;

            if(bCount == 0 && cCount == 0)
                return 1;

            int res = CountStr(n-1, bCount,cCount);
            res += CountStr(n-1, bCount - 1, cCount);
            res += CountStr(n-1, bCount, cCount - 1);

            return res;
        } 
    }
}