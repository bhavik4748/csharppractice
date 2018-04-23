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
        public static bool ValidPalindrome(string s)
        {
            // s = "aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga";
            char[] c = s.ToCharArray();
            int odd = c.Length % 2;
            int j = c.Length - 1;
            int skip = 0;
            for (int i = 0; i < c.Length / 2; ++i)
            {
                if (c[i] == c[j])
                    --j;
                else
                {
                    if (i > -1 && i < c.Length / 2 && skip == 0)
                    {
                        if ((c[i + 1] == c[j]))
                        {
                            ++i;
                            --j;
                        }
                        else if (c[i] == c[j - 1])
                            j = j - 2;
                        else
                            return false;
                        ++skip;
                    }

                    else
                        return false;
                }
                //  if(skip == 0 ) ++ skip;
                //   else return false;
            }

            return true;
        }
    }
}
