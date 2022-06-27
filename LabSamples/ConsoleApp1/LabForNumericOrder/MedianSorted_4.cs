using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LabForNumericOrder
{
    /*
     * 
     * 
     * Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

        The overall run time complexity should be O(log (m+n)).

        Example 1:
        
        Input: nums1 = [1,3], nums2 = [2]
        Output: 2.00000
        Explanation: merged array = [1,2,3] and median is 2.
        
        Example 2:
        
        Input: nums1 = [1,2], nums2 = [3,4]
        Output: 2.50000
        Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
        

        Constraints:

        nums1.length == m
        nums2.length == n
        0 <= m <= 1000
        0 <= n <= 1000
        1 <= m + n <= 2000
        -106 <= nums1[i], nums2[i] <= 106


     * 
     */
    class MedianSorted_4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            // constraint. given arrays are sorted
            // 
            // O(log(m + n)).
            // length 2, length 2
            // log 4, -> O(2)
            // length 6, length 3
            // log 9 -> O(3)

            // length 12, length 13
            // log 25 -> O(5)

            // case 1
            // 1,2
            // 40,50
            // ......

            // case 2
            // 1,3
            // 2,4
            // ......

            // case 3
            // 1,3,5,7
            // 2,4,60,80
            // ......

            // case 4
            // 1,3,5,7
            // 2,4,6,8
            // ...... // -> iteration count should be 4?
            // more than 2, less than 3...

            // length 3 length 4
            // log 7 -> between 2 to 3(4~9)
            // -> O(3)

            // length 5 length 2
            // log 7 -> O(2)

            // 7 * log 7
            // 15...
            //

            // case 5
            // 1,3,5
            // 2,4,6
            // log 6
            // in worst case, O(5)

            // case 6(approved)
            // 4
            // 1,2,3,5,7
            // log 6
            // 

            // 0. loop for merged array

            // 

            int assertionLength = 0;
            const int MAX_ASSERT_ITERATION = 500;

            int firstIndex = 0;
            int secondIndex = 0;

            
            
            List<int> sortedMergedList = new List<int>(2000);

            #region obsolete
            //while (true)
            //{

            //    // . one's min(or selected) number is higher than other's max number
            //    // -> add range and done.

            //    if(nums1[firstIndex] >= nums2[nums2.Length - 1])
            //    {

            //        break;
            //    }
            //    else if(nums2[secondIndex] >= nums1[nums1.Length - 1])
            //    {
            //        break;
            //    }


            //    // . else, first or second exceed other.
            //    // . add consecutively, and both index ++



            //    assertionLength++;
            //    if(assertionLength > MAX_ASSERT_ITERATION)
            //    {
            //        Console.WriteLine("max assertion reached");
            //        break;
            //    }


            //}
            #endregion

            #region from merge sort

            int n1 = 0;
            int n2 = 0;
            n1 = nums1.Length;
            n2 = nums2.Length;
            int[] tempArray = new int[n1 + n2];
            int idxFst = 0;
            int idxScnd = 0;
            int idxThrd = 0;
            while (idxFst < n1 && idxScnd < n2)
            {
                // if one exceed other, still insert both...

                if(nums1[idxFst] <= nums2 [idxScnd])
                {
                    tempArray[idxThrd] = nums1[idxFst];
                    idxFst++;
                }
                else
                {
                    tempArray[idxThrd] = nums2[idxScnd];
                    idxScnd++;
                }
                idxThrd++;
                assertionLength++;
                //if (assertionLength > MAX_ASSERT_ITERATION)
                //{
                //    Console.WriteLine("max assertion reached");
                //    break;
                //}
            }
            // copy remaining
            while (idxFst < n1)
            {
                tempArray[idxThrd] = nums1[idxFst];
                idxFst++;
                idxThrd++;

                assertionLength++;
                //if (assertionLength > MAX_ASSERT_ITERATION)
                //{
                //    Console.WriteLine("max assertion reached");
                //    break;
                //}

            }
            while (idxScnd < n2)
            {
                tempArray[idxThrd] = nums2[idxScnd];
                idxScnd++;
                idxThrd++;

                assertionLength++;
                //if (assertionLength > MAX_ASSERT_ITERATION)
                //{
                //    Console.WriteLine("max assertion reached");
                //    break;
                //}

            }



            #endregion
            var midIndex = tempArray.Length / 2;
            double tempReturnValue = 0;
            if (tempArray.Length % 2 == 1)
            {
                
                //if(midIndex != 0)
                //{
                //    midIndex = tempArray.Length / 2;
                //}
                //else // length is 1
                //{
                //    midIndex = 0;
                //}
                tempReturnValue = tempArray[midIndex];
            }
            else
            {
                midIndex = tempArray.Length / 2;
                var midIndex2 = tempArray.Length / 2 - 1;
                tempReturnValue = (tempArray[midIndex] + tempArray[midIndex2]) / (double)2;
            }
            // var tempMedian = 

            return tempReturnValue;
        }
    }
}
