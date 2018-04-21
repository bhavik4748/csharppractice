using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    //  string input = "babad";
    //  string input = "cbbd";
    public partial class Program
    {
        public static string LongestPalindrome(string s)
        {
            int max = 0;
            string res = "";
            if (s.Length == 1)
                return s;


            for (int i = 0; i < s.Length; ++i)
            {
                for (int j = 1; j < (s.Length - i + 1); ++j)
                {
                    var t = "";
                    t = s.Substring(i, j);
                    if (Palindrome(t))
                    {
                        if (max < j)
                        {
                            max = j;
                            res = t;
                        }
                    }

                }
            }
            return res;
        }

        static Dictionary<string, bool> d = new Dictionary<string, bool>();

        public static bool Palindrome(string str)
        {
            if (str.Length == 1)
                return true;
            //else if (str.Length == 2)
            //    return (str.Substring(0, 1) == str.Substring(1));
            else
            {
                if (d.ContainsKey(str))
                    return d[str];
                else
                    return Palindrome(str.Substring(0, str.Length / 2)) && (Palindrome(str.Substring((str.Length / 2) + 1, str.Length)));
                //return str.SequenceEqual(str.Reverse());
            }

        }
    }
}
