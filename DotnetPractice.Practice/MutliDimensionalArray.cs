
using System;

namespace DotnetPractice.Practice
{
    class MutliDimensionalArray
    {
        public int[,] arr;
        public MutliDimensionalArray(int[,] _arr)
        {
            arr = _arr;

        }
        public void PrinArray(int row, int col)
        {
            for(int i =0; i<row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void GetLastElement()
        {
            Console.WriteLine(arr);
        }

    }
}