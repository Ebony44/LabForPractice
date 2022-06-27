using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.LabForNumericOrder
{
    class TwoSum_1
    {

        #region explanation
        /*
         * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]

        Constraints:

    2 <= nums.length <= 104
    -109 <= nums[i] <= 109
    -109 <= target <= 109
    Only one valid answer exists.

 
Follow-up: Can you come up with an algorithm that is less than O(n^2) time complexity?
         */
        #endregion

        // public Tuple<int,int> Test(List<int> elementList, int target)
        // public int[] TwoSum(int[] nums, int target) 
        public int[] TwoSum(int[] nums, int target) 
        {
            List<int> tempList = new List<int>(capacity: 104);
            var tempTarget = 0;
            var tempResult = 0;
            // 2 7 11 15, 26
            // 4 -> 6 (n(n-1) / 2)
            // 4 5 6 7 8 9 10, 19
            // 7 -> 
            var tempBool = false;
            for (int i = 0; i < nums.Length; i++)
            {
                var tempLeftCount = 0;
                for (int k = i+1; k < nums.Length; k++)
                {
                    if (i + 1 >= nums.Length)
                    {
                        break;
                    }

                    #region
                    var reModTarget = target - nums[i];
                    // target + elementList[i];
                    //if(target >= 0)
                    //{
                    //    reModTarget = target + elementList[i];
                    //}
                    //else
                    //{
                    //    reModTarget = target - elementList[i];
                    //}
                    if(reModTarget == nums[k])
                    {
                        // return elementList[i] + elementList[k];
                        // return new Tuple<int, int>(elementList[i], elementList[k]);
                        // return new Tuple<int, int>(elementList.IndexOf(elementList[i]), elementList.IndexOf(elementList[k]));
                        // return new int[] { nums.IndexOf(nums[i]), nums.IndexOf(nums[k]) };
                        return new int[] { Array.IndexOf(nums, nums[i]), Array.IndexOf(nums, nums[k], Array.IndexOf(nums, nums[i]) + 1) };
                        // (elementList.IndexOf(elementList[i]), elementList.IndexOf(elementList[k]));
                    }
                    else
                    {

                    }
                    #endregion

                }
            }

            // return new Tuple<int, int>(-110,110);// weird thing happened
            return new int[] { -110, 110 };
        }

    }
}
