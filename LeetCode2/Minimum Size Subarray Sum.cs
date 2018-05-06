using System;
using System.Collections.Generic;
using System.Text;

/*
 * 
 * Given an array of n positive integers and a positive integer s, find the minimal length of a contiguous subarray of which the sum ≥ s. If there isn't one, return 0 instead.

Example: 

Input: [2,3,1,2,4,3], s = 7
Output: 2
Explanation: the subarray [4,3] has the minimal length under the problem constraint.
 * */


namespace LeetCode2
{
    partial class Program
    {
        public static int MinSubArrayLen(int s, int[] nums)
        {
            int minV = nums.Length + 1;
            int left = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                sum = sum + nums[i];
                while (sum >= s)
                {
                    minV = Math.Min(minV, i + 1 - left);
                    sum = sum - nums[left++];
                    // sum= 0;
                    //i=left;
                    // ++left;

                }

            }
            return minV != nums.Length + 1 ? minV : 0;
        }
    }
}
