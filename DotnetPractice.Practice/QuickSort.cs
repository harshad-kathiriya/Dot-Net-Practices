// QuickSort is a Divide and Conquer algorithm. It picks an element as pivot and partitions the given array around the picked pivot. There are many different versions of quickSort that pick pivot in different ways. 

// Always pick first element as pivot.
// Always pick last element as pivot (implemented below)
// Pick a random element as pivot.
// Pick median as pivot.

// The key process in quickSort is partition(). Target of partitions is, given an array and an element x of array as pivot, put x at its correct position in sorted array and put all smaller elements (smaller than x) before x, and put all greater elements (greater than x) after x. All this should be done in linear time.

using System;

namespace DotnetPractice.Practice
{
    class QuickSortTest
    {
        int[] temp;
        public void QuickSort(int[] input)
        {         
            temp = new int[input.Length];

            QS(input, 0, input.Length-1);
            // print array
            for(int i=0; i<temp.Length; i++)
            {
                Console.Write($"{temp[i]} ");
            }
            Console.WriteLine();
        }

        private void QS(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int pi = Partition(arr,low,high);
                QS(arr,low,pi-1);
                QS(arr,pi+1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i= (low-1);

            for(int j=low; j<=high; j++)
            {
                if(arr[j]<pivot)
                {
                    i++;
                    int swap = arr[i];
                    temp[i] = arr[j];
                    temp[j] = swap;
                    Console.WriteLine(swap);
                }                
            }

            int t = arr[i+1];
            temp[i+1] = arr[high];
            temp[high] = arr[i+1];

            return (i+1);
        }

    }
}