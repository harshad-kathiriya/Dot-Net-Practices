// Like QuickSort, Merge Sort is a Divide and Conquer algorithm. It divides the input array into two halves, calls itself for the two halves, and then merges the two sorted halves. The merge() function is used for merging two halves. The merge(arr, l, m, r) is a key process that assumes that arr[l..m] and arr[m+1..r] are sorted and merges the two sorted sub-arrays into one. See the following C implementation for details.

// MergeSort(arr[], l,  r)
// If r > l
//      1. Find the middle point to divide the array into two halves:  
//              middle m = l+ (r-l)/2
//      2. Call mergeSort for first half:   
//              Call mergeSort(arr, l, m)
//      3. Call mergeSort for second half:
//              Call mergeSort(arr, m+1, r)
//      4. Merge the two halves sorted in step 2 and 3:
//              Call merge(arr, l, m, r)

using System;

namespace  DotnetPractice.Practice
{
    class MergeSortTest
    {

        public void Sort(int[] arr)
        {
            // arr = [10,3,11,8,1]
            MergeSort(arr, 0, arr.Length);
            PrintArray(arr);
        }

        private void MergeSort(int[] arr, int l, int r)
        {
            if(r > l)
            {
                int m = l + (r-1) / 2; // m = 2

                MergeSort(arr,l,m); // l = 0, m = 2, arr = [10,3]
                MergeSort(arr,m+1,r); // m = 3, r = 5, arr = [11,8,1] 

                Merge(arr,l,m,r); 
            }
        }

        private void Merge(int[] arr, int l, int m , int r)
        {
            int n1= m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            int i=0,j=0;

            for(i=0; i< n1; ++i)
                L[i] = arr[l+i];

            for(j=0; j<n2; ++j)
                R[j] = arr[m+1+j];

            i=0;
            j=0;

            int k = l;
            while(i<n1 && j<n2)
            {
                if(L[i]<=R[j]) 
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // copy remaining elements of Left array
            while (i<n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

             // copy remaining elements of right array
            while(j<n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
            
        }

        private void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        
    }
}