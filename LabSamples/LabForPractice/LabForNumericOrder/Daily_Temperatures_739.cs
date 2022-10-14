using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.LabForNumericOrder
{
    class Daily_Temperatures_739
    {
        // monotonic stack problem

        /*
         * 
         * Given an array of integers temperatures represents the daily temperatures, 
         * return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature. 
         * If there is no future day for which this is possible, keep answer[i] == 0 instead.

            Example 1:
            
            Input: temperatures = [73,74,75,71,69,72,76,73]
            Output: [1,1,4,2,1,1,0,0]
            
            Example 2:
            
            Input: temperatures = [30,40,50,60]
            Output: [1,1,1,0]
            
            Example 3:
            
            Input: temperatures = [30,60,90]
            Output: [1,1,0]

         * 
         * 
         */
        public int[] DailyTemperatures(int[] temperatures)
        {
            //  Input: temperatures = [73, 74, 75, 71, 69, 72, 76, 73]
            //    Output:[1,1,4,2,1,1,0,0]
            // [73,74,75,75,75,75,76,76]
            // 1,1,4

            //  Input: temperatures = [4, 3, 2, 1]
            //    Output:[0,0,0,0]
            //  Input: temperatures = [1, 3, 2, 4]
            //    Output:[1,2,1,0]

            #region function
            int[] waitingDays = new int[temperatures.Length];
            
            if(temperatures.Length == 1)
            {
                waitingDays[0] = 0;
                return waitingDays;
            }
            Stack<int> waitingStack = new Stack<int>(temperatures.Length);
            Stack<ValueTuple<int,int>> waitingTupleStack = new Stack<ValueTuple<int, int>>(temperatures.Length);
            // item 1 for index of array temperatures ,2 for day
            // Stack<Dictionary<int,int>> waitingDicStack = new Stack<Dictionary<int, int>>(temperatures.Length);
            // key for temperature, value for waiting day
            waitingTupleStack.Push((0, 0));
            for (int i = 1; i < temperatures.Length; i++)
            {
                
                int currentTemp = temperatures[i];
                var peekTemp = temperatures[waitingTupleStack.Peek().Item1];
                var peekTempIndex = waitingTupleStack.Peek().Item1;
                // int tempAssertion = 0;
                while (peekTemp < currentTemp && waitingTupleStack.Count > 0)
                {
                    
                    var poppedTemp = waitingTupleStack.Pop();
                    // poppedTemp.Item2++;
                    waitingDays[poppedTemp.Item1] = (i - poppedTemp.Item2);
                    // 2
                    // 6
                    //tempAssertion++;
                    //if (tempAssertion > 256)
                    //{
                    //    Console.WriteLine("assertion failed");
                    //    break;
                    //}

                    if(waitingTupleStack.Count > 0)
                    {
                        peekTemp = temperatures[waitingTupleStack.Peek().Item1];
                    }

                }
                waitingTupleStack.Push((i, i));

            }
            return waitingDays;
            #endregion


        }
    }
}
