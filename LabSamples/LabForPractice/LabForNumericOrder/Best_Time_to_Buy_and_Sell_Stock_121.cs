using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.LabForNumericOrder
{
    class Best_Time_to_Buy_and_Sell_Stock_121
    {
        /*
         * 
         * You are given an array prices where prices[i] is the price of a given stock on the ith day.
            
            You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
            
            Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
            
            Example 1:
            
            Input: prices = [7,1,5,3,6,4]
            Output: 5
            Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
            Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
            
            Example 2:
            
            Input: prices = [7,6,4,3,1]
            Output: 0
            Explanation: In this case, no transactions are done and the max profit = 0.
            
             
            
            Constraints:
            
                1 <= prices.length <= 105
                0 <= prices[i] <= 104

         * 
         * 
         */

        public int MaxProfit(int[] prices)
        {

            #region
            //int result = 0;

            //int x = 0;
            //int y = prices.Length - 1;
            //int tempAssertion = 0;
            //while(x < y)
            //{
            //    int leftValue = prices[x];
            //    int rightValue = prices[y];

            //    if(leftValue > rightValue)
            //    {
            //        x++;
            //    }
            //    else
            //    {
            //        // can make profit
            //        var profit = rightValue - leftValue;
            //        if (result < profit)
            //        {
            //            result = profit;
            //        }
            //        y--;
            //    }
            //    //if(tempAssertion > 1024)
            //    //{
            //    //    Console.WriteLine("some assertion occurs");
            //    //    break;
            //    //}
            //    //tempAssertion++;

            //}
            //// 5,6,7,6,7,6,4,4,4,4,4,4
            //// result 0
            //// expected 2
            //return result;
            #endregion

            // cheated do NOT submit

            int result = 0;
            int buy = int.MaxValue;
            int maxProfit = 0;
            int boughtItemPrice = 0;
            int boughtItem = 0;
            int mostSellPrice = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < buy)
                {
                    buy = prices[i];
                }
                int currentProfit = prices[i] - buy;
                if(currentProfit > maxProfit)
                {
                    maxProfit = currentProfit;
                }

                //if(boughtItem < prices[i])
                //{
                //    boughtItemPrice = prices[i] - boughtItem;
                //    boughtItem = prices[i];
                //    if(mostSellPrice < boughtItemPrice)
                //    {
                //        mostSellPrice = boughtItemPrice;
                //    }
                //}

            }

            return maxProfit;




        }

        public int MaxProfitNaive(int[] prices)
        {
            // naive way, O(n^2)
            int result = 0;
            //if(prices.Length == 2)
            //{
            //    int leftValue = prices[0];
            //    int rightValue = prices[1];
            //    int tempResult = rightValue > leftValue ? rightValue - leftValue : 0;
            //    if (result < tempResult)
            //    {
            //        result = tempResult;
            //    }
            //    return result;
            //}
            for (int i = 0; i < prices.Length; i++)
            {
                for (int k = i + 1; k < prices.Length; k++)
                {
                    int leftValue = prices[i];
                    int rightValue = prices[k];
                    int tempResult = rightValue > leftValue ? rightValue - leftValue : 0;
                    if (result < tempResult)
                    {
                        result = tempResult;
                    }

                    
                }
            }
            return result;
        }

    }
}
