using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2


/*
 * Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

Note:

The solution set must not contain duplicate triplets.

Example:

Given array nums = [-1, 0, 1, 2, -1, -4],

A solution set is:
[
[-1, 0, 1],
[-1, -1, 2]
]
 * 
 * 
 * */
{
    partial class Program
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {

            IList<IList<int>> res = new List<IList<int>>();
            Array.Sort(nums);
            HashSet<int> h = new HashSet<int>(nums);

            for (int i = 0; i < nums.Length - 2; ++i)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                for (int j = i + 1; j < nums.Length - 1; ++j)
                {

                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;

                    List<int> l = new List<int>();

                    var t = 0 - nums[i] - nums[j];
                    if (t > nums[j] && h.Contains(t)) res.Add(new[] { nums[i], nums[j], t });
                    else if (t == nums[j] && t == nums[j + 1]) res.Add(new[] { nums[i], t, t });


                }

            }
            return res;
        }
    }
}
