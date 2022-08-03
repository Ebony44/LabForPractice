using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.LabForNumericOrder
{
    class Third_Maximum_Number_414
    {
        /*
         * Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.
         * 
         * 
         * Example 1:

Input: nums = [3,2,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2.
The third distinct maximum is 1.

Example 2:

Input: nums = [1,2]
Output: 2
Explanation:
The first distinct maximum is 2.
The second distinct maximum is 1.
The third distinct maximum does not exist, so the maximum (2) is returned instead.

Example 3:

Input: nums = [2,2,3,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2 (both 2's are counted together since they have the same value).
The third distinct maximum is 1.

 

Constraints:

    1 <= nums.length <= 104
    -231 <= nums[i] <= 231 - 1

         * 
         */


        public int ThirdMax(int[] nums)
        {
            // int firstInt = -232;
            // int secondInt = -232;
            int thirdInt = -232;
            // firstInt = nums[0];
            // secondInt = nums[0];
            // thirdInt = nums[0];

            int tempBuffer = 0;
            // or simply just sort and pick 3rd

            Array.Sort(nums);
            Array.Reverse(nums);
            nums = nums.Distinct().ToArray();
            if(nums.Length == 1)
            {
                return nums[0];
            }
            else if(nums.Length == 2)
            {
                return nums[0] > nums[1] ? nums[0] : nums[1];
            }
            else if (nums.Length >= 3)
            {
                thirdInt = nums[2];
            }
            

            #region  
            //// 1. check third nums
            //// [2,3,4,1,6]
            //// 2/2/2
            //// 3/2/2
            //// 4/2/2
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    //if(i == 0)
            //    //{
            //    //    firstInt = nums[0];
            //    //    secondInt = nums[0];
            //    //    thirdInt = nums[0];
            //    //}
            //    tempBuffer = firstInt;
            //    if(firstInt <= nums[i])
            //    {
            //        firstInt = nums[i];
            //    }
            //    if(secondInt <= nums[i]
            //        && firstInt > nums[i])
            //    {
            //        secondInt = nums[i];
            //    }
            //    if(thirdInt <= nums[i]
            //        && secondInt > nums[i])
            //    {
            //        thirdInt = nums[i];
            //    }


            //}
            //// 2. 
            //var result = 0;
            #endregion
            return thirdInt;
        }
    }
}
