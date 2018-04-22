using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{
   partial class Program
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {

            IList<IList<int>> res = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; ++i)
            {

                for (int j = i + 1; j < nums.Length - 1; ++j)
                {

                    List<int> l = new List<int>();
                    for (int k = 0; k < nums.Length; ++k)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            l.Add(nums[i]);
                            l.Add(nums[j]);
                            l.Add(nums[k]);
                        }

                    }
                    if (l.Count > 0)
                        res.Add(l);

                }

            }
            return res;
        }
    }
}
