using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{

    /*
     * Given a set of distinct integers, nums, return all possible subsets (the power set).

Note: The solution set must not contain duplicate subsets.

Example:

Input: nums = [1,2,3]
Output:
[
  [3],
  [1],
  [2],
  [1,2,3],
  [1,3],
  [2,3],
  [1,2],
  []
]
     * 
     * */
    partial class Program
    {
        public static IList<IList<int>> Subsets(int[] nums)
        {

            IList<IList<int>> r = new List<IList<int>>();
            r.Add(new List<int>());

            for (int i = 0; i < nums.Length; ++i)
            {

                IList<IList<int>> temp = new List<IList<int>>();

                for (int j = 0; j < r.Count; ++j)
                {
                    IList<int> curr = new List<int>(r[j]);
                    curr.Add(nums[i]);
                    temp.Add(curr);
                }

                for (int j = 0; j < temp.Count; ++j)
                {
                    r.Add(temp[j]);
                }
            }

            return r;

        }
    }
}
