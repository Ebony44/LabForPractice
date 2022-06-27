using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MergeSort
    {
        // Merges two subarrays of []arr.
        // First subarray is arr[l..m]
        // Second subarray is arr[m+1..r]
        public void merge(int[] arr, int l, int m, int r)
        {
            // 0,1,2
            // 25,47,12

            // n1 = 2
            // n2 = 1
            
            // l -> start of first array
            // m - l + 1
            // m+1 -> start of second array

            // 25,47
            // 12
            // n log n
            // 3 * log 3
            

            // Find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
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

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        // Main function that
        // sorts arr[l..r] using
        // merge()
        public void sort(int[] arr, int l, int r)
        {
            // array is
            // {47,25,12}
            // length 3
            // l = 0, r= 2
            // m = 1
            // in this logic
            // {47, 25} , {12}

            // 47,25,12
            // -> 25,47,12
            // 


            if (l < r)
            {
                // Find the middle
                // point
                int m = l + (r - l) / 2;

                // Sort first and
                // second halves
                sort(arr, l, m);
                sort(arr, m + 1, r);

                // Merge the sorted halves
                merge(arr, l, m, r);
            }
        }

        // A utility function to
        // print array of size n */
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        // Driver code
        //public static void Main(String[] args)
        //{
        //    int[] arr = { 12, 11, 13, 5, 6, 7 };
        //    Console.WriteLine("Given Array");
        //    printArray(arr);
        //    MergeSort ob = new MergeSort();
        //    ob.sort(arr, 0, arr.Length - 1);
        //    Console.WriteLine("\nSorted array");
        //    printArray(arr);
        //}


        public static void SortIntended(int[] arr, int l, int r)
        {
            // array is
            // {38, 28}

            // 0 to mid
            // mid + 1 to end

            

            // SortIntended()
            if(l < r)
            {
                // SortIntended(arr, )
            }

        }

    }
}
// https://www.geeksforgeeks.org/merge-sort/
// https://www.geeksforgeeks.org/divide-and-conquer-algorithm-introduction/?ref=leftbar-rightbar
// This code is contributed by Princi Singh