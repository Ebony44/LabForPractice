using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.GfGReferences
{
    // https://www.geeksforgeeks.org/print-all-possible-combinations-of-r-elements-in-a-given-array-of-size-n/
//    Given an array of size n, generate and print all possible combinations of r elements in array.
//    For example, if input array is {1, 2, 3, 4} and r is 2,
//    then output should be {1, 2}, { 1, 3}, { 1, 4}, { 2, 3}, { 2, 4} and { 3, 4}.


    public class CombinationUtil
    {
        /* arr[] ---> Input Array
    data[] ---> Temporary array to
                store current combination
    start & end ---> Starting and Ending
                     indexes in arr[]
    index ---> Current index in data[]
    r ---> Size of a combination
           to be printed */
        public static void ShowCombination(int[] arr, int n,
                                int r, int index,
                                int[] data, int i)
        {
            // Current combination is ready
            // to be printed, print it
            if (index == r)
            {
                for (int j = 0; j < r; j++)
                {

                    Console.Write(data[j] + " ");
                }
                Console.WriteLine("");
                return;
            }

            // When no more elements are
            // there to put in data[]
            if (i >= n)
                return;

            // current is included, put
            // next at next location
            data[index] = arr[i];
            ShowCombination(arr, n, r,
                            index + 1, data, i + 1);

            // current is excluded, replace
            // it with next (Note that
            // i+1 is passed, but index
            // is not changed)
            ShowCombination(arr, n, r, index,
                            data, i + 1);
        }


        // The main function that prints
        // all combinations of size r
        // in arr[] of size n. This
        // function mainly uses combinationUtil()
        public static void ShowCombination(int[] arr,
                                     int n, int r)
        {
            // A temporary array to store
            // all combination one by one
            int[] data = new int[r];

            // Print all combination
            // using temporary array 'data[]'
            ShowCombination(arr, n, r, 0, data, 0);
        }


    }
}
