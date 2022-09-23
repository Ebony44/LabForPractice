using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.LabForNumericOrder
{
    class Container_With_Most_Water_11
    {
        public int MaxArea(int[] height)
        {

            int currentHeight = 0;
            #region
            int x = 0;
            int y = height.Length - 1;
            int tempMaxArea = 0;

            int tempMaxAssertion = 0;
            while(x < y)
            {
                currentHeight = height[x] < height[y] ? height[x] : height[y];

                var currentwidth = y - x;

                var currentArea = currentHeight * currentwidth;
                if(currentArea > tempMaxArea)
                {
                    tempMaxArea = currentArea;
                }

                if (height[x] < height[y])
                {
                    x++;
                }
                else
                {
                    y--;
                }

                //tempMaxAssertion++;
                //if(tempMaxAssertion > 1024)
                //{
                //    Console.WriteLine("something goes wrong");
                //    break;
                //}
            }
            return tempMaxArea;

            #endregion



            // return result;
        }


        public int MaxAreaNaive(int[] height)
        {
            // naive version which O(n^2)
            int maxArea = 0;
            for (int i = 0; i < height.Length - 1; i++)
            {
                for (int k = i + 1; k < height.Length; k++)
                {
                    var lowestHeight = height[i] < height[k] ? height[i] : height[k];
                    // var tempArea = height[i] * height[k];
                    var tempArea = lowestHeight * (k - i);
                    if (tempArea > maxArea)
                    {
                        maxArea = tempArea;
                    }
                }
            }
            return maxArea;
        }

    }
}
