using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{
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
