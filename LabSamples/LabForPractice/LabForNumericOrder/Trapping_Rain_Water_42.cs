using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.LabForNumericOrder
{

    class Trapping_Rain_Water_42
    {
        /*
         * Example 1:
         * Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
            Output: 6
            Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. 
            In this case, 6 units of rain water (blue section) are being trapped.
            
            Example 2:
            
            Input: height = [4,2,0,3,2,5]
            Output: 9

        Example 3:

        Input: height = [4,2,0,3,2,5,3,0,0,5]
            Output: 9+10+2 = 21


        Example 4:

        Input: height = [5,2,0,3,2,2,3,0,0,1]
            Output: 8
        // left traverse -> 3 + 5+ 2 + 3 + 3 + 2+ 5 + 5+ 4
        // = 15 9 8 = 32
        // (1,3) + (1,1) + (1,1)
        // right traverse -> (1 + 1) + 

        Example 5:

        Input: height = [8,4,0,4,2,2, 11,0,9,1,0,8]
            Output: (1 + 3 + 0 + 1 + 1) + (3+3+2) = 52

        

        */

        public int Trap(int[] height)
        {

            #region
            // working in progress
            //int heightMax = 0;
            //for (int i = 0; i < height.Length; i++)
            //{
            //    if(heightMax < height[i])
            //    {
            //        heightMax = height[i];
            //    }
            //}
            //int result = 0;

            //int maxLeft = height[0];
            //int maxRight = height[height.Length - 1];
            //for (int i = 0; i < height.Length; i++)
            //{

            //}
            //for (int i = height.Length - 1; i >= 0; i--)
            //{

            //}
            #endregion

            #region
            //int maxLeft = height[0];
            //int maxRight = height[height.Length - 1];
            //List<int> storedWaterList = new List<int>(capacity: height.Length);
            //List<int> tempStoredWaterList = new List<int>(capacity: height.Length);

            //int tempStoredWater = 0;
            //// use these 3 variables

            //int tempStoredWaterIndex = 0;
            //for (int i = 0; i < height.Length; i++)
            //{
            //    if(maxLeft < height[i])
            //    {
            //        maxLeft = height[i];
            //        storedWaterList.Add(tempStoredWaterList[tempStoredWaterIndex]);
            //        // storedWaterList.Add(tempStoredWater);
            //        tempStoredWater = 0;
            //    }
            //    else
            //    {
            //        tempStoredWaterList.Add(maxLeft - height[i]);
            //        // tempStoredWater += maxLeft - height[i];
            //    }
            //}
            #endregion
            #region

            //int x = 0;
            //int y = height.Length;
            //int maxLeft = height[0];
            //int maxRight = height[height.Length - 1];
            //while (x < y)
            //{
            //    maxLeft = Math.Max(maxLeft, height[x]);
            //    maxRight = Math.Max(maxRight, height[y]);

            //    if(maxLeft < maxRight)
            //    {
            //        y--;
            //    }
            //    else
            //    {
            //        x++;
            //    }
            //}
            #endregion

            //Example 3:

            // Input: height = [4, 2, 0, 3, 2, 5, 3, 0, 0, 5]
            //     Output: 9 + 10 + 2 = 21

            //    Example 4:

            //Input: height = [5, 2, 0, 3, 2, 2, 3, 0, 0, 1]
            //    Output: 8

            //shit...

            int result = 0;
            int[] lMin = new int[height.Length];
            int[] rMin = new int[height.Length];
            lMin[0] = height[0];
            for (int i = 1; i < height.Length; i++)
            {
                lMin[i] = Math.Max(height[i], lMin[i - 1]);
            }
            // 4,4,4,4,4,5,5,5,5,5
            rMin[height.Length - 1] = height[height.Length - 1];
            for (int i = height.Length - 1 - 1; i >= 0; i--)
            {
                rMin[i] = Math.Max(height[i], rMin[i + 1]);
            }
            // 5,5,5,5(3),5(5),5(2),5,5,5(0),5,5(4)

            for (int i = 0; i < height.Length; i++)
            {
                result += Math.Min(lMin[i], rMin[i]) - height[i];
            }
            

            return result;

        }


        // ex
        // monotonic stack

        public Stack<int> FindBuildings(int[] buildings)
        {
            // find building which can see senset(from east)
            // which means if array exists like 
            // 18, 14, 13, 16, 12
            // then 0 index, 3rd, 4th building can see sunset
            // 
            Stack<int> buildingStack = new Stack<int>(buildings.Length);

            for (int i = 0; i < buildings.Length; i++)
            {
                int currentHeight = buildings[i];
                buildingStack.Push(i);
                // int poppedValue = 0;
                int tempAssertion = 0;
                while (buildingStack.Count > 0 && currentHeight >= buildings[buildingStack.Peek()])
                {
                    buildingStack.Pop();
                    tempAssertion++;
                    if(tempAssertion > 512)
                    {
                        Console.WriteLine("assertion failed");
                        break;
                    }
                }
                buildingStack.Push(i);
            }
            return buildingStack;
        }
        

    }
}
