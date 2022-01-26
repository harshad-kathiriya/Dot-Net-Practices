using System;

namespace DotnetPractice.QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {10,7,8,9,1,5};
            Console.WriteLine("Input Array");
            PrintArray(arr);
            QuickSortFunc(arr,0,arr.Length-1);
            Console.WriteLine("Sorted Array");
            PrintArray(arr);
        }
        
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low-1);
            
            for (int j = low; j <= high -1 ; j++)
            {
                if(arr[j] < pivot)
                {
                    i++;
                    int a = arr[j];
                    arr[j] = arr[i];
                    arr[i] = a;
                }                
            }

            int c = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = c;
            return (i + 1);
        }

        static void QuickSortFunc(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int pi = Partition(arr, low, high);
                Console.WriteLine(pi);

                QuickSortFunc(arr, low, pi - 1); 
                QuickSortFunc(arr, pi + 1, high); 
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
