using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.LabForNumericOrder
{

    /*
     * 
     * 
     * Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

        Symbol       Value
        I             1
        V             5
        X             10
        L             50
        C             100
        D             500
        M             1000
        
        For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
        
        Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:
        
            I can be placed before V (5) and X (10) to make 4 and 9. 
            X can be placed before L (50) and C (100) to make 40 and 90. 
            C can be placed before D (500) and M (1000) to make 400 and 900.
        
        Given an integer, convert it to a roman numeral.
        
         
        
        Example 1:
        
        Input: num = 3
        Output: "III"
        Explanation: 3 is represented as 3 ones.
        
        Example 2:
        
        Input: num = 58
        Output: "LVIII"
        Explanation: L = 50, V = 5, III = 3.
        
        Example 3:
        
        Input: num = 1994
        Output: "MCMXCIV"
        Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
        
         
        
        Constraints:
        
            1 <= num <= 3999


     * 
     */

    class Integer_to_Roman_12
    {
        public string IntToRoman(int num)
        {
            var result = string.Empty;
            // 0.
            // 3999 -> MMMCMXCIX
            // MMM(3000)
            // CM(900)
            // XC(90)
            // IX(9)
            StringBuilder sb = new StringBuilder();
            var fourth = num / 1000;
            var third = (num / 100) % 10;
            var second = (num / 10) % 10;
            var first = num % 10;

            if (fourth != 0)
            {
                for (int i = 0; i < fourth; i++)
                {
                    sb.Append("M");
                }
            }
            if(third != 0)
            {
                if (third == 4)
                {
                    sb.Append("CD");
                }
                else if(third == 9)
                {
                    sb.Append("CM");
                }
                else if (third >= 5)
                {
                    var tempThird = third - 5;
                    if(tempThird >= 0)
                    {
                        
                    }
                    else if(tempThird < 0)
                    {

                    }
                    sb.Append("D");
                }
                
            }

            return result;
        }

        public bool IsfourOrNine(int num)
        {
            return num == 4 || num == 9;
        }
        public string GetStringFromCount(int iterateCount, string appendString)
        {
            var resultString = string.Empty;
            if(iterateCount >= 5)
            {

            }
            else
            {

            }
            return resultString;
            
        }
    }
}
