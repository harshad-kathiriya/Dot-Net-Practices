
// Heap sort is a comparison-based sorting technique based on Binary Heap data structure. It is similar to selection sort where we first find the minimum element and place the minimum element at the beginning. We repeat the same process for the remaining elements.
// Let us first define a Complete Binary Tree. A complete binary tree is a binary tree in which every level, except possibly the last, is completely filled, and all nodes are as far left as possible
// Since a Binary Heap is a Complete Binary Tree, it can be easily represented as an array and the array-based representation is space-efficient. If the parent node is stored at index I, the left child can be calculated by 2 * I + 1 and the right child by 2 * I + 2 (assuming the indexing starts at 0).
// The process of reshaping a binary tree into a Heap data structure is known as ‘heapify’. A binary tree is a tree data structure that has two child nodes at max. If a node’s children nodes are ‘heapified’, then only ‘heapify’ process can be applied over that node. A heap should always be a complete binary tree. 

//     30(0)                 
//        /   \         
//     70(1)   50(2)

// Child (70(1)) is greater than the parent (30(0))

// Swap Child (70(1)) with the parent (30(0))
//         70(0)                 
//        /   \         
//     30(1)   50(2)
using System;

namespace DotnetPractice.Practice
{
    class HeapSortTest
    {
        public void HeapSort(int[] arr)
        {
            Sort(arr);
            for(int i=0;i<arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        private void Sort(int[] arr)
        {
            int n = arr.Length;
            
            for(int i=n/2-1; i>=0; i--)
            {
                Heapify(arr,n,i);
            }


            for(int i =n-1; i> 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr,i,0);
            }
        }

        private void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int l = 2*i+1;
            int r = 2*i+2;

            if(l < n && arr[l] > arr[largest])
            {
                largest = l;
            }    

            if(r < n && arr[r] > arr[largest])
            {
                largest = r;
            }

            if(largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Heapify(arr,n,largest);
            }
        }


    }
}