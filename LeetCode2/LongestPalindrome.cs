using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{
    partial class Program
    {
        public static string LongestPalindrome(string s)
        {
            if (s.Length < 1)
                return "";
            int start = 0, end = 0; ;

            for (int i = 0; i < s.Length; i++)
            {
                int len1 = HelperPalin(s, i, i);
                int len2 = HelperPalin(s, i, i + 1);

                int len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }

            return JavaStyleSubstring(s, start, end + 1);
        }



        static int HelperPalin(string s, int start, int end)
        {
            int L = start;
            int R = end;

            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }

            return R - L - 1;
        }

        static string JavaStyleSubstring(string s, int beginIndex, int endIndex)
        {
            // simulates Java substring function
            int len = endIndex - beginIndex;
            return s.Substring(beginIndex, len);
        }
    }
}
