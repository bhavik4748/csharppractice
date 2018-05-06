using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{
    partial class Program
    {

        /*
         *Given a non-empty string s, you may delete at most one character. Judge whether you can make it a palindrome.

Example 1:
Input: "aba"
Output: True
Example 2:
Input: "abca"
Output: True
Explanation: You could delete the character 'c'.
Note:
The string will only contain lowercase characters a-z. The maximum length of the string is 50000. 
         * 
         * */
        public bool ValidPalindrome(string s)
        {

            char[] c = s.ToCharArray();
            int j = c.Length - 1;
            for (int i = 0; i < j; ++i)
            {
                if (c[i] != c[j])
                {
                    if (helperValidPalindrome(c, i + 1, j) || helperValidPalindrome(c, i, j - 1))
                        return true;
                    else
                        return false;
                }
                --j;
            }
            return true;
        }

        public static bool helperValidPalindrome(char[] c, int i, int j)
        {
            int k;
            for (k = i; k <= i + (j - i) / 2; ++k)
            {
                if (c[k] != c[j - k + i])
                    return false;
            }
            return true;
        }
    }
}
