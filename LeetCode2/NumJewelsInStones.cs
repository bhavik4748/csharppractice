using System;
using System.Collections.Generic;
using System.Text;


/*
You're given strings J representing the types of stones that are jewels, and S representing the stones you have.  Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.

The letters in J are guaranteed distinct, and all characters in J and S are letters. Letters are case sensitive, so "a" is considered a different type of stone from "A".

Example 1:

Input: J = "aA", S = "aAAbbbb"
Output: 3
Example 2:

Input: J = "z", S = "ZZ"
Output: 0
Note:

S and J will consist of letters and have length at most 50.
The characters in J are distinct.

    */
namespace LeetCode2
{
    partial class Program
    {
        public static int NumJewelsInStones(string J, string S)
        {
            char[] jChArr = J.ToCharArray();
            char[] sChArr = S.ToCharArray();
            int result = 0;
            Dictionary<char, char> d = new Dictionary<char, char>();

            for (int i = 0; i < jChArr.Length; ++i)
            {
                d.Add(jChArr[i], jChArr[i]);
            }

            for (int i = 0; i < sChArr.Length; ++i)
            {
                if (d.ContainsKey(sChArr[i]))
                    ++result;
            }

            return result;
        }
    }
}
