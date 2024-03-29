﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.LabForNumericOrder
{
    

    class Palindromic_5
    {
        // Longest Palindromic Substring

        /*
         * 
         * Given a string s, return the longest palindromic substring in s.

            Example 1:
            
            Input: s = "babad"
            Output: "bab"
            Explanation: "aba" is also a valid answer.
            
            Example 2:
            
            Input: s = "cbbd"
            Output: "bb"
            
            
            Constraints:
            
                1 <= s.length <= 1000
                s consist of only digits and English letters.

         * 
         * 
         * 
         * 
            Example 3:
            
            Input: s = "qweewq"
            Output: "qweewq"
         * 
         * Example 4:
            
            Input: s = "qwerasxw"
            Output: "q" // no palindromic matched
            start and end index

        * Example 5:
            
            Input: s = "wxqwabbaffffffff"
            Output: "abba" 
            

         *  
         * 
         * 
         */

        public string LongestPalindrome(string s)
        {
            // 0. first will match last.. and so on

            //string firstS = s;
            //string lastS = s.Reverse().ToString();

            //int matchedCount = 0;
            //char formerOne = ' ';
            //char latterOne = ' ';
            //var formerIdx = 0;
            //var latterIdx = lastS.Length - 1;
            //// 1. 
            //for (int i = 0; i < firstS.Length / 2; i++)
            //{
            //    formerOne = firstS[formerIdx + i];
            //    latterOne = lastS[latterIdx - i];
            //    if(formerOne.Equals(latterOne))
            //    {

            //    }

            //}


            // 2. grab one by one
            const int ASSERTION_MAXCOUNT = 500;
            int assertionCount = 0;
            string caughtString = string.Empty;
            while(true)
            {
                
                if(assertionCount >= ASSERTION_MAXCOUNT)
                {
                    break;
                }
                assertionCount++;
            }
            // 2.1. check length is even or odd()
            #region
            int midPoint = 0;
            midPoint = midPoint / 2;
            if (caughtString.Length % 2 == 0)
            {
                midPoint = midPoint / 2;
            }
            else
            {
                midPoint = (midPoint / 2);
            }
            #endregion

            //#region sample from Cpp
            //StringBuilder sb = new StringBuilder();
            //string line = string.Empty;
            //for (int i = (int)s.Length - 1; i >= 0; --i)
            //{
            //    sb.Append(s[i]);
            //}
            //line = sb.ToString();
            //#endregion

            return string.Empty;
        }

        public string LongestPalindrome_Altered(string s)
        {
            #region old
            //Dictionary<char, int> letterOccurence = new Dictionary<char, int>(capacity: 26);

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if(letterOccurence.ContainsKey(s[i]) )
            //    {
            //        letterOccurence.Add(s[i], letterOccurence[s[i]] + 1);
            //    }
            //    else
            //    {
            //        letterOccurence.Add(s[i], 1);
            //    }
            //}
            //// check length is odd or even

            //bool bIsOdd = false;
            //if(s.Length % 2 == 0)
            //{
            //    bIsOdd = false;
            //}
            //else
            //{
            //    bIsOdd = true;
            //}

            //// check letters are matched
            #endregion

            #region
            string reversedString = s.Reverse().ToString();
            // abac -> caba
            #endregion

            return string.Empty;
        }

        public bool CheckPalindromic(string s)
        {
            bool bIsValid = false;
            bool bIsFinished = false;
            #region sample from Cpp, store it with reversed order
            StringBuilder sb = new StringBuilder();
            string line = string.Empty;
            for (int i = (int)s.Length - 1; i >= 0; --i)
            {
                sb.Append(s[i]);
            }
            line = sb.ToString();
            #endregion
            while (bIsFinished == false)
            {

            }
            return bIsValid;

        }

        public int LongestCommonSubstring(string str1, string str2, out string subStr)
        {
            subStr = string.Empty;

            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
                return 0;

            int[,] num = new int[str1.Length, str2.Length];
            int maxlen = 0;
            int lastSubsBegin = 0;
            StringBuilder subStrBuilder = new StringBuilder();

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] != str2[j])
                    {
                        num[i, j] = 0;
                    }
                    else
                    {
                        if ((i == 0) || (j == 0))
                            num[i, j] = 1;
                        else
                            num[i, j] = 1 + num[i - 1, j - 1];

                        if (num[i, j] > maxlen)
                        {
                            maxlen = num[i, j];

                            int thisSubsBegin = i - num[i, j] + 1;

                            if (lastSubsBegin == thisSubsBegin)
                            {
                                subStrBuilder.Append(str1[i]);
                            }
                            else
                            {
                                lastSubsBegin = thisSubsBegin;
                                subStrBuilder.Length = 0;
                                subStrBuilder.Append(str1.Substring(lastSubsBegin, (i + 1) - lastSubsBegin));
                            }
                        }
                    }
                }
            }

            subStr = subStrBuilder.ToString();

            return maxlen;
        }


    }
}
