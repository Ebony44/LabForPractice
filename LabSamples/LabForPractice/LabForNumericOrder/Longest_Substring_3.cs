using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.LabForNumericOrder
{
    class Longest_Substring_3
    {
        /*
         *
         * Longest_Substring_Without_Repeating_Characters_3
         *
         * Given a string s, find the length of the longest substring without repeating characters.

            Example 1:
            
            Input: s = "abcabcbb"
            Output: 3
            Explanation: The answer is "abc", with the length of 3.
            
            Example 2:
            
            Input: s = "bbbbb"
            Output: 1
            Explanation: The answer is "b", with the length of 1.
            
            Example 3:
            
            Input: s = "pwwkew"
            Output: 3
            Explanation: The answer is "wke", with the length of 3.
            Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

            Example 4:
            
            Input: s = "abcdaefg"
            Output: 7
            Explanation: The answer is "bcdaefg"
            
            Example 4:
            
            Input: s = "a123f145cx1a22"
            Output: 7
            Explanation: The answer is "a123f", "f145cx" ,"23f145cx"
            
             Example 5:
            
            Input: s = "abcdecfgaber"
            Output: 7
            Explanation: The answer is "abcde", "decfgab", "cfgaber"
            Explanation: The answer is ""
            
            Constraints:
            
                0 <= s.length <= 5 * 104
                s consists of English letters, digits, symbols and spaces.

         * 
         * 
         * 
         */

        public int LengthOfLongestSubstring(string s)
        {
            return -1;
        }

        // psuedo code
        // 1. store char
        // 2. if same met, stop it
        // 3. 

        public int LengthOfLongestSubstring_sec(string s)
        {
            char tempChar = 'a';

            // List<char> maxStoredChar = new List<char>(capacity: s.Length);
            string maxStoredChar = string.Empty;

            // List<char> storedChar = new List<char>(capacity: s.Length);
            string storedChar = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                tempChar = s[i];
                storedChar += tempChar;
                if(s.Length == 1)
                {
                    return storedChar.Length;
                }
                // var tempCurrentStartChar = s[i];
                for (int k = i + 1; k < s.Length; k++)
                {
                    // Console.WriteLine("start sub for statement, k is " + s[k]);
                    if (storedChar.Contains(s[k]) == false)
                    {
                        storedChar += s[k];
                        if (maxStoredChar.Length >= storedChar.Length
                            && (k == s.Length-1))
                        {
                            storedChar = string.Empty;
                        }
                    }
                    else
                    {
                        // same char met, break it
                        // i = k;
                        if(maxStoredChar.Length < storedChar.Length)
                        {
                            maxStoredChar = storedChar;
                            storedChar = string.Empty;
                        }
                        else if(maxStoredChar.Length >= storedChar.Length)
                        {
                            storedChar = string.Empty;
                        }
                        break;
                    }
                    if(k == s.Length-1)
                    {
                        i = k;
                        if (maxStoredChar.Length < storedChar.Length)
                        {
                            maxStoredChar = storedChar;
                        }
                        break;
                    }
                }
            }

            // abcd, length 4
            // b, i=1
            // 
            return maxStoredChar.Length;
        }

    }
}
